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
    public partial class NPCEditingForm : Form
    {
        private int npcOffset = 0x100; // may be misaligned, though.
        private int currentNPC;
        
        public const int MaxNPC = 33;
        public bool DataLoaded { get; set; }
        public static string[] NPCNameList;

        public NPCEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            Util.LoadNPCName();

            npcComboBox.Items.AddRange(NPCNameList);
            npcComboBox.SelectedIndex = 0;
            // Implicitly call npcComboBox_SelectedIndexChanged
        }

        // Test method
        private void dump()
        {
            string[] lines = new string[MaxNPC];
            for (int i = 0; i < MaxNPC; i++)
                for (int j = 0; j < 84; j++)
                {
                    lines[i] += MainForm.SaveData[npcOffset + 84 * i + j].ToString("X2");
                }
            System.IO.File.WriteAllLines("NPCData.txt", lines);
            this.Close();
        }

        private void displayNPC(int npcID)
        {
            DataLoaded = false;
            int baseOffset = npcOffset + 84 * npcID;
            friendshipNumericUpDown.Value = BitConverter.ToUInt16(MainForm.SaveData,
                baseOffset + 0x20);
            giftNumericUpDown.Value = BitConverter.ToUInt16(MainForm.SaveData,
                baseOffset + 0x24);
            bestGiftNumericUpDown.Value = BitConverter.ToUInt16(MainForm.SaveData,
                baseOffset + 0x26);
            intervalNumericUpDown.Value = MainForm.SaveData[baseOffset + 0x40];
            DataLoaded = true;
        }

        private void saveCurrentNPC()
        {
            int baseOffset = npcOffset + 84 * currentNPC;
            ushort friendship = (ushort)friendshipNumericUpDown.Value;
            MainForm.SaveData[baseOffset + 0x20] = (byte)(friendship & 0xFF);
            MainForm.SaveData[baseOffset + 0x21] = (byte)((friendship >> 8) & 0xFF);
            ushort giftCount = (ushort)giftNumericUpDown.Value;
            MainForm.SaveData[baseOffset + 0x24] = (byte)(giftCount & 0xFF);
            MainForm.SaveData[baseOffset + 0x25] = (byte)((giftCount >> 8) & 0xFF);
            ushort bestGiftCount = (ushort)bestGiftNumericUpDown.Value;
            MainForm.SaveData[baseOffset + 0x26] = (byte)(bestGiftCount & 0xFF);
            MainForm.SaveData[baseOffset + 0x27] = (byte)((bestGiftCount >> 8) & 0xFF);
            MainForm.SaveData[baseOffset + 0x40] = (byte)(intervalNumericUpDown.Value);
        }

        private void npcComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataLoaded) saveCurrentNPC();
            currentNPC = npcComboBox.SelectedIndex;
            displayNPC(currentNPC);
        }

        private void NPCEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveCurrentNPC();
        }
    }
}
