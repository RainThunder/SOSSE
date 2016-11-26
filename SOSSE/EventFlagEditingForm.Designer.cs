namespace SOSSE
{
    partial class EventFlagEditingForm
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
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.flagColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.AllowUserToAddRows = false;
            this.eventDataGridView.AllowUserToDeleteRows = false;
            this.eventDataGridView.AllowUserToResizeRows = false;
            this.eventDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flagColumn,
            this.valueColumn});
            this.eventDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.eventDataGridView.Location = new System.Drawing.Point(13, 13);
            this.eventDataGridView.MultiSelect = false;
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.RowHeadersVisible = false;
            this.eventDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.eventDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.eventDataGridView.Size = new System.Drawing.Size(484, 237);
            this.eventDataGridView.TabIndex = 0;
            // 
            // flagColumn
            // 
            this.flagColumn.HeaderText = "Flag";
            this.flagColumn.Name = "flagColumn";
            this.flagColumn.ReadOnly = true;
            this.flagColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.flagColumn.Width = 400;
            // 
            // valueColumn
            // 
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueColumn.Width = 64;
            // 
            // EventEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(509, 262);
            this.Controls.Add(this.eventDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventEditingForm";
            this.Text = "Event Flag Editor (Detailed)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eventDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
    }
}