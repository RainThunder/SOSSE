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
    public partial class PatternEditingForm : Form
    {
        private const int patternSetOffset = 0x4279C;
        private const int patternOffset = 0x4293A;

        public const int MaxPattern = 266;
        public const int MaxPatternSet = 158;
        public static string[] PatternNameList;
        public static string[] PatternSetNameList;

        public PatternEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            Util.LoadPatternNameList();
            Util.LoadPatternSetNameList();

            patternDataGridView.Rows.Add(MaxPattern);
            for (int i = 0; i < MaxPattern; i++)
            {
                var row = patternDataGridView.Rows[i];
                row.Cells[0].Value = PatternNameList[i];
                row.Cells[1].Value = (MainForm.SaveData[patternOffset + i] & 0x1) == 0x1;
            }

            patternSetDataGridView.Rows.Add(MaxPatternSet);
            for (int i = 0; i < MaxPatternSet; i++)
            {
                var row = patternSetDataGridView.Rows[i];
                row.Cells[0].Value = PatternSetNameList[i];
                row.Cells[1].Value = (MainForm.SaveData[patternSetOffset + i] & 0x1) == 0x1;
            }
        }

        private void allPatternButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxPattern; i++)
                patternDataGridView.Rows[i].Cells[1].Value = true;
        }

        private void allPatternSetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxPatternSet; i++)
                patternSetDataGridView.Rows[i].Cells[1].Value = true;
        }

        /// <summary>
        /// Save pattern data to the main save
        /// </summary>
        public void SavePattern()
        {
            for (int i = 0; i < MaxPattern; i++)
            {
                bool isAvailable = (bool)patternDataGridView.Rows[i].Cells[1].Value;
                if (isAvailable)
                    MainForm.SaveData[patternOffset + i] |= 0x1;
                else
                    MainForm.SaveData[patternOffset + i] &= 0xFE;
            }
            for (int i = 0; i < MaxPatternSet; i++)
            {
                bool isAvailable = (bool)patternSetDataGridView.Rows[i].Cells[1].Value;
                if (isAvailable)
                    MainForm.SaveData[patternSetOffset + i] |= 0x1;
                else
                    MainForm.SaveData[patternSetOffset + i] &= 0xFE;
            }
        }

        private void PatternEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePattern();
        }
    }
}
