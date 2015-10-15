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
    public partial class GeneralEditingForm : Form
    {
        private ulong currentMoney;

        public static string[] Month;

        public GeneralEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            Util.LoadMonth();

            monthComboBox.Items.AddRange(Month);
            for (int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i);
            }
            
            yearNumericUpDown.Value = BitConverter.ToUInt16(MainForm.SaveData, 0x00) + 1;
            monthComboBox.SelectedIndex = MainForm.SaveData[0x02];
            dayComboBox.SelectedIndex = MainForm.SaveData[0x03];
            hourNumericUpDown.Value = BitConverter.ToInt16(MainForm.SaveData, 0x20) + 6;
            minuteNumericUpDown.Value = BitConverter.ToInt16(MainForm.SaveData, 0x22);
            moneyTextBox.Text = BitConverter.ToUInt64(MainForm.SaveData, 0x98).ToString();
            healthNumericUpDown.Value = BitConverter.ToInt16(MainForm.SaveData, 0xA0);
            staminaNumericUpDown.Value = BitConverter.ToInt16(MainForm.SaveData, 0xA4);
        }

        private void moneyTextBox_TextChanged(object sender, EventArgs e)
        {
            ulong money;
            bool isValid = UInt64.TryParse(moneyTextBox.Text, out money);
            if (!isValid)
            {
                MessageBox.Show("Invalid number");
                moneyTextBox.Text = currentMoney.ToString();
            }
            else
                currentMoney = money;
        }

        /// <summary>
        /// Save all data to the main save file
        /// </summary>
        public void SaveGeneral()
        {
            ushort year = (ushort)(yearNumericUpDown.Value - 1);
            MainForm.SaveData[0x00] = (byte)(year & 0xFF);
            MainForm.SaveData[0x01] = (byte)((year >> 8) & 0xFF);
            MainForm.SaveData[0x02] = (byte)monthComboBox.SelectedIndex;
            MainForm.SaveData[0x03] = (byte)dayComboBox.SelectedIndex;
            short hour = (short)(hourNumericUpDown.Value - 6);
            MainForm.SaveData[0x20] = (byte)(hour & 0xFF);
            MainForm.SaveData[0x21] = (byte)((hour >> 8) & 0xFF);
            short minute = (short)(minuteNumericUpDown.Value);
            MainForm.SaveData[0x22] = (byte)(minute & 0xFF);
            MainForm.SaveData[0x23] = (byte)((minute >> 8) & 0xFF);
            ulong money;
            bool isValid = UInt64.TryParse(moneyTextBox.Text, out money);
            if (isValid)
                Array.Copy(BitConverter.GetBytes(money), 0, MainForm.SaveData, 0x98, 8);
            ushort health = (ushort)healthNumericUpDown.Value;
            MainForm.SaveData[0xA0] = (byte)(health & 0xFF);
            MainForm.SaveData[0xA1] = (byte)((health >> 8) & 0xFF);
            ushort stamina = (ushort)staminaNumericUpDown.Value;
            MainForm.SaveData[0xA4] = (byte)(stamina & 0xFF);
            MainForm.SaveData[0xA5] = (byte)((stamina >> 8) & 0xFF);
        }

        private void GeneralEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGeneral();
        }
    }
}
