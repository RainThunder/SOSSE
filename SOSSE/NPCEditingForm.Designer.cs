namespace SOSSE
{
    partial class NPCEditingForm
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
            this.npcComboBox = new System.Windows.Forms.ComboBox();
            this.characterLabel = new System.Windows.Forms.Label();
            this.friendshipNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.friendshipLabel = new System.Windows.Forms.Label();
            this.giftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bestGiftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.giftLabel = new System.Windows.Forms.Label();
            this.bestGiftLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friendshipNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestGiftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // npcComboBox
            // 
            this.npcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.npcComboBox.FormattingEnabled = true;
            this.npcComboBox.Location = new System.Drawing.Point(84, 12);
            this.npcComboBox.Name = "npcComboBox";
            this.npcComboBox.Size = new System.Drawing.Size(188, 21);
            this.npcComboBox.TabIndex = 0;
            this.npcComboBox.SelectedIndexChanged += new System.EventHandler(this.npcComboBox_SelectedIndexChanged);
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Location = new System.Drawing.Point(12, 15);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(53, 13);
            this.characterLabel.TabIndex = 1;
            this.characterLabel.Text = "Character";
            // 
            // friendshipNumericUpDown
            // 
            this.friendshipNumericUpDown.Location = new System.Drawing.Point(84, 40);
            this.friendshipNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.friendshipNumericUpDown.Name = "friendshipNumericUpDown";
            this.friendshipNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.friendshipNumericUpDown.TabIndex = 2;
            this.friendshipNumericUpDown.ValueChanged += new System.EventHandler(this.friendshipNumericUpDown_ValueChanged);
            // 
            // friendshipLabel
            // 
            this.friendshipLabel.AutoSize = true;
            this.friendshipLabel.Location = new System.Drawing.Point(12, 42);
            this.friendshipLabel.Name = "friendshipLabel";
            this.friendshipLabel.Size = new System.Drawing.Size(55, 13);
            this.friendshipLabel.TabIndex = 3;
            this.friendshipLabel.Text = "Friendship";
            // 
            // giftNumericUpDown
            // 
            this.giftNumericUpDown.Location = new System.Drawing.Point(84, 66);
            this.giftNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.giftNumericUpDown.Name = "giftNumericUpDown";
            this.giftNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.giftNumericUpDown.TabIndex = 4;
            // 
            // bestGiftNumericUpDown
            // 
            this.bestGiftNumericUpDown.Location = new System.Drawing.Point(220, 66);
            this.bestGiftNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.bestGiftNumericUpDown.Name = "bestGiftNumericUpDown";
            this.bestGiftNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.bestGiftNumericUpDown.TabIndex = 5;
            // 
            // giftLabel
            // 
            this.giftLabel.AutoSize = true;
            this.giftLabel.Location = new System.Drawing.Point(12, 68);
            this.giftLabel.Name = "giftLabel";
            this.giftLabel.Size = new System.Drawing.Size(50, 13);
            this.giftLabel.TabIndex = 6;
            this.giftLabel.Text = "Total Gift";
            // 
            // bestGiftLabel
            // 
            this.bestGiftLabel.AutoSize = true;
            this.bestGiftLabel.Location = new System.Drawing.Point(167, 68);
            this.bestGiftLabel.Name = "bestGiftLabel";
            this.bestGiftLabel.Size = new System.Drawing.Size(47, 13);
            this.bestGiftLabel.TabIndex = 7;
            this.bestGiftLabel.Text = "Best Gift";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(12, 94);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(66, 13);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = "Talk Interval";
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Location = new System.Drawing.Point(84, 92);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.intervalNumericUpDown.TabIndex = 9;
            // 
            // levelComboBox
            // 
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(210, 39);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(62, 21);
            this.levelComboBox.TabIndex = 10;
            this.levelComboBox.SelectedIndexChanged += new System.EventHandler(this.levelComboBox_SelectedIndexChanged);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(165, 42);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(33, 13);
            this.levelLabel.TabIndex = 11;
            this.levelLabel.Text = "Level";
            // 
            // NPCEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.intervalNumericUpDown);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.bestGiftLabel);
            this.Controls.Add(this.giftLabel);
            this.Controls.Add(this.bestGiftNumericUpDown);
            this.Controls.Add(this.giftNumericUpDown);
            this.Controls.Add(this.friendshipLabel);
            this.Controls.Add(this.friendshipNumericUpDown);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.npcComboBox);
            this.Name = "NPCEditingForm";
            this.Text = "NPC Editor (Preliminary)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NPCEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.friendshipNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestGiftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox npcComboBox;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.NumericUpDown friendshipNumericUpDown;
        private System.Windows.Forms.Label friendshipLabel;
        private System.Windows.Forms.NumericUpDown giftNumericUpDown;
        private System.Windows.Forms.NumericUpDown bestGiftNumericUpDown;
        private System.Windows.Forms.Label giftLabel;
        private System.Windows.Forms.Label bestGiftLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label levelLabel;
    }
}