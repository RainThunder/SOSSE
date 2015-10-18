namespace SOSSE
{
    partial class BlueprintEditingForm
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
            this.blueprintDataGridView = new System.Windows.Forms.DataGridView();
            this.blueprintColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueprintAvailableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allBlueprintButton = new System.Windows.Forms.Button();
            this.blueprintSetDataGridView = new System.Windows.Forms.DataGridView();
            this.blueprintSetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueprintSetAvailableColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.helpLabel = new System.Windows.Forms.Label();
            this.allBlueprintSetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // blueprintDataGridView
            // 
            this.blueprintDataGridView.AllowUserToAddRows = false;
            this.blueprintDataGridView.AllowUserToDeleteRows = false;
            this.blueprintDataGridView.AllowUserToResizeColumns = false;
            this.blueprintDataGridView.AllowUserToResizeRows = false;
            this.blueprintDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.blueprintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blueprintDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blueprintColumn,
            this.blueprintAvailableColumn});
            this.blueprintDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.blueprintDataGridView.Location = new System.Drawing.Point(12, 25);
            this.blueprintDataGridView.MultiSelect = false;
            this.blueprintDataGridView.Name = "blueprintDataGridView";
            this.blueprintDataGridView.RowHeadersVisible = false;
            this.blueprintDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.blueprintDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.blueprintDataGridView.Size = new System.Drawing.Size(212, 196);
            this.blueprintDataGridView.TabIndex = 0;
            // 
            // blueprintColumn
            // 
            this.blueprintColumn.HeaderText = "Blueprint";
            this.blueprintColumn.Name = "blueprintColumn";
            this.blueprintColumn.ReadOnly = true;
            this.blueprintColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.blueprintColumn.Width = 160;
            // 
            // blueprintAvailableColumn
            // 
            this.blueprintAvailableColumn.HeaderText = "";
            this.blueprintAvailableColumn.Name = "blueprintAvailableColumn";
            this.blueprintAvailableColumn.Width = 32;
            // 
            // allBlueprintButton
            // 
            this.allBlueprintButton.Location = new System.Drawing.Point(149, 227);
            this.allBlueprintButton.Name = "allBlueprintButton";
            this.allBlueprintButton.Size = new System.Drawing.Size(75, 23);
            this.allBlueprintButton.TabIndex = 1;
            this.allBlueprintButton.Text = "Unlock All";
            this.allBlueprintButton.UseVisualStyleBackColor = true;
            this.allBlueprintButton.Click += new System.EventHandler(this.allBlueprintButton_Click);
            // 
            // blueprintSetDataGridView
            // 
            this.blueprintSetDataGridView.AllowUserToAddRows = false;
            this.blueprintSetDataGridView.AllowUserToDeleteRows = false;
            this.blueprintSetDataGridView.AllowUserToResizeColumns = false;
            this.blueprintSetDataGridView.AllowUserToResizeRows = false;
            this.blueprintSetDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.blueprintSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blueprintSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blueprintSetColumn,
            this.blueprintSetAvailableColumn});
            this.blueprintSetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.blueprintSetDataGridView.Location = new System.Drawing.Point(230, 25);
            this.blueprintSetDataGridView.MultiSelect = false;
            this.blueprintSetDataGridView.Name = "blueprintSetDataGridView";
            this.blueprintSetDataGridView.RowHeadersVisible = false;
            this.blueprintSetDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.blueprintSetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.blueprintSetDataGridView.Size = new System.Drawing.Size(212, 196);
            this.blueprintSetDataGridView.TabIndex = 2;
            // 
            // blueprintSetColumn
            // 
            this.blueprintSetColumn.HeaderText = "Blueprint Set";
            this.blueprintSetColumn.Name = "blueprintSetColumn";
            this.blueprintSetColumn.ReadOnly = true;
            this.blueprintSetColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.blueprintSetColumn.Width = 160;
            // 
            // blueprintSetAvailableColumn
            // 
            this.blueprintSetAvailableColumn.HeaderText = "";
            this.blueprintSetAvailableColumn.Name = "blueprintSetAvailableColumn";
            this.blueprintSetAvailableColumn.Width = 32;
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(12, 9);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(375, 13);
            this.helpLabel.TabIndex = 3;
            this.helpLabel.Text = "Note: Blueprint Set section is only used for shop and festival prize requirement." +
    "";
            // 
            // allBlueprintSetButton
            // 
            this.allBlueprintSetButton.Location = new System.Drawing.Point(367, 227);
            this.allBlueprintSetButton.Name = "allBlueprintSetButton";
            this.allBlueprintSetButton.Size = new System.Drawing.Size(75, 23);
            this.allBlueprintSetButton.TabIndex = 4;
            this.allBlueprintSetButton.Text = "Unlock All";
            this.allBlueprintSetButton.UseVisualStyleBackColor = true;
            this.allBlueprintSetButton.Click += new System.EventHandler(this.allBlueprintSetButton_Click);
            // 
            // BlueprintEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.allBlueprintSetButton);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.blueprintSetDataGridView);
            this.Controls.Add(this.allBlueprintButton);
            this.Controls.Add(this.blueprintDataGridView);
            this.Name = "BlueprintEditingForm";
            this.Text = "Blueprint Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlueprintEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.blueprintDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueprintSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView blueprintDataGridView;
        private System.Windows.Forms.Button allBlueprintButton;
        private System.Windows.Forms.DataGridView blueprintSetDataGridView;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Button allBlueprintSetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueprintColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blueprintAvailableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueprintSetColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blueprintSetAvailableColumn;
    }
}