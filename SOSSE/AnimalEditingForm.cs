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
        // It's possible to create an abstract class here.
        #region public class Animal
        public class Animal
        {
            private byte[] animalBytes;

            public enum PersonalityValue { Levelheaded, Active, Cowardly };
            public enum StateValue { Healthy, Angry, Sick };

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
            public ushort BirthdayYear
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
            public bool IsAte
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
            public StateValue State
            {
                get
                {
                    return (StateValue)animalBytes[0x49];
                }
                set
                {
                    animalBytes[0x49] = (byte)(value);
                }
            }
            public PersonalityValue Personality
            {
                get
                {
                    return (PersonalityValue)animalBytes[0x4B];
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
            public byte DirtyCount
            {
                get
                {
                    return animalBytes[0x50];
                }
                set
                {
                    animalBytes[0x50] = value;
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
        #region public class WildAnimal
        public class WildAnimal
        {
            private byte[] animalBytes;
            // Type of wild animal data is fixed anyway.
            public short Type
            {
                get
                {
                    return BitConverter.ToInt16(animalBytes, 0x0);
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

            public WildAnimal(byte[] bytes)
            {
                this.animalBytes = bytes;
            }

            public byte[] ToArray()
            {
                return animalBytes;
            }
        }
        #endregion
        #region public class Pet
        public class Pet
        {
            private byte[] animalBytes;

            public enum PetTask { Livestock, Chicken };

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
            /// <summary>
            /// Pet name. 6 character and a terminator in UTF-16 format.
            /// </summary>
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
            public ushort Training
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
            public ushort BirthdayYear
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
            public bool IsAte
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
            // Dog Bone / Cat Bell
            public bool IsToyThrown
            {
                get
                {
                    return (animalBytes[0x1D] & 0x10) == 0x10;
                }
                set
                {
                    if (value) animalBytes[0x1D] |= 0x10; else animalBytes[0x1D] &= 0xEF;
                }
            }
            public bool IsAssigned
            {
                get
                {
                    return (animalBytes[0x22] & 0x01) == 0x01;
                }
                set
                {
                    if (value) animalBytes[0x22] |= 0x01; else animalBytes[0x22] &= 0xFE;
                }
            }
            public PetTask Task
            {
                get
                {
                    return (PetTask)animalBytes[0x49];
                }
                set
                {
                    animalBytes[0x49] = (byte)value;
                }
            }
            public Item[] CollectedItem
            {
                get
                {
                    Item[] item = new Item[4];
                    for (int i = 0; i < 4; i++)
                    {
                        byte[] itemBytes = new byte[12];
                        Array.Copy(animalBytes, 0x5C + 12 * i, itemBytes, 0, 12);
                        item[i] = new Item(itemBytes);
                    }
                    return item;
                }
                set
                {
                    Array.Copy(value[0].ToArray(), 0, animalBytes, 0x5C, 12);
                    Array.Copy(value[1].ToArray(), 0, animalBytes, 0x68, 12);
                    Array.Copy(value[2].ToArray(), 0, animalBytes, 0x74, 12);
                    Array.Copy(value[3].ToArray(), 0, animalBytes, 0x80, 12);
                }
            }

            public Pet(byte[] bytes)
            {
                this.animalBytes = bytes;
            }

            public byte[] ToArray()
            {
                return animalBytes;
            }
        }
        #endregion
        #region public class Horse
        public class Horse
        {
            private byte[] animalBytes;

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
            /// <summary>
            /// Horse name. 6 character and a terminator in UTF-16 format.
            /// </summary>
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

            public Horse(byte[] bytes)
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
        private const int wildOffset = 0x1E818;
        private const int petOffset = 0x1EFB0;
        private const int horseOffset = 0x1F2F8;
        private Animal currentAnimal;
        private int currentAnimalSlot;
        private bool canEditAnimal;
        private WildAnimal currentWildAnimal;
        private int currentWildSlot;
        private bool canEditWild;
        private Pet currentPet;
        private int currentPetSlot;
        private bool canEditPet;
        private Horse horse;

        public const int MaxAnimal = 64;
        public const int MaxPet = 6;
        public bool DataLoaded { get; private set; }
        public static string[] AnimalTypeList;
        public static string[] AnimalPersonalityList;

        public AnimalEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            Util.LoadAnimalTypeList();
            Util.LoadAnimalPersonalityList();
            Util.LoadItemNameList();
            Util.LoadMonth();

            for (int i = 1; i <= 31; i++)
            {
                animalDayComboBox.Items.Add(i);
                petDayComboBox.Items.Add(i);
            }
            DataLoaded = false;
            for (int i = 1; i <= MaxAnimal; i++)
                animalSlotComboBox.Items.Add(i);
            animalTypeComboBox.Items.AddRange(AnimalTypeList);
            animalMonthComboBox.Items.AddRange(GeneralEditingForm.Month);
            personalityComboBox.Items.AddRange(AnimalPersonalityList);
            stateComboBox.Items.AddRange(new [] { "Healthy", "Angry", "Sick" });
            animalSlotComboBox.SelectedIndex = 0;

            DataLoaded = false;
            for (int i = 0x60; i <= 0x7A; i++)
                wildTypeComboBox.Items.Add(AnimalTypeList[i]);
            wildTypeComboBox.SelectedIndex = 0;
            // Implicitly call wildTypeComboBox_SelectedIndexChanged

            DataLoaded = false;
            for (int i = 1; i <= MaxPet; i++)
                petSlotComboBox.Items.Add(i);
            petTypeComboBox.Items.AddRange(AnimalTypeList);
            petMonthComboBox.Items.AddRange(GeneralEditingForm.Month);
            string[] itemSortedList = new string[Item.MaxItem + 1];
            itemSortedList[0] = "None";
            for (int i = 0; i < Item.MaxItem; i++)
            {
                itemSortedList[i + 1] = Item.ItemNameList[ItemEditingForm.ItemSortedList[i]];
            }
            item1ComboBox.Items.AddRange(itemSortedList);
            item2ComboBox.Items.AddRange(itemSortedList);
            item3ComboBox.Items.AddRange(itemSortedList);
            item4ComboBox.Items.AddRange(itemSortedList);
            petSlotComboBox.SelectedIndex = 0;

            horseTypeComboBox.Items.AddRange(AnimalTypeList);
            displayHorse();
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

        private void displayAnimal()
        {
            DataLoaded = false;

            byte[] animalBytes = new byte[140];
            int slot = animalSlotComboBox.SelectedIndex;
            Array.Copy(MainForm.SaveData, animalOffset + 140 * slot,
                animalBytes, 0, 140);
            currentAnimal = new Animal(animalBytes);

            short animalType = currentAnimal.Type;
            animalTypeComboBox.SelectedIndex = animalType;
            nameTextBox.Text = currentAnimal.Name;
            animalFriendshipNumericUpDown.Value = currentAnimal.Friendship;
            animalStressNumericUpDown.Value = currentAnimal.Stress;
            safariNumericUpDown.Value = currentAnimal.SafariTime;
            animalYearNumericUpDown.Value = currentAnimal.BirthdayYear + 1;
            animalMonthComboBox.SelectedIndex = currentAnimal.BirthdayMonth;
            animalDayComboBox.SelectedIndex = currentAnimal.BirthdayDay;
            touchCheckBox.Checked = currentAnimal.IsTouched;
            brushCheckBox.Checked = currentAnimal.IsBrushed;
            bellCheckBox.Checked = currentAnimal.IsBellHeard;
            treatCheckBox.Checked = currentAnimal.IsTreated;
            collectCheckBox.Checked = currentAnimal.IsCollected;
            eatCheckBox.Checked = currentAnimal.IsAte;
            pregnantCheckBox.Checked = currentAnimal.IsPregnant;
            personalityComboBox.SelectedIndex = (int)currentAnimal.Personality;
            stateComboBox.SelectedIndex = (int)currentAnimal.State;
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
                animalTypeComboBox.Enabled = false;
                personalityComboBox.Enabled = false;
                animalFriendshipNumericUpDown.Enabled = false;
                animalStressNumericUpDown.Enabled = false;
                safariNumericUpDown.Enabled = false;
                stateComboBox.Enabled = false;
                productNumericUpDown.Enabled = false;
                woolNumericUpDown.Enabled = false;
                festivalNumericUpDown.Enabled = false;
                animalDayComboBox.Enabled = false;
                animalMonthComboBox.Enabled = false;
                animalYearNumericUpDown.Enabled = false;
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
                canEditAnimal = false;
            }
            else
            {
                nameTextBox.Enabled = true;
                animalTypeComboBox.Enabled = true;
                personalityComboBox.Enabled = true;
                animalFriendshipNumericUpDown.Enabled = true;
                animalStressNumericUpDown.Enabled = true;
                safariNumericUpDown.Enabled = true;
                stateComboBox.Enabled = true;
                productNumericUpDown.Enabled = true;
                woolNumericUpDown.Enabled = true;
                festivalNumericUpDown.Enabled = true;
                animalDayComboBox.Enabled = true;
                animalMonthComboBox.Enabled = true;
                animalYearNumericUpDown.Enabled = true;
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
                canEditAnimal = true;
            }
            DataLoaded = true;
        }

        private void saveCurrentAnimal()
        {
            if (!canEditAnimal) return;

            currentAnimal.Type = (short)animalTypeComboBox.SelectedIndex;
            currentAnimal.Name = nameTextBox.Text;
            currentAnimal.Friendship = (ushort)animalFriendshipNumericUpDown.Value;
            currentAnimal.Stress = (ushort)animalStressNumericUpDown.Value;
            currentAnimal.SafariTime = (ushort)safariNumericUpDown.Value;
            currentAnimal.BirthdayYear = (ushort)(animalYearNumericUpDown.Value - 1);
            currentAnimal.BirthdayMonth = (byte)animalMonthComboBox.SelectedIndex;
            currentAnimal.BirthdayDay = (byte)animalDayComboBox.SelectedIndex;
            currentAnimal.IsTouched = touchCheckBox.Checked;
            currentAnimal.IsBrushed = brushCheckBox.Checked;
            currentAnimal.IsBellHeard = bellCheckBox.Checked;
            currentAnimal.IsTreated = treatCheckBox.Checked;
            currentAnimal.IsCollected = collectCheckBox.Checked;
            currentAnimal.IsAte = eatCheckBox.Checked;
            currentAnimal.IsPregnant = pregnantCheckBox.Checked;
            currentAnimal.Personality = (Animal.PersonalityValue)personalityComboBox.SelectedIndex;
            currentAnimal.State = (Animal.StateValue)stateComboBox.SelectedIndex;
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
                animalOffset + 140 * currentAnimalSlot, 140);
        }

        private void slotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataLoaded) saveCurrentAnimal();
            saveCurrentAnimal();
            currentAnimalSlot = animalSlotComboBox.SelectedIndex;
            displayAnimal();
        }

        private void pregnantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pregnantNumericUpDown.Enabled = pregnantCheckBox.Checked;
        }

        private void displayWildAnimal()
        {
            DataLoaded = false;
            byte[] wildBytes = new byte[72];
            Array.Copy(MainForm.SaveData, wildOffset + 72 * wildTypeComboBox.SelectedIndex,
                wildBytes, 0, 72);
            currentWildAnimal = new WildAnimal(wildBytes);

            wildFriendshipNumericUpDown.Value = currentWildAnimal.Friendship;

            // Editing unappeared wild animal is disabled for now.
            if (currentWildAnimal.ID == 0xFF)
            {
                wildFriendshipNumericUpDown.Enabled = false;
                canEditWild = false;
            }
            else
            {
                wildFriendshipNumericUpDown.Enabled = true;
                canEditWild = true;
            }

            DataLoaded = true;
        }

        private void saveCurrentWildAnimal()
        {
            if (!canEditWild) return;

            currentWildAnimal.Friendship = (ushort)wildFriendshipNumericUpDown.Value;

            Array.Copy(currentWildAnimal.ToArray(), 0, MainForm.SaveData,
                wildOffset + 72 * currentWildSlot, 72);
        }

        private void wildTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataLoaded) saveCurrentWildAnimal();
            currentWildSlot = wildTypeComboBox.SelectedIndex;
            displayWildAnimal();
        }

        private void displayPet()
        {
            DataLoaded = false;

            int slot = petSlotComboBox.SelectedIndex;
            byte[] petBytes = new byte[140];
            Array.Copy(MainForm.SaveData, petOffset + 140 * slot, petBytes, 0, 140);
            currentPet = new Pet(petBytes);

            petTypeComboBox.SelectedIndex = currentPet.Type;// -0x40;
            petNameTextBox.Text = currentPet.Name;
            petFriendshipNumericUpDown.Value = currentPet.Friendship;
            petStressNumericUpDown.Value = currentPet.Stress;
            trainingNumericUpDown.Value = currentPet.Training;
            petYearNumericUpDown.Value = currentPet.BirthdayYear + 1;
            petMonthComboBox.SelectedIndex = currentPet.BirthdayMonth;
            petDayComboBox.SelectedIndex = currentPet.BirthdayDay;
            petEatCheckBox.Checked = currentPet.IsAte;
            petTouchCheckBox.Checked = currentPet.IsTouched;
            toyCheckBox.Checked = currentPet.IsToyThrown;
            item1ComboBox.Text = currentPet.CollectedItem[0].GetItemName();
            item1NumericUpDown.Value = currentPet.CollectedItem[0].Quantity;
            item2ComboBox.Text = currentPet.CollectedItem[1].GetItemName();
            item2NumericUpDown.Value = currentPet.CollectedItem[1].Quantity;
            item3ComboBox.Text = currentPet.CollectedItem[2].GetItemName();
            item3NumericUpDown.Value = currentPet.CollectedItem[2].Quantity;
            item4ComboBox.Text = currentPet.CollectedItem[3].GetItemName();
            item4NumericUpDown.Value = currentPet.CollectedItem[3].Quantity;

            // Disable empty slot editing
            if (currentPet.Type == -1)
            {
                petTypeComboBox.Enabled = false;
                petNameTextBox.Enabled = false;
                petFriendshipNumericUpDown.Enabled = false;
                petStressNumericUpDown.Enabled = false;
                trainingNumericUpDown.Enabled = false;
                petDayComboBox.Enabled = false;
                petMonthComboBox.Enabled = false;
                petYearNumericUpDown.Enabled = false;
                item1ComboBox.Enabled = false;
                item1NumericUpDown.Enabled = false;
                item2ComboBox.Enabled = false;
                item2NumericUpDown.Enabled = false;
                item3ComboBox.Enabled = false;
                item3NumericUpDown.Enabled = false;
                item4ComboBox.Enabled = false;
                item4NumericUpDown.Enabled = false;
                petTouchCheckBox.Enabled = false;
                petEatCheckBox.Enabled = false;
                toyCheckBox.Enabled = false;
                canEditPet = false;
            }
            else
            {
                petTypeComboBox.Enabled = true;
                petNameTextBox.Enabled = true;
                petFriendshipNumericUpDown.Enabled = true;
                petStressNumericUpDown.Enabled = true;
                trainingNumericUpDown.Enabled = true;
                petDayComboBox.Enabled = true;
                petMonthComboBox.Enabled = true;
                petYearNumericUpDown.Enabled = true;
                item1ComboBox.Enabled = true;
                item1NumericUpDown.Enabled = true;
                item2ComboBox.Enabled = true;
                item2NumericUpDown.Enabled = true;
                item3ComboBox.Enabled = true;
                item3NumericUpDown.Enabled = true;
                item4ComboBox.Enabled = true;
                item4NumericUpDown.Enabled = true;
                petTouchCheckBox.Enabled = true;
                petEatCheckBox.Enabled = true;
                toyCheckBox.Enabled = true;
                canEditPet = true;
            }

            DataLoaded = true;
        }

        private void saveCurrentPet()
        {
            if (!canEditPet) return;

            currentPet.Type = (short)(petTypeComboBox.SelectedIndex);// + 0x40);
            currentPet.Name = petNameTextBox.Text;
            currentPet.Friendship = (ushort)petFriendshipNumericUpDown.Value;
            currentPet.Stress = (ushort)petStressNumericUpDown.Value;
            currentPet.Training = (ushort)trainingNumericUpDown.Value;
            currentPet.BirthdayYear = (ushort)(petYearNumericUpDown.Value - 1);
            currentPet.BirthdayMonth = (byte)petMonthComboBox.SelectedIndex;
            currentPet.BirthdayDay = (byte)petDayComboBox.SelectedIndex;
            currentPet.IsAte = petEatCheckBox.Checked;
            currentPet.IsTouched = petTouchCheckBox.Checked;
            currentPet.IsToyThrown = toyCheckBox.Checked;
            // Save collected items
            Item[] items = currentPet.CollectedItem;
            if (item1ComboBox.SelectedIndex == 0)
                items[0].Index = 0xFFFF;
            else
                items[0].Index = ItemEditingForm.ItemSortedList[item1ComboBox.SelectedIndex - 1];
            items[0].Quantity = (byte)(item1NumericUpDown.Value);
            if (item2ComboBox.SelectedIndex == 0)
                items[1].Index = 0xFFFF;
            else
                items[1].Index = ItemEditingForm.ItemSortedList[item2ComboBox.SelectedIndex - 1];
            items[1].Quantity = (byte)(item2NumericUpDown.Value);
            if (item3ComboBox.SelectedIndex == 0)
                items[2].Index = 0xFFFF;
            else
                items[2].Index = ItemEditingForm.ItemSortedList[item3ComboBox.SelectedIndex - 1];
            items[2].Quantity = (byte)(item3NumericUpDown.Value);
            if (item4ComboBox.SelectedIndex == 0)
                items[3].Index = 0xFFFF;
            else
                items[3].Index = ItemEditingForm.ItemSortedList[item4ComboBox.SelectedIndex - 1];
            items[3].Quantity = (byte)(item4NumericUpDown.Value);
            currentPet.CollectedItem = items;

            Array.Copy(currentPet.ToArray(), 0, MainForm.SaveData,
                petOffset + 140 * currentPetSlot, 140); 
        }

        private void petSlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataLoaded) saveCurrentPet();
            currentPetSlot = petSlotComboBox.SelectedIndex;
            displayPet();
        }

        private void displayHorse()
        {
            DataLoaded = false;

            byte[] horseBytes = new byte[68];
            Array.Copy(MainForm.SaveData, horseOffset, horseBytes, 0, 68);
            horse = new Horse(horseBytes);

            horseTypeComboBox.SelectedIndex = horse.Type;// - 0x7B;
            horseNameTextBox.Text = horse.Name;
            horseFriendshipNumericUpDown.Value = horse.Friendship;
            if (horse.Type == -1)
            {
                horseTypeComboBox.Enabled = false;
                horseNameTextBox.Enabled = false;
                horseFriendshipNumericUpDown.Enabled = false;
            }
            else
            {
                horseTypeComboBox.Enabled = true;
                horseNameTextBox.Enabled = true;
                horseFriendshipNumericUpDown.Enabled = true;
            }

            DataLoaded = true;
        }

        private void saveHorse()
        {
            horse.Type = (short)(horseTypeComboBox.SelectedIndex);// + 0x7B);
            horse.Name = horseNameTextBox.Text;
            horse.Friendship = (ushort)(horseFriendshipNumericUpDown.Value);
            Array.Copy(horse.ToArray(), 0, MainForm.SaveData, horseOffset, 68);
        }

        private void AnimalEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveCurrentAnimal();
            saveCurrentWildAnimal();
            saveCurrentPet();
            saveHorse();
        }
    }
}
