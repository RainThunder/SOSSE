namespace SOSSE
{
    partial class BalanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.AllowUserToAddRows = false;
            this.balanceDataGridView.AllowUserToDeleteRows = false;
            this.balanceDataGridView.AllowUserToResizeRows = false;
            this.balanceDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.income,
            this.outcome});
            this.balanceDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.balanceDataGridView.Location = new System.Drawing.Point(12, 13);
            this.balanceDataGridView.MultiSelect = false;
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.ReadOnly = true;
            this.balanceDataGridView.RowHeadersVisible = false;
            this.balanceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.balanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.balanceDataGridView.Size = new System.Drawing.Size(404, 237);
            this.balanceDataGridView.TabIndex = 0;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.time.Width = 192;
            // 
            // income
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.income.DefaultCellStyle = dataGridViewCellStyle1;
            this.income.HeaderText = "Income";
            this.income.Name = "income";
            this.income.ReadOnly = true;
            this.income.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.income.Width = 96;
            // 
            // outcome
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.outcome.DefaultCellStyle = dataGridViewCellStyle2;
            this.outcome.HeaderText = "Outcome";
            this.outcome.Name = "outcome";
            this.outcome.ReadOnly = true;
            this.outcome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.outcome.Width = 96;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.balanceDataGridView);
            this.Name = "Balance";
            this.Text = "Balance (Read Only)";
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcome;
    }
}