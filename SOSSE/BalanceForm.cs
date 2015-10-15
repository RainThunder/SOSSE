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
    public partial class BalanceForm : Form
    {
        private const int balanceOffset = 0x510B0;
        private const int maxEntries = 68;

        public BalanceForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();

            balanceDataGridView.Rows.Add(maxEntries);
            balanceDataGridView.Rows[0].Cells[0].Value = "Two years ago";
            balanceDataGridView.Rows[0].Cells[1].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset);
            balanceDataGridView.Rows[0].Cells[2].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x8);
            balanceDataGridView.Rows[1].Cells[0].Value = "One year ago";
            balanceDataGridView.Rows[1].Cells[1].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x10);
            balanceDataGridView.Rows[1].Cells[2].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x18);
            balanceDataGridView.Rows[2].Cells[0].Value = "Spring of this year";
            balanceDataGridView.Rows[2].Cells[1].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x20);
            balanceDataGridView.Rows[2].Cells[2].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x28);
            balanceDataGridView.Rows[3].Cells[0].Value = "Summer of this year";
            balanceDataGridView.Rows[3].Cells[1].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x30);
            balanceDataGridView.Rows[3].Cells[2].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x38);
            balanceDataGridView.Rows[4].Cells[0].Value = "Fall of this year";
            balanceDataGridView.Rows[4].Cells[1].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x40);
            balanceDataGridView.Rows[4].Cells[2].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x48);
            balanceDataGridView.Rows[5].Cells[0].Value = "Winter of this year";
            balanceDataGridView.Rows[5].Cells[1].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x50);
            balanceDataGridView.Rows[5].Cells[2].Value =
                BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x58);

            balanceDataGridView.Rows[6].Cells[0].Value =
                "1st day of the previous month";
            balanceDataGridView.Rows[7].Cells[0].Value =
                "2nd day of the previous month";
            balanceDataGridView.Rows[8].Cells[0].Value =
                "3rd day of the previous month";
            balanceDataGridView.Rows[26].Cells[0].Value =
                "21st day of the previous month";
            balanceDataGridView.Rows[27].Cells[0].Value =
                "22nd day of the previous month";
            balanceDataGridView.Rows[28].Cells[0].Value =
                "23rd day of the previous month";
            balanceDataGridView.Rows[36].Cells[0].Value =
                "31st day of the previous month";
            balanceDataGridView.Rows[37].Cells[0].Value =
                "1st day of this month";
            balanceDataGridView.Rows[38].Cells[0].Value =
                "2nd day of this month";
            balanceDataGridView.Rows[39].Cells[0].Value =
                "3rd day of this month";
            balanceDataGridView.Rows[57].Cells[0].Value =
                "21st day of this month";
            balanceDataGridView.Rows[58].Cells[0].Value =
                "22nd day of this month";
            balanceDataGridView.Rows[59].Cells[0].Value =
                "23rd day of this month";
            balanceDataGridView.Rows[67].Cells[0].Value =
                "31st day of this month";
            for (int i = 1; i < 32; i++)
            {
                var cell = balanceDataGridView.Rows[5 + i].Cells[0];
                if (cell.Value == null)
                    cell.Value = String.Format("{0}th day of the previous month", i);
            }
            for (int i = 1; i < 32; i++)
            {
                var cell = balanceDataGridView.Rows[36 + i].Cells[0];
                if (cell.Value == null)
                    cell.Value = String.Format("{0}th day of this month", i);
            }

            for (int i = 0; i < 62; i++)
            {
                balanceDataGridView.Rows[6 + i].Cells[1].Value =
                    BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x60 + 16 * i);
                balanceDataGridView.Rows[6 + i].Cells[2].Value =
                    BitConverter.ToInt64(MainForm.SaveData, balanceOffset + 0x68 + 16 * i);
            }
        }
    }
}
