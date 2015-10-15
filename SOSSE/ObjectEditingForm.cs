using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOSSE
{
    public partial class ObjectEditingForm : Form
    {
        private const int objectOffset = 0x2B302;

        public bool DataLoaded { get; private set; }
        public bool IsModified { get; private set; }

        public const int MaxObject = 1086;
        public const int MaxRealObject = 904;
        public static string[] ObjectNameList = null;

        public ObjectEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            IsModified = false;
            Util.LoadObjectNameList();

            objectNameColumn.Items.Add("None");
            foreach (string s in ObjectNameList)
            {
                if (!s.Equals(""))
                    objectNameColumn.Items.Add(s);
            }
            objectDataGridView.Rows.Add(999);
            objectDataGridView.CancelEdit();

            for (int i = 0; i < 999; i++)
            {
                int objectIndex = BitConverter.ToInt16(MainForm.SaveData, objectOffset + 4 * i);
                objectDataGridView.Rows[i].Cells[1].Value =
                    BitConverter.ToInt16(MainForm.SaveData, objectOffset + 4 * i + 2);
                if (objectIndex == -1)
                {
                    objectDataGridView.Rows[i].Cells[0].Value = "None";
                    objectDataGridView.Rows[i].Cells[1].ReadOnly = true;
                    objectDataGridView.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                }
                else
                    objectDataGridView.Rows[i].Cells[0].Value = ObjectNameList[objectIndex];
            }
            DataLoaded = true;
        }

        private void objectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            ComboBox cb;
            try
            {
                cb = (ComboBox)objectDataGridView.EditingControl;
            }
            catch (InvalidCastException)
            {
                return;
            }
            if (cb != null) cb.DroppedDown = true;
        }

        private void objectDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (objectDataGridView.CurrentCell.ColumnIndex == 0 &&
                objectDataGridView.IsCurrentCellDirty)
                objectDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void objectDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            if (!IsModified) IsModified = true;
            if (e.ColumnIndex == 0)
            {
                if (objectDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "None")
                {
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Value = 1;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Style.BackColor =
                        objectDataGridView.DefaultCellStyle.BackColor;
                }
                else
                {
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Value = 0;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = true;
                    objectDataGridView.Rows[e.RowIndex].Cells[1].Style.BackColor =
                        Color.LightGray;
                }
            }
        }

        private void objectDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (objectDataGridView.Rows[e.RowIndex].IsNewRow) return;
            if (objectDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly) return;
            if (e.ColumnIndex == 1)
            {
                int amount;
                bool isValidAmount = Int32.TryParse(e.FormattedValue.ToString(), out amount);
                if (!isValidAmount || amount < 1 || amount > 99)
                {
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ErrorText =
                        "Amount must be a valid number between 1 and 99";
                    objectDataGridView.CancelEdit();
                }
                else
                    objectDataGridView.Rows[e.RowIndex].Cells[1].ErrorText = null;
            }
        }

        public void SaveObjects()
        {
            if (!IsModified) return;
            Tuple<ushort, short>[] objectList = new Tuple<ushort, short>[999];
            for (int i = 0; i < 999; i++)
            {
                int objectIndex = Array.IndexOf(ObjectNameList, 
                    objectDataGridView.Rows[i].Cells[0].Value.ToString());
                short amount;
                bool isValidAmount = Int16.TryParse(objectDataGridView.Rows[i].Cells[1].Value.ToString(),
                    out amount);
                objectList[i] = Tuple.Create((ushort)(objectIndex & 0xFFFF), amount);
            }
            Array.Sort(objectList, (x, y) => x.Item1.CompareTo(y.Item1));
            int localOffset = objectOffset;
            for (int i = 0; i < 999; i++)
            {
                MainForm.SaveData[localOffset] = (byte)(objectList[i].Item1 & 0xFF);
                MainForm.SaveData[localOffset + 1] =
                    (byte)((objectList[i].Item1 >> 8) & 0xFF);
                MainForm.SaveData[localOffset + 2] =
                    (byte)(objectList[i].Item2 & 0xFF);
                MainForm.SaveData[localOffset + 3] =
                    (byte)((objectList[i].Item2 >> 8) & 0xFF);
                localOffset += 4;
            }
        }

        private void objectx99Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 999; i++)
            {
                if ((string)objectDataGridView.Rows[i].Cells[0].Value != "None")
                    objectDataGridView.Rows[i].Cells[1].Value = 99;
            }
        }

        private void ObjectEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveObjects();
        }
    }
}
