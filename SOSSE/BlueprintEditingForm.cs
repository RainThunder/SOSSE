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
    public partial class BlueprintEditingForm : Form
    {
        private const int blueprintOffset = 0x314A4;
        private const int blueprintSetOffset = 0x318EC;

        public const int MaxBlueprint = 1096;
        public const int MaxBlueprintSet = 820;
        public static string[] BlueprintNameList;
        public static string[] BlueprintSetNameList;

        public BlueprintEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            Util.LoadBlueprintNameList();
            Util.LoadBlueprintSetNameList();

            blueprintDataGridView.Rows.Add(MaxBlueprint);
            for (int i = 0; i < MaxBlueprint; i++)
            {
                var row = blueprintDataGridView.Rows[i];
                row.Cells[0].Value = BlueprintNameList[i];
                row.Cells[1].Value =
                    ((MainForm.SaveData[blueprintOffset + i] & 0x1) == 0x1);
            }
            blueprintSetDataGridView.Rows.Add(MaxBlueprintSet);
            for (int i = 0; i < MaxBlueprintSet; i++)
            {
                var row = blueprintSetDataGridView.Rows[i];
                row.Cells[0].Value = BlueprintSetNameList[i];
                row.Cells[1].Value =
                    ((MainForm.SaveData[blueprintSetOffset + i] & 0x1) == 0x1);
            }
        }

        private void allBlueprintButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxBlueprint; i++)
                if (!BlueprintNameList[i].StartsWith("Dummy"))
                    blueprintDataGridView.Rows[i].Cells[1].Value = true;
        }

        private void allBlueprintSetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxBlueprintSet; i++)
                blueprintSetDataGridView.Rows[i].Cells[1].Value = true;
        }

        /// <summary>
        /// Save blueprint data to the main save.
        /// </summary>
        public void SaveBlueprints()
        {
            for (int i = 0; i < MaxBlueprint; i++)
            {
                bool available = (bool)blueprintDataGridView.Rows[i].Cells[1].Value;
                if (available)
                    MainForm.SaveData[blueprintOffset + i] |= 0x1;
                else
                    MainForm.SaveData[blueprintOffset + i] &= 0xFE;
            }
            for (int i = 0; i < MaxBlueprintSet; i++)
            {
                bool available = (bool)blueprintSetDataGridView.Rows[i].Cells[1].Value;
                if (available)
                    MainForm.SaveData[blueprintSetOffset + i] |= 0x1;
                else
                    MainForm.SaveData[blueprintSetOffset + i] &= 0xFE;
            }
        }

        private void BlueprintEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveBlueprints();
        }
    }
}
