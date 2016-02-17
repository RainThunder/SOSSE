namespace SOSSE
{
    partial class ShopEditingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shopLabel = new System.Windows.Forms.Label();
            this.shopComboBox = new System.Windows.Forms.ComboBox();
            this.shopTabControl = new System.Windows.Forms.TabControl();
            this.itemTabPage = new System.Windows.Forms.TabPage();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueprintTabPage = new System.Windows.Forms.TabPage();
            this.blueprintDataGridView = new System.Windows.Forms.DataGridView();
            this.blueprintName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueprintUnlocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.blueprintBought = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recipeTabPage = new System.Windows.Forms.TabPage();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeSetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeUnlocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recipeBought = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patternTabPage = new System.Windows.Forms.TabPage();
            this.patternDataGridView = new System.Windows.Forms.DataGridView();
            this.patternName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternUnlocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patternBought = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.animalTabPage = new System.Windows.Forms.TabPage();
            this.animalDataGridView = new System.Windows.Forms.DataGridView();
            this.animalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalUnlocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shopTabControl.SuspendLayout();
            this.itemTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.blueprintTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintDataGridView)).BeginInit();
            this.recipeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).BeginInit();
            this.patternTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patternDataGridView)).BeginInit();
            this.animalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Location = new System.Drawing.Point(12, 15);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(32, 13);
            this.shopLabel.TabIndex = 0;
            this.shopLabel.Text = "Shop";
            // 
            // shopComboBox
            // 
            this.shopComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shopComboBox.FormattingEnabled = true;
            this.shopComboBox.Location = new System.Drawing.Point(153, 12);
            this.shopComboBox.Name = "shopComboBox";
            this.shopComboBox.Size = new System.Drawing.Size(220, 21);
            this.shopComboBox.TabIndex = 1;
            this.shopComboBox.SelectedIndexChanged += new System.EventHandler(this.shopComboBox_SelectedIndexChanged);
            // 
            // shopTabControl
            // 
            this.shopTabControl.Controls.Add(this.itemTabPage);
            this.shopTabControl.Controls.Add(this.blueprintTabPage);
            this.shopTabControl.Controls.Add(this.recipeTabPage);
            this.shopTabControl.Controls.Add(this.patternTabPage);
            this.shopTabControl.Controls.Add(this.animalTabPage);
            this.shopTabControl.Location = new System.Drawing.Point(12, 39);
            this.shopTabControl.Name = "shopTabControl";
            this.shopTabControl.SelectedIndex = 0;
            this.shopTabControl.Size = new System.Drawing.Size(361, 211);
            this.shopTabControl.TabIndex = 2;
            // 
            // itemTabPage
            // 
            this.itemTabPage.Controls.Add(this.itemDataGridView);
            this.itemTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemTabPage.Name = "itemTabPage";
            this.itemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemTabPage.Size = new System.Drawing.Size(353, 185);
            this.itemTabPage.TabIndex = 0;
            this.itemTabPage.Text = "Items";
            this.itemTabPage.UseVisualStyleBackColor = true;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToResizeColumns = false;
            this.itemDataGridView.AllowUserToResizeRows = false;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemAvailable,
            this.itemStock});
            this.itemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.itemDataGridView.Location = new System.Drawing.Point(6, 6);
            this.itemDataGridView.MultiSelect = false;
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(341, 173);
            this.itemDataGridView.TabIndex = 0;
            this.itemDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellClick);
            this.itemDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.itemDataGridView_CellValidating);
            this.itemDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellValueChanged);
            this.itemDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.itemDataGridView_CurrentCellDirtyStateChanged);
            // 
            // itemName
            // 
            this.itemName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemName.HeaderText = "Item";
            this.itemName.Name = "itemName";
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemName.Width = 192;
            // 
            // itemAvailable
            // 
            this.itemAvailable.HeaderText = "Available";
            this.itemAvailable.Name = "itemAvailable";
            this.itemAvailable.Width = 64;
            // 
            // itemStock
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.itemStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemStock.HeaderText = "Stock";
            this.itemStock.Name = "itemStock";
            this.itemStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemStock.Width = 64;
            // 
            // blueprintTabPage
            // 
            this.blueprintTabPage.Controls.Add(this.blueprintDataGridView);
            this.blueprintTabPage.Location = new System.Drawing.Point(4, 22);
            this.blueprintTabPage.Name = "blueprintTabPage";
            this.blueprintTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blueprintTabPage.Size = new System.Drawing.Size(353, 185);
            this.blueprintTabPage.TabIndex = 1;
            this.blueprintTabPage.Text = "Blueprint";
            this.blueprintTabPage.UseVisualStyleBackColor = true;
            // 
            // blueprintDataGridView
            // 
            this.blueprintDataGridView.AllowUserToAddRows = false;
            this.blueprintDataGridView.AllowUserToDeleteRows = false;
            this.blueprintDataGridView.AllowUserToResizeColumns = false;
            this.blueprintDataGridView.AllowUserToResizeRows = false;
            this.blueprintDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.blueprintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.blueprintDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blueprintName,
            this.blueprintUnlocked,
            this.blueprintBought});
            this.blueprintDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.blueprintDataGridView.Location = new System.Drawing.Point(6, 6);
            this.blueprintDataGridView.MultiSelect = false;
            this.blueprintDataGridView.Name = "blueprintDataGridView";
            this.blueprintDataGridView.RowHeadersVisible = false;
            this.blueprintDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.blueprintDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.blueprintDataGridView.Size = new System.Drawing.Size(341, 173);
            this.blueprintDataGridView.TabIndex = 0;
            // 
            // blueprintName
            // 
            this.blueprintName.HeaderText = "Blueprint Set";
            this.blueprintName.Name = "blueprintName";
            this.blueprintName.ReadOnly = true;
            this.blueprintName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.blueprintName.Width = 192;
            // 
            // blueprintUnlocked
            // 
            this.blueprintUnlocked.HeaderText = "Unlocked";
            this.blueprintUnlocked.Name = "blueprintUnlocked";
            this.blueprintUnlocked.Width = 64;
            // 
            // blueprintBought
            // 
            this.blueprintBought.HeaderText = "Bought";
            this.blueprintBought.Name = "blueprintBought";
            this.blueprintBought.Width = 64;
            // 
            // recipeTabPage
            // 
            this.recipeTabPage.Controls.Add(this.recipeDataGridView);
            this.recipeTabPage.Location = new System.Drawing.Point(4, 22);
            this.recipeTabPage.Name = "recipeTabPage";
            this.recipeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recipeTabPage.Size = new System.Drawing.Size(353, 185);
            this.recipeTabPage.TabIndex = 2;
            this.recipeTabPage.Text = "Recipe Set";
            this.recipeTabPage.UseVisualStyleBackColor = true;
            // 
            // recipeDataGridView
            // 
            this.recipeDataGridView.AllowUserToAddRows = false;
            this.recipeDataGridView.AllowUserToDeleteRows = false;
            this.recipeDataGridView.AllowUserToResizeColumns = false;
            this.recipeDataGridView.AllowUserToResizeRows = false;
            this.recipeDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.recipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.recipeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipeSetName,
            this.recipeUnlocked,
            this.recipeBought});
            this.recipeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.recipeDataGridView.Location = new System.Drawing.Point(6, 6);
            this.recipeDataGridView.MultiSelect = false;
            this.recipeDataGridView.Name = "recipeDataGridView";
            this.recipeDataGridView.RowHeadersVisible = false;
            this.recipeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recipeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.recipeDataGridView.Size = new System.Drawing.Size(341, 173);
            this.recipeDataGridView.TabIndex = 0;
            // 
            // recipeSetName
            // 
            this.recipeSetName.HeaderText = "Recipe Set";
            this.recipeSetName.Name = "recipeSetName";
            this.recipeSetName.ReadOnly = true;
            this.recipeSetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recipeSetName.Width = 192;
            // 
            // recipeUnlocked
            // 
            this.recipeUnlocked.HeaderText = "Unlocked";
            this.recipeUnlocked.Name = "recipeUnlocked";
            this.recipeUnlocked.Width = 64;
            // 
            // recipeBought
            // 
            this.recipeBought.HeaderText = "Bought";
            this.recipeBought.Name = "recipeBought";
            this.recipeBought.Width = 64;
            // 
            // patternTabPage
            // 
            this.patternTabPage.Controls.Add(this.patternDataGridView);
            this.patternTabPage.Location = new System.Drawing.Point(4, 22);
            this.patternTabPage.Name = "patternTabPage";
            this.patternTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patternTabPage.Size = new System.Drawing.Size(353, 185);
            this.patternTabPage.TabIndex = 3;
            this.patternTabPage.Text = "Pattern Set";
            this.patternTabPage.UseVisualStyleBackColor = true;
            // 
            // patternDataGridView
            // 
            this.patternDataGridView.AllowUserToAddRows = false;
            this.patternDataGridView.AllowUserToDeleteRows = false;
            this.patternDataGridView.AllowUserToResizeColumns = false;
            this.patternDataGridView.AllowUserToResizeRows = false;
            this.patternDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.patternDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.patternDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patternName,
            this.patternUnlocked,
            this.patternBought});
            this.patternDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.patternDataGridView.Location = new System.Drawing.Point(6, 6);
            this.patternDataGridView.MultiSelect = false;
            this.patternDataGridView.Name = "patternDataGridView";
            this.patternDataGridView.RowHeadersVisible = false;
            this.patternDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.patternDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.patternDataGridView.Size = new System.Drawing.Size(341, 173);
            this.patternDataGridView.TabIndex = 0;
            // 
            // patternName
            // 
            this.patternName.HeaderText = "Pattern Set";
            this.patternName.Name = "patternName";
            this.patternName.ReadOnly = true;
            this.patternName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patternName.Width = 192;
            // 
            // patternUnlocked
            // 
            this.patternUnlocked.HeaderText = "Unlocked";
            this.patternUnlocked.Name = "patternUnlocked";
            this.patternUnlocked.Width = 64;
            // 
            // patternBought
            // 
            this.patternBought.HeaderText = "Bought";
            this.patternBought.Name = "patternBought";
            this.patternBought.Width = 64;
            // 
            // animalTabPage
            // 
            this.animalTabPage.Controls.Add(this.animalDataGridView);
            this.animalTabPage.Location = new System.Drawing.Point(4, 22);
            this.animalTabPage.Name = "animalTabPage";
            this.animalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.animalTabPage.Size = new System.Drawing.Size(353, 185);
            this.animalTabPage.TabIndex = 4;
            this.animalTabPage.Text = "Animal";
            this.animalTabPage.UseVisualStyleBackColor = true;
            // 
            // animalDataGridView
            // 
            this.animalDataGridView.AllowUserToAddRows = false;
            this.animalDataGridView.AllowUserToDeleteRows = false;
            this.animalDataGridView.AllowUserToResizeColumns = false;
            this.animalDataGridView.AllowUserToResizeRows = false;
            this.animalDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.animalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.animalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalName,
            this.animalUnlocked});
            this.animalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.animalDataGridView.Location = new System.Drawing.Point(6, 6);
            this.animalDataGridView.MultiSelect = false;
            this.animalDataGridView.Name = "animalDataGridView";
            this.animalDataGridView.RowHeadersVisible = false;
            this.animalDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.animalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.animalDataGridView.Size = new System.Drawing.Size(341, 173);
            this.animalDataGridView.TabIndex = 1;
            // 
            // animalName
            // 
            this.animalName.HeaderText = "Animal";
            this.animalName.Name = "animalName";
            this.animalName.ReadOnly = true;
            this.animalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.animalName.Width = 192;
            // 
            // animalUnlocked
            // 
            this.animalUnlocked.HeaderText = "Unlocked";
            this.animalUnlocked.Name = "animalUnlocked";
            this.animalUnlocked.Width = 64;
            // 
            // ShopEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.shopTabControl);
            this.Controls.Add(this.shopComboBox);
            this.Controls.Add(this.shopLabel);
            this.Name = "ShopEditingForm";
            this.Text = "ShopEditingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopEditingForm_FormClosing);
            this.shopTabControl.ResumeLayout(false);
            this.itemTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.blueprintTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blueprintDataGridView)).EndInit();
            this.recipeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).EndInit();
            this.patternTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patternDataGridView)).EndInit();
            this.animalTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.ComboBox shopComboBox;
        private System.Windows.Forms.TabControl shopTabControl;
        private System.Windows.Forms.TabPage itemTabPage;
        private System.Windows.Forms.TabPage blueprintTabPage;
        private System.Windows.Forms.TabPage recipeTabPage;
        private System.Windows.Forms.TabPage patternTabPage;
        private System.Windows.Forms.TabPage animalTabPage;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridView blueprintDataGridView;
        private System.Windows.Forms.DataGridView recipeDataGridView;
        private System.Windows.Forms.DataGridView patternDataGridView;
        private System.Windows.Forms.DataGridView animalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueprintName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blueprintUnlocked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blueprintBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeSetName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recipeUnlocked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recipeBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patternUnlocked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patternBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn animalUnlocked;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemStock;
    }
}