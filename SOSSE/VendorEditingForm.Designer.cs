namespace SOSSE
{
    partial class VendorEditingForm
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
            this.countryLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.customerPointTextBox = new System.Windows.Forms.TextBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 16);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.Text = "Country";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(169, 40);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(103, 20);
            this.moneyTextBox.TabIndex = 1;
            this.moneyTextBox.TextChanged += new System.EventHandler(this.moneyTextBox_TextChanged);
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(169, 66);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(103, 20);
            this.itemTextBox.TabIndex = 2;
            this.itemTextBox.TextChanged += new System.EventHandler(this.itemTextBox_TextChanged);
            // 
            // customerPointTextBox
            // 
            this.customerPointTextBox.Location = new System.Drawing.Point(169, 92);
            this.customerPointTextBox.Name = "customerPointTextBox";
            this.customerPointTextBox.Size = new System.Drawing.Size(103, 20);
            this.customerPointTextBox.TabIndex = 3;
            this.customerPointTextBox.TextChanged += new System.EventHandler(this.customerTextBox_TextChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(169, 13);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(103, 21);
            this.countryComboBox.TabIndex = 4;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Money Shipped";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(12, 69);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(151, 13);
            this.itemLabel.TabIndex = 6;
            this.itemLabel.Text = "Total Item and Object Shipped";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(12, 95);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(78, 13);
            this.customerLabel.TabIndex = 7;
            this.customerLabel.Text = "Customer Point";
            // 
            // VendorEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.customerPointTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.countryLabel);
            this.Name = "VendorEditingForm";
            this.Text = "Vendor Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VendorEditingForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox customerPointTextBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label customerLabel;
    }
}