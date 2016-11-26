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
    public partial class EventFlagEditingForm : Form
    {
        private const int EventFlagOffset = 0x10AC;

        public const int MaxEventFlag = 539;
        public bool DataLoaded { get; private set; }
        public static string[] EventFlagList;

        public EventFlagEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            Util.LoadEventFlag();

            eventDataGridView.Rows.Add(MaxEventFlag);
            for (int i = 0; i < MaxEventFlag; i++)
            {
                var row = eventDataGridView.Rows[i];
                row.Cells[0].Value = EventFlagList[i];
                row.Cells[1].Value = BitConverter.ToInt32(MainForm.SaveData, EventFlagOffset + 4 * i);
            }
        }

        private void dump()
        {
            string[] lines = new string[MaxEventFlag];
            for (int i = 0; i < MaxEventFlag; i++)
            {
                lines[i] = BitConverter.ToInt32(MainForm.SaveData, EventFlagOffset + 4 * i).ToString();
            }
            System.IO.File.WriteAllLines("EventFlag.txt", lines);
        }

        /// <summary>
        /// Save event data to main save file
        /// </summary>
        public void SaveEvent()
        {
            for (int i = 0; i < MaxEventFlag; i++)
            {
                int value;
                bool isValid = Int32.TryParse(eventDataGridView.Rows[i]
                    .Cells[1].Value.ToString(), out value);
                if (isValid)
                    Array.Copy(BitConverter.GetBytes(value), 0, MainForm.SaveData,
                        EventFlagOffset + 4 * i, 4);
            }
        }

        private void EventEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEvent();
        }
    }
}
