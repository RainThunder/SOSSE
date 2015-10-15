namespace SOSSE
{
    partial class ObjectEditingForm
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
            this.objectDataGridView = new System.Windows.Forms.DataGridView();
            this.objectx99Button = new System.Windows.Forms.Button();
            this.objectNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.objectQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.objectNameColumn,
            this.objectQuantityColumn});
            this.objectDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.objectDataGridView.Location = new System.Drawing.Point(12, 12);
            this.objectDataGridView.MultiSelect = false;
            this.objectDataGridView.Name = "objectDataGridView";
            this.objectDataGridView.RowHeadersVisible = false;
            this.objectDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.objectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.objectDataGridView.Size = new System.Drawing.Size(212, 209);
            this.objectDataGridView.TabIndex = 0;
            this.objectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.objectDataGridView_CellClick);
            this.objectDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.objectDataGridView_CellValidating);
            this.objectDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.objectDataGridView_CellValueChanged);
            this.objectDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.objectDataGridView_CurrentCellDirtyStateChanged);
            // 
            // objectx99Button
            // 
            this.objectx99Button.Location = new System.Drawing.Point(149, 227);
            this.objectx99Button.Name = "objectx99Button";
            this.objectx99Button.Size = new System.Drawing.Size(75, 23);
            this.objectx99Button.TabIndex = 1;
            this.objectx99Button.Text = "Object x99";
            this.objectx99Button.UseVisualStyleBackColor = true;
            this.objectx99Button.Click += new System.EventHandler(this.objectx99Button_Click);
            // 
            // objectNameColumn
            // 
            this.objectNameColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.objectNameColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.objectNameColumn.HeaderText = "Object";
            this.objectNameColumn.Name = "objectNameColumn";
            this.objectNameColumn.Width = 160;
            // 
            // objectQuantityColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.objectQuantityColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.objectQuantityColumn.HeaderText = "Qty";
            this.objectQuantityColumn.MaxInputLength = 2;
            this.objectQuantityColumn.Name = "objectQuantityColumn";
            this.objectQuantityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.objectQuantityColumn.Width = 32;
            // 
            // ObjectEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(236, 262);
            this.Controls.Add(this.objectx99Button);
            this.Controls.Add(this.objectDataGridView);
            this.Name = "ObjectEditingForm";
            this.Text = "Object Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView objectDataGridView;
        private System.Windows.Forms.Button objectx99Button;
        private System.Windows.Forms.DataGridViewComboBoxColumn objectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectQuantityColumn;
    }
}