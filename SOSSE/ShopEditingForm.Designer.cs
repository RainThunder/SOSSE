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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shopLabel = new System.Windows.Forms.Label();
            this.shopComboBox = new System.Windows.Forms.ComboBox();
            this.shopTabControl = new System.Windows.Forms.TabControl();
            this.itemTabPage = new System.Windows.Forms.TabPage();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.itemColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemAvailabilityColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemStockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueprintTabPage = new System.Windows.Forms.TabPage();
            this.blueprintDataGridView = new System.Windows.Forms.DataGridView();
            this.blueprintSetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueprintUnlockedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.blueprintBoughtColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recipeTabPage = new System.Windows.Forms.TabPage();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeSetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeUnlockedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recipeBoughtColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patternTabPage = new System.Windows.Forms.TabPage();
            this.patternDataGridView = new System.Windows.Forms.DataGridView();
            this.patternSetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternUnlockedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patternBoughtColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.animalTabPage = new System.Windows.Forms.TabPage();
            this.animalDataGridView = new System.Windows.Forms.DataGridView();
            this.animalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalUnlockedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.shopTabControl.SelectedIndexChanged += new System.EventHandler(this.shopTabControl_SelectedIndexChanged);
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
            this.itemColumn,
            this.itemAvailabilityColumn,
            this.itemStockColumn});
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
            // itemColumn
            // 
            this.itemColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemColumn.HeaderText = "Item";
            this.itemColumn.Name = "itemColumn";
            this.itemColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemColumn.Width = 192;
            // 
            // itemAvailabilityColumn
            // 
            this.itemAvailabilityColumn.HeaderText = "Available";
            this.itemAvailabilityColumn.Name = "itemAvailabilityColumn";
            this.itemAvailabilityColumn.Width = 64;
            // 
            // itemStockColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.itemStockColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemStockColumn.HeaderText = "Stock";
            this.itemStockColumn.MaxInputLength = 2;
            this.itemStockColumn.Name = "itemStockColumn";
            this.itemStockColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemStockColumn.Width = 64;
            // 
            // blueprintTabPage
            // 
            this.blueprintTabPage.Controls.Add(this.blueprintDataGridView);
            this.blueprintTabPage.Location = new System.Drawing.Point(4, 22);
            this.blueprintTabPage.Name = "blueprintTabPage";
            this.blueprintTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blueprintTabPage.Size = new System.Drawing.Size(353, 185);
            this.blueprintTabPage.TabIndex = 1;
            this.blueprintTabPage.Text = "Blueprint Set";
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
            this.blueprintSetColumn,
            this.blueprintUnlockedColumn,
            this.blueprintBoughtColumn});
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
            // blueprintSetColumn
            // 
            this.blueprintSetColumn.HeaderText = "Blueprint Set";
            this.blueprintSetColumn.Name = "blueprintSetColumn";
            this.blueprintSetColumn.ReadOnly = true;
            this.blueprintSetColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.blueprintSetColumn.Width = 192;
            // 
            // blueprintUnlockedColumn
            // 
            this.blueprintUnlockedColumn.HeaderText = "Unlocked";
            this.blueprintUnlockedColumn.Name = "blueprintUnlockedColumn";
            this.blueprintUnlockedColumn.Width = 64;
            // 
            // blueprintBoughtColumn
            // 
            this.blueprintBoughtColumn.HeaderText = "Bought";
            this.blueprintBoughtColumn.Name = "blueprintBoughtColumn";
            this.blueprintBoughtColumn.Width = 64;
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
            this.recipeSetColumn,
            this.recipeUnlockedColumn,
            this.recipeBoughtColumn});
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
            // recipeSetColumn
            // 
            this.recipeSetColumn.HeaderText = "Recipe Set";
            this.recipeSetColumn.Name = "recipeSetColumn";
            this.recipeSetColumn.ReadOnly = true;
            this.recipeSetColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recipeSetColumn.Width = 192;
            // 
            // recipeUnlockedColumn
            // 
            this.recipeUnlockedColumn.HeaderText = "Unlocked";
            this.recipeUnlockedColumn.Name = "recipeUnlockedColumn";
            this.recipeUnlockedColumn.Width = 64;
            // 
            // recipeBoughtColumn
            // 
            this.recipeBoughtColumn.HeaderText = "Bought";
            this.recipeBoughtColumn.Name = "recipeBoughtColumn";
            this.recipeBoughtColumn.Width = 64;
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
            this.patternSetColumn,
            this.patternUnlockedColumn,
            this.patternBoughtColumn});
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
            // patternSetColumn
            // 
            this.patternSetColumn.HeaderText = "Pattern Set";
            this.patternSetColumn.Name = "patternSetColumn";
            this.patternSetColumn.ReadOnly = true;
            this.patternSetColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patternSetColumn.Width = 192;
            // 
            // patternUnlockedColumn
            // 
            this.patternUnlockedColumn.HeaderText = "Unlocked";
            this.patternUnlockedColumn.Name = "patternUnlockedColumn";
            this.patternUnlockedColumn.Width = 64;
            // 
            // patternBoughtColumn
            // 
            this.patternBoughtColumn.HeaderText = "Bought";
            this.patternBoughtColumn.Name = "patternBoughtColumn";
            this.patternBoughtColumn.Width = 64;
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
            this.animalColumn,
            this.animalUnlockedColumn});
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
            // animalColumn
            // 
            this.animalColumn.HeaderText = "Animal";
            this.animalColumn.Name = "animalColumn";
            this.animalColumn.ReadOnly = true;
            this.animalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.animalColumn.Width = 192;
            // 
            // animalUnlockedColumn
            // 
            this.animalUnlockedColumn.HeaderText = "Unlocked";
            this.animalUnlockedColumn.Name = "animalUnlockedColumn";
            this.animalUnlockedColumn.Width = 64;
            // 
            // ShopEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.shopTabControl);
            this.Controls.Add(this.shopComboBox);
            this.Controls.Add(this.shopLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopEditingForm";
            this.Text = "Shop Editor";
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
        private System.Windows.Forms.DataGridViewComboBoxColumn itemColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemAvailabilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemStockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueprintSetColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blueprintUnlockedColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blueprintBoughtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeSetColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recipeUnlockedColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recipeBoughtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternSetColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patternUnlockedColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patternBoughtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn animalUnlockedColumn;
    }
}