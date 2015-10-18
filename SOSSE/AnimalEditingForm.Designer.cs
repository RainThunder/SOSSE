namespace SOSSE
{
    partial class AnimalEditingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.slotComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.slotLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.friendshipLabel = new System.Windows.Forms.Label();
            this.stressLabel = new System.Windows.Forms.Label();
            this.friendshipNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stressNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.birthdayGroupBox = new System.Windows.Forms.GroupBox();
            this.safariNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.safariLabel = new System.Windows.Forms.Label();
            this.personalityComboBox = new System.Windows.Forms.ComboBox();
            this.personalityLabel = new System.Windows.Forms.Label();
            this.productNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.woolNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productLabel = new System.Windows.Forms.Label();
            this.woolLabel = new System.Windows.Forms.Label();
            this.flagGroupBox = new System.Windows.Forms.GroupBox();
            this.bellCheckBox = new System.Windows.Forms.CheckBox();
            this.treatCheckBox = new System.Windows.Forms.CheckBox();
            this.brushCheckBox = new System.Windows.Forms.CheckBox();
            this.collectCheckBox = new System.Windows.Forms.CheckBox();
            this.touchCheckBox = new System.Windows.Forms.CheckBox();
            this.eatCheckBox = new System.Windows.Forms.CheckBox();
            this.festivalLabel = new System.Windows.Forms.Label();
            this.festivalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.treatGroupBox = new System.Windows.Forms.GroupBox();
            this.normalTreatLabel = new System.Windows.Forms.Label();
            this.regularTreatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rabbitTreatLabel = new System.Windows.Forms.Label();
            this.sheepTreatLabel = new System.Windows.Forms.Label();
            this.chickenTreatLabel = new System.Windows.Forms.Label();
            this.cowTreatLabel = new System.Windows.Forms.Label();
            this.rabbitTreatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sheepTreatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chickenTreatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cowTreatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pregnantNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pregnantCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendshipNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stressNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.birthdayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safariNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woolNumericUpDown)).BeginInit();
            this.flagGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.festivalNumericUpDown)).BeginInit();
            this.treatGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regularTreatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitTreatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheepTreatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenTreatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowTreatNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregnantNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // slotComboBox
            // 
            this.slotComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slotComboBox.FormattingEnabled = true;
            this.slotComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64"});
            this.slotComboBox.Location = new System.Drawing.Point(56, 12);
            this.slotComboBox.Name = "slotComboBox";
            this.slotComboBox.Size = new System.Drawing.Size(42, 21);
            this.slotComboBox.TabIndex = 0;
            this.slotComboBox.SelectedIndexChanged += new System.EventHandler(this.slotComboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(185, 12);
            this.nameTextBox.MaxLength = 6;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(107, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(92, 39);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(200, 21);
            this.typeComboBox.TabIndex = 2;
            // 
            // slotLabel
            // 
            this.slotLabel.AutoSize = true;
            this.slotLabel.Location = new System.Drawing.Point(12, 15);
            this.slotLabel.Name = "slotLabel";
            this.slotLabel.Size = new System.Drawing.Size(25, 13);
            this.slotLabel.TabIndex = 5;
            this.slotLabel.Text = "Slot";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 42);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(65, 13);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Animal Type";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(133, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // friendshipLabel
            // 
            this.friendshipLabel.AutoSize = true;
            this.friendshipLabel.Location = new System.Drawing.Point(12, 95);
            this.friendshipLabel.Name = "friendshipLabel";
            this.friendshipLabel.Size = new System.Drawing.Size(55, 13);
            this.friendshipLabel.TabIndex = 8;
            this.friendshipLabel.Text = "Friendship";
            // 
            // stressLabel
            // 
            this.stressLabel.AutoSize = true;
            this.stressLabel.Location = new System.Drawing.Point(190, 95);
            this.stressLabel.Name = "stressLabel";
            this.stressLabel.Size = new System.Drawing.Size(36, 13);
            this.stressLabel.TabIndex = 9;
            this.stressLabel.Text = "Stress";
            // 
            // friendshipNumericUpDown
            // 
            this.friendshipNumericUpDown.Location = new System.Drawing.Point(92, 93);
            this.friendshipNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.friendshipNumericUpDown.Name = "friendshipNumericUpDown";
            this.friendshipNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.friendshipNumericUpDown.TabIndex = 10;
            // 
            // stressNumericUpDown
            // 
            this.stressNumericUpDown.Location = new System.Drawing.Point(244, 93);
            this.stressNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.stressNumericUpDown.Name = "stressNumericUpDown";
            this.stressNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.stressNumericUpDown.TabIndex = 11;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(234, 19);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.yearNumericUpDown.TabIndex = 14;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(111, 21);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(26, 13);
            this.dayLabel.TabIndex = 15;
            this.dayLabel.Text = "Day";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(6, 21);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(37, 13);
            this.monthLabel.TabIndex = 16;
            this.monthLabel.Text = "Month";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(195, 21);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 17;
            this.yearLabel.Text = "Year";
            // 
            // dayComboBox
            // 
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(144, 18);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(45, 21);
            this.dayComboBox.TabIndex = 18;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(49, 18);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(49, 21);
            this.monthComboBox.TabIndex = 19;
            // 
            // birthdayGroupBox
            // 
            this.birthdayGroupBox.Controls.Add(this.dayLabel);
            this.birthdayGroupBox.Controls.Add(this.yearLabel);
            this.birthdayGroupBox.Controls.Add(this.monthComboBox);
            this.birthdayGroupBox.Controls.Add(this.yearNumericUpDown);
            this.birthdayGroupBox.Controls.Add(this.dayComboBox);
            this.birthdayGroupBox.Controls.Add(this.monthLabel);
            this.birthdayGroupBox.Location = new System.Drawing.Point(12, 197);
            this.birthdayGroupBox.Name = "birthdayGroupBox";
            this.birthdayGroupBox.Size = new System.Drawing.Size(280, 47);
            this.birthdayGroupBox.TabIndex = 20;
            this.birthdayGroupBox.TabStop = false;
            this.birthdayGroupBox.Text = "Birthday";
            // 
            // safariNumericUpDown
            // 
            this.safariNumericUpDown.Location = new System.Drawing.Point(244, 119);
            this.safariNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.safariNumericUpDown.Name = "safariNumericUpDown";
            this.safariNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.safariNumericUpDown.TabIndex = 22;
            // 
            // safariLabel
            // 
            this.safariLabel.AutoSize = true;
            this.safariLabel.Location = new System.Drawing.Point(190, 121);
            this.safariLabel.Name = "safariLabel";
            this.safariLabel.Size = new System.Drawing.Size(34, 13);
            this.safariLabel.TabIndex = 23;
            this.safariLabel.Text = "Safari";
            // 
            // personalityComboBox
            // 
            this.personalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personalityComboBox.FormattingEnabled = true;
            this.personalityComboBox.Location = new System.Drawing.Point(92, 66);
            this.personalityComboBox.Name = "personalityComboBox";
            this.personalityComboBox.Size = new System.Drawing.Size(103, 21);
            this.personalityComboBox.TabIndex = 25;
            // 
            // personalityLabel
            // 
            this.personalityLabel.AutoSize = true;
            this.personalityLabel.Location = new System.Drawing.Point(12, 69);
            this.personalityLabel.Name = "personalityLabel";
            this.personalityLabel.Size = new System.Drawing.Size(58, 13);
            this.personalityLabel.TabIndex = 26;
            this.personalityLabel.Text = "Personality";
            // 
            // productNumericUpDown
            // 
            this.productNumericUpDown.Location = new System.Drawing.Point(92, 119);
            this.productNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.productNumericUpDown.Name = "productNumericUpDown";
            this.productNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.productNumericUpDown.TabIndex = 27;
            // 
            // woolNumericUpDown
            // 
            this.woolNumericUpDown.Location = new System.Drawing.Point(92, 145);
            this.woolNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.woolNumericUpDown.Name = "woolNumericUpDown";
            this.woolNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.woolNumericUpDown.TabIndex = 28;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(12, 121);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(64, 13);
            this.productLabel.TabIndex = 29;
            this.productLabel.Text = "By-Products";
            // 
            // woolLabel
            // 
            this.woolLabel.AutoSize = true;
            this.woolLabel.Location = new System.Drawing.Point(12, 147);
            this.woolLabel.Name = "woolLabel";
            this.woolLabel.Size = new System.Drawing.Size(54, 13);
            this.woolLabel.TabIndex = 30;
            this.woolLabel.Text = "Next wool";
            // 
            // flagGroupBox
            // 
            this.flagGroupBox.Controls.Add(this.bellCheckBox);
            this.flagGroupBox.Controls.Add(this.treatCheckBox);
            this.flagGroupBox.Controls.Add(this.brushCheckBox);
            this.flagGroupBox.Controls.Add(this.collectCheckBox);
            this.flagGroupBox.Controls.Add(this.touchCheckBox);
            this.flagGroupBox.Controls.Add(this.eatCheckBox);
            this.flagGroupBox.Location = new System.Drawing.Point(12, 355);
            this.flagGroupBox.Name = "flagGroupBox";
            this.flagGroupBox.Size = new System.Drawing.Size(280, 70);
            this.flagGroupBox.TabIndex = 31;
            this.flagGroupBox.TabStop = false;
            this.flagGroupBox.Text = "Flags";
            // 
            // bellCheckBox
            // 
            this.bellCheckBox.AutoSize = true;
            this.bellCheckBox.Location = new System.Drawing.Point(144, 43);
            this.bellCheckBox.Name = "bellCheckBox";
            this.bellCheckBox.Size = new System.Drawing.Size(43, 17);
            this.bellCheckBox.TabIndex = 5;
            this.bellCheckBox.Text = "Bell";
            this.bellCheckBox.UseVisualStyleBackColor = true;
            // 
            // treatCheckBox
            // 
            this.treatCheckBox.AutoSize = true;
            this.treatCheckBox.Location = new System.Drawing.Point(223, 20);
            this.treatCheckBox.Name = "treatCheckBox";
            this.treatCheckBox.Size = new System.Drawing.Size(51, 17);
            this.treatCheckBox.TabIndex = 4;
            this.treatCheckBox.Text = "Treat";
            this.treatCheckBox.UseVisualStyleBackColor = true;
            // 
            // brushCheckBox
            // 
            this.brushCheckBox.AutoSize = true;
            this.brushCheckBox.Location = new System.Drawing.Point(144, 20);
            this.brushCheckBox.Name = "brushCheckBox";
            this.brushCheckBox.Size = new System.Drawing.Size(53, 17);
            this.brushCheckBox.TabIndex = 3;
            this.brushCheckBox.Text = "Brush";
            this.brushCheckBox.UseVisualStyleBackColor = true;
            // 
            // collectCheckBox
            // 
            this.collectCheckBox.AutoSize = true;
            this.collectCheckBox.Location = new System.Drawing.Point(6, 43);
            this.collectCheckBox.Name = "collectCheckBox";
            this.collectCheckBox.Size = new System.Drawing.Size(110, 17);
            this.collectCheckBox.TabIndex = 2;
            this.collectCheckBox.Text = "Product Collected";
            this.collectCheckBox.UseVisualStyleBackColor = true;
            // 
            // touchCheckBox
            // 
            this.touchCheckBox.AutoSize = true;
            this.touchCheckBox.Location = new System.Drawing.Point(65, 20);
            this.touchCheckBox.Name = "touchCheckBox";
            this.touchCheckBox.Size = new System.Drawing.Size(57, 17);
            this.touchCheckBox.TabIndex = 1;
            this.touchCheckBox.Text = "Touch";
            this.touchCheckBox.UseVisualStyleBackColor = true;
            // 
            // eatCheckBox
            // 
            this.eatCheckBox.AutoSize = true;
            this.eatCheckBox.Location = new System.Drawing.Point(6, 20);
            this.eatCheckBox.Name = "eatCheckBox";
            this.eatCheckBox.Size = new System.Drawing.Size(42, 17);
            this.eatCheckBox.TabIndex = 0;
            this.eatCheckBox.Text = "Eat";
            this.eatCheckBox.UseVisualStyleBackColor = true;
            // 
            // festivalLabel
            // 
            this.festivalLabel.AutoSize = true;
            this.festivalLabel.Location = new System.Drawing.Point(190, 147);
            this.festivalLabel.Name = "festivalLabel";
            this.festivalLabel.Size = new System.Drawing.Size(43, 13);
            this.festivalLabel.TabIndex = 33;
            this.festivalLabel.Text = "Festival";
            // 
            // festivalNumericUpDown
            // 
            this.festivalNumericUpDown.Location = new System.Drawing.Point(244, 145);
            this.festivalNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.festivalNumericUpDown.Name = "festivalNumericUpDown";
            this.festivalNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.festivalNumericUpDown.TabIndex = 34;
            // 
            // treatGroupBox
            // 
            this.treatGroupBox.Controls.Add(this.normalTreatLabel);
            this.treatGroupBox.Controls.Add(this.regularTreatNumericUpDown);
            this.treatGroupBox.Controls.Add(this.rabbitTreatLabel);
            this.treatGroupBox.Controls.Add(this.sheepTreatLabel);
            this.treatGroupBox.Controls.Add(this.chickenTreatLabel);
            this.treatGroupBox.Controls.Add(this.cowTreatLabel);
            this.treatGroupBox.Controls.Add(this.rabbitTreatNumericUpDown);
            this.treatGroupBox.Controls.Add(this.sheepTreatNumericUpDown);
            this.treatGroupBox.Controls.Add(this.chickenTreatNumericUpDown);
            this.treatGroupBox.Controls.Add(this.cowTreatNumericUpDown);
            this.treatGroupBox.Location = new System.Drawing.Point(12, 250);
            this.treatGroupBox.Name = "treatGroupBox";
            this.treatGroupBox.Size = new System.Drawing.Size(280, 99);
            this.treatGroupBox.TabIndex = 35;
            this.treatGroupBox.TabStop = false;
            this.treatGroupBox.Text = "Treats";
            // 
            // normalTreatLabel
            // 
            this.normalTreatLabel.AutoSize = true;
            this.normalTreatLabel.Location = new System.Drawing.Point(96, 21);
            this.normalTreatLabel.Name = "normalTreatLabel";
            this.normalTreatLabel.Size = new System.Drawing.Size(40, 13);
            this.normalTreatLabel.TabIndex = 9;
            this.normalTreatLabel.Text = "Normal";
            // 
            // regularTreatNumericUpDown
            // 
            this.regularTreatNumericUpDown.Location = new System.Drawing.Point(144, 19);
            this.regularTreatNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.regularTreatNumericUpDown.Name = "regularTreatNumericUpDown";
            this.regularTreatNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.regularTreatNumericUpDown.TabIndex = 8;
            // 
            // rabbitTreatLabel
            // 
            this.rabbitTreatLabel.AutoSize = true;
            this.rabbitTreatLabel.Location = new System.Drawing.Point(157, 73);
            this.rabbitTreatLabel.Name = "rabbitTreatLabel";
            this.rabbitTreatLabel.Size = new System.Drawing.Size(38, 13);
            this.rabbitTreatLabel.TabIndex = 7;
            this.rabbitTreatLabel.Text = "Rabbit";
            // 
            // sheepTreatLabel
            // 
            this.sheepTreatLabel.AutoSize = true;
            this.sheepTreatLabel.Location = new System.Drawing.Point(6, 73);
            this.sheepTreatLabel.Name = "sheepTreatLabel";
            this.sheepTreatLabel.Size = new System.Drawing.Size(38, 13);
            this.sheepTreatLabel.TabIndex = 6;
            this.sheepTreatLabel.Text = "Sheep";
            // 
            // chickenTreatLabel
            // 
            this.chickenTreatLabel.AutoSize = true;
            this.chickenTreatLabel.Location = new System.Drawing.Point(157, 47);
            this.chickenTreatLabel.Name = "chickenTreatLabel";
            this.chickenTreatLabel.Size = new System.Drawing.Size(46, 13);
            this.chickenTreatLabel.TabIndex = 5;
            this.chickenTreatLabel.Text = "Chicken";
            // 
            // cowTreatLabel
            // 
            this.cowTreatLabel.AutoSize = true;
            this.cowTreatLabel.Location = new System.Drawing.Point(6, 47);
            this.cowTreatLabel.Name = "cowTreatLabel";
            this.cowTreatLabel.Size = new System.Drawing.Size(28, 13);
            this.cowTreatLabel.TabIndex = 4;
            this.cowTreatLabel.Text = "Cow";
            // 
            // rabbitTreatNumericUpDown
            // 
            this.rabbitTreatNumericUpDown.DecimalPlaces = 1;
            this.rabbitTreatNumericUpDown.Location = new System.Drawing.Point(218, 71);
            this.rabbitTreatNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.rabbitTreatNumericUpDown.Name = "rabbitTreatNumericUpDown";
            this.rabbitTreatNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.rabbitTreatNumericUpDown.TabIndex = 3;
            // 
            // sheepTreatNumericUpDown
            // 
            this.sheepTreatNumericUpDown.DecimalPlaces = 1;
            this.sheepTreatNumericUpDown.Location = new System.Drawing.Point(49, 71);
            this.sheepTreatNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sheepTreatNumericUpDown.Name = "sheepTreatNumericUpDown";
            this.sheepTreatNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.sheepTreatNumericUpDown.TabIndex = 2;
            // 
            // chickenTreatNumericUpDown
            // 
            this.chickenTreatNumericUpDown.DecimalPlaces = 1;
            this.chickenTreatNumericUpDown.Location = new System.Drawing.Point(218, 45);
            this.chickenTreatNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.chickenTreatNumericUpDown.Name = "chickenTreatNumericUpDown";
            this.chickenTreatNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.chickenTreatNumericUpDown.TabIndex = 1;
            // 
            // cowTreatNumericUpDown
            // 
            this.cowTreatNumericUpDown.DecimalPlaces = 1;
            this.cowTreatNumericUpDown.Location = new System.Drawing.Point(49, 45);
            this.cowTreatNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.cowTreatNumericUpDown.Name = "cowTreatNumericUpDown";
            this.cowTreatNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.cowTreatNumericUpDown.TabIndex = 0;
            // 
            // pregnantNumericUpDown
            // 
            this.pregnantNumericUpDown.Location = new System.Drawing.Point(180, 171);
            this.pregnantNumericUpDown.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.pregnantNumericUpDown.Name = "pregnantNumericUpDown";
            this.pregnantNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.pregnantNumericUpDown.TabIndex = 36;
            this.pregnantNumericUpDown.Visible = false;
            // 
            // pregnantCheckBox
            // 
            this.pregnantCheckBox.AutoSize = true;
            this.pregnantCheckBox.Location = new System.Drawing.Point(92, 174);
            this.pregnantCheckBox.Name = "pregnantCheckBox";
            this.pregnantCheckBox.Size = new System.Drawing.Size(69, 17);
            this.pregnantCheckBox.TabIndex = 37;
            this.pregnantCheckBox.Text = "Pregnant";
            this.pregnantCheckBox.UseVisualStyleBackColor = true;
            this.pregnantCheckBox.Visible = false;
            this.pregnantCheckBox.CheckedChanged += new System.EventHandler(this.pregnantCheckBox_CheckedChanged);
            // 
            // AnimalEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(304, 439);
            this.Controls.Add(this.pregnantCheckBox);
            this.Controls.Add(this.pregnantNumericUpDown);
            this.Controls.Add(this.treatGroupBox);
            this.Controls.Add(this.festivalNumericUpDown);
            this.Controls.Add(this.festivalLabel);
            this.Controls.Add(this.flagGroupBox);
            this.Controls.Add(this.woolLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.woolNumericUpDown);
            this.Controls.Add(this.productNumericUpDown);
            this.Controls.Add(this.personalityLabel);
            this.Controls.Add(this.personalityComboBox);
            this.Controls.Add(this.safariLabel);
            this.Controls.Add(this.safariNumericUpDown);
            this.Controls.Add(this.birthdayGroupBox);
            this.Controls.Add(this.stressNumericUpDown);
            this.Controls.Add(this.friendshipNumericUpDown);
            this.Controls.Add(this.stressLabel);
            this.Controls.Add(this.friendshipLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.slotLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.slotComboBox);
            this.Name = "AnimalEditingForm";
            this.Text = "Animal Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.friendshipNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stressNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.birthdayGroupBox.ResumeLayout(false);
            this.birthdayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safariNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woolNumericUpDown)).EndInit();
            this.flagGroupBox.ResumeLayout(false);
            this.flagGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.festivalNumericUpDown)).EndInit();
            this.treatGroupBox.ResumeLayout(false);
            this.treatGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regularTreatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitTreatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheepTreatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chickenTreatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowTreatNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregnantNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox slotComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label slotLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label friendshipLabel;
        private System.Windows.Forms.Label stressLabel;
        private System.Windows.Forms.NumericUpDown friendshipNumericUpDown;
        private System.Windows.Forms.NumericUpDown stressNumericUpDown;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.GroupBox birthdayGroupBox;
        private System.Windows.Forms.NumericUpDown safariNumericUpDown;
        private System.Windows.Forms.Label safariLabel;
        private System.Windows.Forms.ComboBox personalityComboBox;
        private System.Windows.Forms.Label personalityLabel;
        private System.Windows.Forms.NumericUpDown productNumericUpDown;
        private System.Windows.Forms.NumericUpDown woolNumericUpDown;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label woolLabel;
        private System.Windows.Forms.GroupBox flagGroupBox;
        private System.Windows.Forms.CheckBox treatCheckBox;
        private System.Windows.Forms.CheckBox brushCheckBox;
        private System.Windows.Forms.CheckBox collectCheckBox;
        private System.Windows.Forms.CheckBox touchCheckBox;
        private System.Windows.Forms.CheckBox eatCheckBox;
        private System.Windows.Forms.Label festivalLabel;
        private System.Windows.Forms.NumericUpDown festivalNumericUpDown;
        private System.Windows.Forms.CheckBox bellCheckBox;
        private System.Windows.Forms.GroupBox treatGroupBox;
        private System.Windows.Forms.NumericUpDown rabbitTreatNumericUpDown;
        private System.Windows.Forms.NumericUpDown sheepTreatNumericUpDown;
        private System.Windows.Forms.NumericUpDown chickenTreatNumericUpDown;
        private System.Windows.Forms.NumericUpDown cowTreatNumericUpDown;
        private System.Windows.Forms.Label rabbitTreatLabel;
        private System.Windows.Forms.Label sheepTreatLabel;
        private System.Windows.Forms.Label chickenTreatLabel;
        private System.Windows.Forms.Label cowTreatLabel;
        private System.Windows.Forms.NumericUpDown regularTreatNumericUpDown;
        private System.Windows.Forms.Label normalTreatLabel;
        private System.Windows.Forms.NumericUpDown pregnantNumericUpDown;
        private System.Windows.Forms.CheckBox pregnantCheckBox;
    }
}