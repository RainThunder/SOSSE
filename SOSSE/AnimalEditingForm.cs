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
    public partial class AnimalEditingForm : Form
    {
        #region Animal class
        public class Animal
        {
            private byte[] animalBytes;
            public enum Personality { Levelheaded, Active, Cowardly };
            public enum Status { Healthy, Angry, Sick };

            public short Type
            {
                get
                {
                    return BitConverter.ToInt16(animalBytes, 0x00);
                }
                set
                {
                    animalBytes[0x00] = (byte)(value & 0xFF);
                    animalBytes[0x01] = (byte)((value >> 8) & 0xFF);
                }
            }
            public byte ID
            {
                get
                {
                    return animalBytes[0x02];
                }
                set
                {
                    animalBytes[0x02] = value;
                }
            }
            public string Name
            {
                get
                {
                    int length = 0;
                    while (BitConverter.ToInt16(animalBytes, 0x04 + length) != 0)
                        length += 2;
                    return Encoding.Unicode.GetString(animalBytes, 0x04, length);
                }
                set
                {
                    if (value.Length > 6) return;
                    Encoding.Unicode.GetBytes(value, 0, value.Length, animalBytes, 0x04);
                }
            }
            public ushort Friendship
            {
                get
                {
                    return BitConverter.ToUInt16(animalBytes, 0x12);
                }
                set
                {
                    animalBytes[0x12] = (byte)(value & 0xFF);
                    animalBytes[0x13] = (byte)((value >> 8) & 0xFF);
                }
            }
            public ushort Stress
            {
                get
                {
                    return BitConverter.ToUInt16(animalBytes, 0x14);
                }
                set
                {
                    animalBytes[0x14] = (byte)(value & 0xFF);
                    animalBytes[0x15] = (byte)((value >> 8) & 0xFF);
                }
            }
            public ushort SafariTime
            {
                get
                {
                    return BitConverter.ToUInt16(animalBytes, 0x16);
                }
                set
                {
                    animalBytes[0x16] = (byte)(value & 0xFF);
                    animalBytes[0x17] = (byte)((value >> 8) & 0xFF);
                }
            }
            public uint BirthdayYear
            {
                get
                {
                    return BitConverter.ToUInt16(animalBytes, 0x18);
                }
                set
                {
                    animalBytes[0x18] = (byte)(value & 0xFF);
                    animalBytes[0x19] = (byte)((value >> 8) & 0xFF);
                }
            }
            public byte BirthdayMonth
            {
                get
                {
                    return animalBytes[0x1A];
                }
                set
                {
                    animalBytes[0x1A] = value;
                }
            }
            public byte BirthdayDay
            {
                get
                {
                    return animalBytes[0x1B];
                }
                set
                {
                    animalBytes[0x1B] = value;
                }
            }
            public bool IsTouched
            {
                get
                {
                    return (animalBytes[0x1C] & 0x01) == 0x01;
                }
                set
                {
                    if (value) animalBytes[0x1C] |= 0x01; else animalBytes[0x1C] &= 0xFE;
                }
            }
            public bool IsBrushed
            {
                get
                {
                    return (animalBytes[0x1C] & 0x02) == 0x02;
                }
                set
                {
                    if (value) animalBytes[0x1C] |= 0x02; else animalBytes[0x1C] &= 0xFD;
                }
            }
            public bool IsBellHeard
            {
                get
                {
                    return (animalBytes[0x1C] & 0x04) == 0x04;
                }
                set
                {
                    if (value) animalBytes[0x1C] |= 0x04; else animalBytes[0x1C] &= 0xFB;
                }
            }
            public bool IsTreated
            {
                get
                {
                    return (animalBytes[0x1C] & 0x08) == 0x08;
                }
                set
                {
                    if (value) animalBytes[0x1C] |= 0x08; else animalBytes[0x1C] &= 0xF7;
                }
            }
            public bool IsCollected
            {
                get
                {
                    return (animalBytes[0x1C] & 0x20) == 0x20;
                }
                set
                {
                    if (value) animalBytes[0x1C] |= 0x20; else animalBytes[0x1C] &= 0xDF;
                }
            }
            public bool IsEat
            {
                get
                {
                    return (animalBytes[0x1D] & 0x01) == 0x01;
                }
                set
                {
                    if (value) animalBytes[0x1D] |= 0x01; else animalBytes[0x1D] &= 0xFE;
                }
            }
            public bool IsMedicineUsed
            {
                get
                {
                    return (animalBytes[0x1D] & 0x08) == 0x08;
                }
                set
                {
                    if (value) animalBytes[0x1D] |= 0x08; else animalBytes[0x1D] &= 0xF7;
                }
            }
            public bool IsPregnant
            {
                get
                {
                    return (animalBytes[0x20] & 0x01) == 0x01;
                }
                set
                {
                    if (value) animalBytes[0x20] |= 0x01; else animalBytes[0x20] &= 0xFE;
                }
            }
            public byte BarnID
            {
                get
                {
                    return animalBytes[0x44];
                }
                set
                {
                    animalBytes[0x44] = value;
                }
            }
            public byte CoopID
            {
                get
                {
                    return animalBytes[0x45];
                }
                set
                {
                    animalBytes[0x45] = value;
                }
            }
            public Status StateValue
            {
                get
                {
                    return (Status)animalBytes[0x49];
                }
                set
                {
                    animalBytes[0x49] = (byte)(value);
                }
            }
            public Personality PersonalityValue
            {
                get
                {
                    return (Personality)animalBytes[0x4B];
                }
                set
                {
                    animalBytes[0x4B] = (byte)(value);
                }
            }
            public byte ParentID
            {
                get
                {
                    return animalBytes[0x4C];
                }
                set
                {
                    animalBytes[0x4C] = value;
                }
            }
            public byte ByProducts
            {
                get
                {
                    return animalBytes[0x51];
                }
                set
                {
                    animalBytes[0x51] = value;
                }
            }
            public byte NextWool
            {
                get
                {
                    return animalBytes[0x5C];
                }
                set
                {
                    animalBytes[0x5C] = value;
                }
            }
            public byte PregnantDays
            {
                get
                {
                    return animalBytes[0x5E];
                }
                set
                {
                    animalBytes[0x5E] = value;
                }
            }
            public byte Festival
            {
                get
                {
                    return animalBytes[0x60];
                }
                set
                {
                    animalBytes[0x60] = value;
                }
            }
            public ushort RegularTreat
            {
                get
                {
                    return BitConverter.ToUInt16(animalBytes, 0x62);
                }
                set
                {
                    animalBytes[0x62] = (byte)(value & 0xFF);
                    animalBytes[0x63] = (byte)((value >> 8) & 0xFF);
                }
            }
            public float CowTreat
            {
                get
                {
                    return BitConverter.ToSingle(animalBytes, 0x64);
                }
                set
                {
                    Array.Copy(BitConverter.GetBytes(value), 0, animalBytes, 0x64, 4);
                }
            }
            public float ChickenTreat
            {
                get
                {
                    return BitConverter.ToSingle(animalBytes, 0x68);
                }
                set
                {
                    Array.Copy(BitConverter.GetBytes(value), 0, animalBytes, 0x68, 4);
                }
            }
            public float SheepTreat
            {
                get
                {
                    return BitConverter.ToSingle(animalBytes, 0x6C);
                }
                set
                {
                    Array.Copy(BitConverter.GetBytes(value), 0, animalBytes, 0x6C, 4);
                }
            }
            public float RabbitTreat
            {
                get
                {
                    return BitConverter.ToSingle(animalBytes, 0x70);
                }
                set
                {
                    Array.Copy(BitConverter.GetBytes(value), 0, animalBytes, 0x70, 4);
                }
            }

            public Animal(byte[] bytes)
            {
                this.animalBytes = bytes;
            }

            public byte[] ToArray()
            {
                return animalBytes;
            }
        }
        #endregion

        private const int animalOffset = 0x1C508;
        private Animal currentAnimal;
        private int currentSlot;
        private bool canEdit;

        public const int MaxAnimal = 64;
        public bool DataLoaded { get; private set; }
        public static string[] AnimalTypeList;
        public static string[] AnimalPersonalityList;

        public AnimalEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            //*
            Util.LoadAnimalTypeList();
            Util.LoadAnimalPersonalityList();
            Util.LoadMonth();
            DataLoaded = false;

            for (int i = 1; i <= MaxAnimal; i++)
                slotComboBox.Items.Add(i);
            typeComboBox.Items.AddRange(AnimalTypeList);
            monthComboBox.Items.AddRange(GeneralEditingForm.Month);
            for (int i = 1; i <= 31; i++)
                dayComboBox.Items.Add(i);
            personalityComboBox.Items.AddRange(AnimalPersonalityList);

            slotComboBox.SelectedIndex = currentSlot = 0;
            //*/
        }

        // Private method serves for testing purpose
        private void dump()
        {
            string[] lines = new string[64];
            for (int i = 0; i < MaxAnimal; i++)
            {
                int baseOffset = animalOffset + 140 * i;
                lines[i] += "0x" + BitConverter.ToInt16(MainForm.SaveData, baseOffset)
                    .ToString("X4") + " ";
                lines[i] += "0x" + BitConverter.ToInt16(MainForm.SaveData, baseOffset + 0x02)
                    .ToString("X4") + " ";
                int length = 0;
                while (BitConverter.ToInt16(MainForm.SaveData, baseOffset + 0x04 + length) != 0)
                    length += 2;
                lines[i] += Encoding.Unicode.GetString(MainForm.SaveData, baseOffset + 0x04,
                    length) + new String(' ', 7 - length / 2);
                for (int j = 0x12; j < 140; j++)
                {
                    lines[i] += "0x" + MainForm.SaveData[baseOffset + j].ToString("X2") + " ";
                }
            }
            System.IO.File.WriteAllLines("AnimalData.txt", lines);
            MessageBox.Show(System.IO.Directory.GetCurrentDirectory());
            this.Close();
        }

        private void displayAnimal(int slot)
        {
            DataLoaded = false;

            byte[] animalBytes = new byte[140];
            Array.Copy(MainForm.SaveData, animalOffset + 140 * slot,
                animalBytes, 0, 140);
            currentAnimal = new Animal(animalBytes);

            short animalType = currentAnimal.Type;
            typeComboBox.SelectedIndex = animalType;
            nameTextBox.Text = currentAnimal.Name;
            friendshipNumericUpDown.Value = currentAnimal.Friendship;
            stressNumericUpDown.Value = currentAnimal.Stress;
            safariNumericUpDown.Value = currentAnimal.SafariTime;
            yearNumericUpDown.Value = currentAnimal.BirthdayYear + 1;
            monthComboBox.SelectedIndex = currentAnimal.BirthdayMonth;
            dayComboBox.SelectedIndex = currentAnimal.BirthdayDay;
            touchCheckBox.Checked = currentAnimal.IsTouched;
            brushCheckBox.Checked = currentAnimal.IsBrushed;
            bellCheckBox.Checked = currentAnimal.IsBellHeard;
            treatCheckBox.Checked = currentAnimal.IsTreated;
            collectCheckBox.Checked = currentAnimal.IsCollected;
            eatCheckBox.Checked = currentAnimal.IsEat;
            pregnantCheckBox.Checked = currentAnimal.IsPregnant;
            personalityComboBox.SelectedIndex = (int)currentAnimal.PersonalityValue;
            productNumericUpDown.Value = currentAnimal.ByProducts;
            pregnantNumericUpDown.Value = currentAnimal.PregnantDays;
            woolNumericUpDown.Value = currentAnimal.NextWool;
            festivalNumericUpDown.Value = currentAnimal.Festival;
            regularTreatNumericUpDown.Value = currentAnimal.RegularTreat;
            cowTreatNumericUpDown.Value = (decimal)currentAnimal.CowTreat;
            chickenTreatNumericUpDown.Value = (decimal)currentAnimal.ChickenTreat;
            sheepTreatNumericUpDown.Value = (decimal)currentAnimal.SheepTreat;
            rabbitTreatNumericUpDown.Value = (decimal)currentAnimal.RabbitTreat;

            

            if (animalType == -1)
            {
                nameTextBox.Enabled = false;
                typeComboBox.Enabled = false;
                personalityComboBox.Enabled = false;
                friendshipNumericUpDown.Enabled = false;
                stressNumericUpDown.Enabled = false;
                safariNumericUpDown.Enabled = false;
                productNumericUpDown.Enabled = false;
                woolNumericUpDown.Enabled = false;
                festivalNumericUpDown.Enabled = false;
                dayComboBox.Enabled = false;
                monthComboBox.Enabled = false;
                yearNumericUpDown.Enabled = false;
                regularTreatNumericUpDown.Enabled = false;
                cowTreatNumericUpDown.Enabled = false;
                chickenTreatNumericUpDown.Enabled = false;
                sheepTreatNumericUpDown.Enabled = false;
                rabbitTreatNumericUpDown.Enabled = false;
                pregnantNumericUpDown.Enabled = false;
                eatCheckBox.Enabled = false;
                touchCheckBox.Enabled = false;
                brushCheckBox.Enabled = false;
                collectCheckBox.Enabled = false;
                treatCheckBox.Enabled = false;
                bellCheckBox.Enabled = false;
                pregnantCheckBox.Enabled = false;
                canEdit = false;
            }
            else
            {
                nameTextBox.Enabled = true;
                typeComboBox.Enabled = true;
                personalityComboBox.Enabled = true;
                friendshipNumericUpDown.Enabled = true;
                stressNumericUpDown.Enabled = true;
                safariNumericUpDown.Enabled = true;
                productNumericUpDown.Enabled = true;
                woolNumericUpDown.Enabled = true;
                festivalNumericUpDown.Enabled = true;
                dayComboBox.Enabled = true;
                monthComboBox.Enabled = true;
                yearNumericUpDown.Enabled = true;
                regularTreatNumericUpDown.Enabled = true;
                cowTreatNumericUpDown.Enabled = true;
                chickenTreatNumericUpDown.Enabled = true;
                sheepTreatNumericUpDown.Enabled = true;
                rabbitTreatNumericUpDown.Enabled = true;
                pregnantNumericUpDown.Enabled = currentAnimal.IsPregnant;
                eatCheckBox.Enabled = true;
                touchCheckBox.Enabled = true;
                brushCheckBox.Enabled = true;
                collectCheckBox.Enabled = true;
                treatCheckBox.Enabled = true;
                bellCheckBox.Enabled = true;
                pregnantCheckBox.Enabled = true;
                canEdit = true;
            }
            DataLoaded = true;
        }

        private void saveCurrentAnimal()
        {
            if (!canEdit) return;

            currentAnimal.Type = (short)typeComboBox.SelectedIndex;
            currentAnimal.Name = nameTextBox.Text;
            currentAnimal.Friendship = (ushort)friendshipNumericUpDown.Value;
            currentAnimal.Stress = (ushort)stressNumericUpDown.Value;
            currentAnimal.SafariTime = (ushort)safariNumericUpDown.Value;
            currentAnimal.BirthdayYear = (ushort)(yearNumericUpDown.Value - 1);
            currentAnimal.BirthdayMonth = (byte)monthComboBox.SelectedIndex;
            currentAnimal.BirthdayDay = (byte)dayComboBox.SelectedIndex;
            currentAnimal.IsTouched = touchCheckBox.Checked;
            currentAnimal.IsBrushed = brushCheckBox.Checked;
            currentAnimal.IsBellHeard = bellCheckBox.Checked;
            currentAnimal.IsTreated = treatCheckBox.Checked;
            currentAnimal.IsCollected = collectCheckBox.Checked;
            currentAnimal.IsEat = eatCheckBox.Checked;
            currentAnimal.IsPregnant = pregnantCheckBox.Checked;
            currentAnimal.PersonalityValue = (Animal.Personality)personalityComboBox.SelectedIndex;
            currentAnimal.ByProducts = (byte)productNumericUpDown.Value;
            currentAnimal.NextWool = (byte)woolNumericUpDown.Value;
            currentAnimal.PregnantDays = (byte)pregnantNumericUpDown.Value;
            currentAnimal.Festival = (byte)festivalNumericUpDown.Value;
            currentAnimal.RegularTreat = (ushort)regularTreatNumericUpDown.Value;
            currentAnimal.CowTreat = (float)cowTreatNumericUpDown.Value;
            currentAnimal.ChickenTreat = (float)chickenTreatNumericUpDown.Value;
            currentAnimal.SheepTreat = (float)sheepTreatNumericUpDown.Value;
            currentAnimal.RabbitTreat = (float)rabbitTreatNumericUpDown.Value;
            Array.Copy(currentAnimal.ToArray(), 0, MainForm.SaveData,
                animalOffset + 140 * currentSlot, 140);
        }

        private void slotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataLoaded)
            {
                displayAnimal(slotComboBox.SelectedIndex);
                return;
            }
            saveCurrentAnimal();
            currentSlot = slotComboBox.SelectedIndex;
            displayAnimal(currentSlot);
        }

        private void pregnantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pregnantNumericUpDown.Enabled = pregnantCheckBox.Checked;
        }

        private void AnimalEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveCurrentAnimal();
        }
    }
}
