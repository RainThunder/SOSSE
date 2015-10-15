namespace SOSSE
{
    partial class PatternEditingForm
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
            this.patternDataGridView = new System.Windows.Forms.DataGridView();
            this.patternName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allPatternButton = new System.Windows.Forms.Button();
            this.patternSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allPatternSetButton = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patternDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patternDataGridView
            // 
            this.patternDataGridView.AllowUserToAddRows = false;
            this.patternDataGridView.AllowUserToDeleteRows = false;
            this.patternDataGridView.AllowUserToResizeColumns = false;
            this.patternDataGridView.AllowUserToResizeRows = false;
            this.patternDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.patternDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patternDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patternName,
            this.patternAvailable});
            this.patternDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.patternDataGridView.Location = new System.Drawing.Point(12, 25);
            this.patternDataGridView.MultiSelect = false;
            this.patternDataGridView.Name = "patternDataGridView";
            this.patternDataGridView.RowHeadersVisible = false;
            this.patternDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.patternDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.patternDataGridView.Size = new System.Drawing.Size(212, 196);
            this.patternDataGridView.TabIndex = 0;
            // 
            // patternName
            // 
            this.patternName.HeaderText = "Pattern";
            this.patternName.Name = "patternName";
            this.patternName.ReadOnly = true;
            this.patternName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.patternName.Width = 160;
            // 
            // patternAvailable
            // 
            this.patternAvailable.HeaderText = "";
            this.patternAvailable.Name = "patternAvailable";
            this.patternAvailable.Width = 32;
            // 
            // allPatternButton
            // 
            this.allPatternButton.Location = new System.Drawing.Point(149, 227);
            this.allPatternButton.Name = "allPatternButton";
            this.allPatternButton.Size = new System.Drawing.Size(75, 23);
            this.allPatternButton.TabIndex = 1;
            this.allPatternButton.Text = "Unlock All";
            this.allPatternButton.UseVisualStyleBackColor = true;
            this.allPatternButton.Click += new System.EventHandler(this.allPatternButton_Click);
            // 
            // patternSetDataGridView
            // 
            this.patternSetDataGridView.AllowUserToAddRows = false;
            this.patternSetDataGridView.AllowUserToDeleteRows = false;
            this.patternSetDataGridView.AllowUserToResizeColumns = false;
            this.patternSetDataGridView.AllowUserToResizeRows = false;
            this.patternSetDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.patternSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patternSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.patternSetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.patternSetDataGridView.Location = new System.Drawing.Point(230, 25);
            this.patternSetDataGridView.MultiSelect = false;
            this.patternSetDataGridView.Name = "patternSetDataGridView";
            this.patternSetDataGridView.RowHeadersVisible = false;
            this.patternSetDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.patternSetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.patternSetDataGridView.Size = new System.Drawing.Size(212, 196);
            this.patternSetDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Pattern Set";
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
            // allPatternSetButton
            // 
            this.allPatternSetButton.Location = new System.Drawing.Point(367, 227);
            this.allPatternSetButton.Name = "allPatternSetButton";
            this.allPatternSetButton.Size = new System.Drawing.Size(75, 23);
            this.allPatternSetButton.TabIndex = 3;
            this.allPatternSetButton.Text = "Unlock All";
            this.allPatternSetButton.UseVisualStyleBackColor = true;
            this.allPatternSetButton.Click += new System.EventHandler(this.allPatternSetButton_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(12, 9);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(373, 13);
            this.helpLabel.TabIndex = 4;
            this.helpLabel.Text = "Note: Pattern Set section is only used for shop and festival prize requirements.";
            // 
            // PatternEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.allPatternSetButton);
            this.Controls.Add(this.patternSetDataGridView);
            this.Controls.Add(this.allPatternButton);
            this.Controls.Add(this.patternDataGridView);
            this.Name = "PatternEditingForm";
            this.Text = "Pattern Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatternEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.patternDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patternDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn patternAvailable;
        private System.Windows.Forms.Button allPatternButton;
        private System.Windows.Forms.DataGridView patternSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button allPatternSetButton;
        private System.Windows.Forms.Label helpLabel;
    }
}