namespace SOSSE
{
    partial class ConquestEditingForm
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
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.totalItemLabel = new System.Windows.Forms.Label();
            this.totalItemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemShipped = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalUniqueItemTextBox = new System.Windows.Forms.TextBox();
            this.totalUniqueItemLabel = new System.Windows.Forms.Label();
            this.itemVarietyGroupBox = new System.Windows.Forms.GroupBox();
            this.totalUniqueObjectTextBox = new System.Windows.Forms.TextBox();
            this.totalUniqueObjectLabel = new System.Windows.Forms.Label();
            this.objectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.moneyGroupBox = new System.Windows.Forms.GroupBox();
            this.itemGroupBox = new System.Windows.Forms.GroupBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.allItemButton = new System.Windows.Forms.Button();
            this.allObjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.itemVarietyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).BeginInit();
            this.moneyGroupBox.SuspendLayout();
            this.itemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(6, 22);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(95, 13);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "Shipment Earnings";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(128, 19);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(125, 20);
            this.moneyTextBox.TabIndex = 1;
            this.moneyTextBox.TextChanged += new System.EventHandler(this.moneyTextBox_TextChanged);
            // 
            // totalItemLabel
            // 
            this.totalItemLabel.AutoSize = true;
            this.totalItemLabel.Location = new System.Drawing.Point(6, 22);
            this.totalItemLabel.Name = "totalItemLabel";
            this.totalItemLabel.Size = new System.Drawing.Size(101, 13);
            this.totalItemLabel.TabIndex = 2;
            this.totalItemLabel.Text = "Total Items Shipped";
            // 
            // totalItemQuantityTextBox
            // 
            this.totalItemQuantityTextBox.Location = new System.Drawing.Point(128, 19);
            this.totalItemQuantityTextBox.Name = "totalItemQuantityTextBox";
            this.totalItemQuantityTextBox.ReadOnly = true;
            this.totalItemQuantityTextBox.Size = new System.Drawing.Size(125, 20);
            this.totalItemQuantityTextBox.TabIndex = 3;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToResizeColumns = false;
            this.itemDataGridView.AllowUserToResizeRows = false;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemShipped});
            this.itemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.itemDataGridView.Location = new System.Drawing.Point(6, 19);
            this.itemDataGridView.MultiSelect = false;
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(214, 186);
            this.itemDataGridView.TabIndex = 4;
            this.itemDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellValueChanged);
            this.itemDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.itemDataGridView_CurrentCellDirtyStateChanged);
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemName.Width = 160;
            // 
            // itemShipped
            // 
            this.itemShipped.HeaderText = "";
            this.itemShipped.Name = "itemShipped";
            this.itemShipped.Width = 32;
            // 
            // totalUniqueItemTextBox
            // 
            this.totalUniqueItemTextBox.Location = new System.Drawing.Point(120, 211);
            this.totalUniqueItemTextBox.Name = "totalUniqueItemTextBox";
            this.totalUniqueItemTextBox.ReadOnly = true;
            this.totalUniqueItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalUniqueItemTextBox.TabIndex = 5;
            // 
            // totalUniqueItemLabel
            // 
            this.totalUniqueItemLabel.AutoSize = true;
            this.totalUniqueItemLabel.Location = new System.Drawing.Point(3, 214);
            this.totalUniqueItemLabel.Name = "totalUniqueItemLabel";
            this.totalUniqueItemLabel.Size = new System.Drawing.Size(31, 13);
            this.totalUniqueItemLabel.TabIndex = 6;
            this.totalUniqueItemLabel.Text = "Total";
            // 
            // itemVarietyGroupBox
            // 
            this.itemVarietyGroupBox.Controls.Add(this.totalUniqueObjectTextBox);
            this.itemVarietyGroupBox.Controls.Add(this.totalUniqueObjectLabel);
            this.itemVarietyGroupBox.Controls.Add(this.itemDataGridView);
            this.itemVarietyGroupBox.Controls.Add(this.totalUniqueItemTextBox);
            this.itemVarietyGroupBox.Controls.Add(this.objectDataGridView);
            this.itemVarietyGroupBox.Controls.Add(this.totalUniqueItemLabel);
            this.itemVarietyGroupBox.Location = new System.Drawing.Point(277, 12);
            this.itemVarietyGroupBox.Name = "itemVarietyGroupBox";
            this.itemVarietyGroupBox.Size = new System.Drawing.Size(448, 238);
            this.itemVarietyGroupBox.TabIndex = 7;
            this.itemVarietyGroupBox.TabStop = false;
            this.itemVarietyGroupBox.Text = "Item Variety";
            // 
            // totalUniqueObjectTextBox
            // 
            this.totalUniqueObjectTextBox.Location = new System.Drawing.Point(340, 211);
            this.totalUniqueObjectTextBox.Name = "totalUniqueObjectTextBox";
            this.totalUniqueObjectTextBox.ReadOnly = true;
            this.totalUniqueObjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalUniqueObjectTextBox.TabIndex = 8;
            // 
            // totalUniqueObjectLabel
            // 
            this.totalUniqueObjectLabel.AutoSize = true;
            this.totalUniqueObjectLabel.Location = new System.Drawing.Point(226, 214);
            this.totalUniqueObjectLabel.Name = "totalUniqueObjectLabel";
            this.totalUniqueObjectLabel.Size = new System.Drawing.Size(31, 13);
            this.totalUniqueObjectLabel.TabIndex = 7;
            this.totalUniqueObjectLabel.Text = "Total";
            // 
            // objectDataGridView
            // 
            this.objectDataGridView.AllowUserToAddRows = false;
            this.objectDataGridView.AllowUserToDeleteRows = false;
            this.objectDataGridView.AllowUserToResizeColumns = false;
            this.objectDataGridView.AllowUserToResizeRows = false;
            this.objectDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.objectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.objectDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.objectDataGridView.Location = new System.Drawing.Point(226, 19);
            this.objectDataGridView.MultiSelect = false;
            this.objectDataGridView.Name = "objectDataGridView";
            this.objectDataGridView.RowHeadersVisible = false;
            this.objectDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.objectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.objectDataGridView.Size = new System.Drawing.Size(214, 186);
            this.objectDataGridView.TabIndex = 5;
            this.objectDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.objectDataGridView_CellValueChanged);
            this.objectDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.objectDataGridView_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Object";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 32;
            // 
            // moneyGroupBox
            // 
            this.moneyGroupBox.Controls.Add(this.moneyLabel);
            this.moneyGroupBox.Controls.Add(this.moneyTextBox);
            this.moneyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.moneyGroupBox.Name = "moneyGroupBox";
            this.moneyGroupBox.Size = new System.Drawing.Size(259, 46);
            this.moneyGroupBox.TabIndex = 9;
            this.moneyGroupBox.TabStop = false;
            this.moneyGroupBox.Text = "Shipment Earnings";
            // 
            // itemGroupBox
            // 
            this.itemGroupBox.Controls.Add(this.itemLabel);
            this.itemGroupBox.Controls.Add(this.itemQuantityTextBox);
            this.itemGroupBox.Controls.Add(this.categoryLabel);
            this.itemGroupBox.Controls.Add(this.categoryComboBox);
            this.itemGroupBox.Controls.Add(this.totalItemQuantityTextBox);
            this.itemGroupBox.Controls.Add(this.totalItemLabel);
            this.itemGroupBox.Location = new System.Drawing.Point(12, 90);
            this.itemGroupBox.Name = "itemGroupBox";
            this.itemGroupBox.Size = new System.Drawing.Size(259, 101);
            this.itemGroupBox.TabIndex = 10;
            this.itemGroupBox.TabStop = false;
            this.itemGroupBox.Text = "Total Items Shipped";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(6, 76);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(69, 13);
            this.itemLabel.TabIndex = 7;
            this.itemLabel.Text = "Item Shipped";
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Location = new System.Drawing.Point(128, 73);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(125, 20);
            this.itemQuantityTextBox.TabIndex = 6;
            this.itemQuantityTextBox.TextChanged += new System.EventHandler(this.itemQuantityTextBox_TextChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(6, 49);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(128, 46);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(125, 21);
            this.categoryComboBox.TabIndex = 4;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // allItemButton
            // 
            this.allItemButton.Location = new System.Drawing.Point(115, 224);
            this.allItemButton.Name = "allItemButton";
            this.allItemButton.Size = new System.Drawing.Size(75, 23);
            this.allItemButton.TabIndex = 11;
            this.allItemButton.Text = "All Items";
            this.allItemButton.UseVisualStyleBackColor = true;
            this.allItemButton.Click += new System.EventHandler(this.allItemButton_Click);
            // 
            // allObjectButton
            // 
            this.allObjectButton.Location = new System.Drawing.Point(196, 224);
            this.allObjectButton.Name = "allObjectButton";
            this.allObjectButton.Size = new System.Drawing.Size(75, 23);
            this.allObjectButton.TabIndex = 12;
            this.allObjectButton.Text = "All Objects";
            this.allObjectButton.UseVisualStyleBackColor = true;
            this.allObjectButton.Click += new System.EventHandler(this.allObjectButton_Click);
            // 
            // ConquestEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(752, 259);
            this.Controls.Add(this.allObjectButton);
            this.Controls.Add(this.allItemButton);
            this.Controls.Add(this.itemGroupBox);
            this.Controls.Add(this.moneyGroupBox);
            this.Controls.Add(this.itemVarietyGroupBox);
            this.Name = "ConquestEditingForm";
            this.Text = "Conquest Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Conquest_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.itemVarietyGroupBox.ResumeLayout(false);
            this.itemVarietyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).EndInit();
            this.moneyGroupBox.ResumeLayout(false);
            this.moneyGroupBox.PerformLayout();
            this.itemGroupBox.ResumeLayout(false);
            this.itemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label totalItemLabel;
        private System.Windows.Forms.TextBox totalItemQuantityTextBox;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.TextBox totalUniqueItemTextBox;
        private System.Windows.Forms.Label totalUniqueItemLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemShipped;
        private System.Windows.Forms.GroupBox itemVarietyGroupBox;
        private System.Windows.Forms.DataGridView objectDataGridView;
        private System.Windows.Forms.TextBox totalUniqueObjectTextBox;
        private System.Windows.Forms.Label totalUniqueObjectLabel;
        private System.Windows.Forms.GroupBox moneyGroupBox;
        private System.Windows.Forms.GroupBox itemGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button allItemButton;
        private System.Windows.Forms.Button allObjectButton;
    }
}