namespace SOSSE
{
    partial class RecipeEditingForm
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
            this.helpLabel = new System.Windows.Forms.Label();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recipeCooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeSecret = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.recipeSetDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeSetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeSetAvailable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allRecipeButton = new System.Windows.Forms.Button();
            this.allRecipeSetButton = new System.Windows.Forms.Button();
            this.bestIngredientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(12, 9);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(336, 13);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "Note: Recipe Set is only used for shop and festival prize requirements.";
            // 
            // recipeDataGridView
            // 
            this.recipeDataGridView.AllowUserToAddRows = false;
            this.recipeDataGridView.AllowUserToDeleteRows = false;
            this.recipeDataGridView.AllowUserToResizeColumns = false;
            this.recipeDataGridView.AllowUserToResizeRows = false;
            this.recipeDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.recipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipeName,
            this.recipeAvailable,
            this.recipeCooked,
            this.recipeSecret});
            this.recipeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.recipeDataGridView.Location = new System.Drawing.Point(12, 25);
            this.recipeDataGridView.MultiSelect = false;
            this.recipeDataGridView.Name = "recipeDataGridView";
            this.recipeDataGridView.RowHeadersVisible = false;
            this.recipeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recipeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.recipeDataGridView.Size = new System.Drawing.Size(356, 196);
            this.recipeDataGridView.TabIndex = 1;
            this.recipeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipeDataGridView_CellClick);
            this.recipeDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.recipeDataGridView_CellValidating);
            this.recipeDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipeDataGridView_CellValueChanged);
            this.recipeDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.recipeDataGridView_CurrentCellDirtyStateChanged);
            // 
            // recipeName
            // 
            this.recipeName.HeaderText = "Recipe";
            this.recipeName.Name = "recipeName";
            this.recipeName.ReadOnly = true;
            this.recipeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recipeName.Width = 160;
            // 
            // recipeAvailable
            // 
            this.recipeAvailable.HeaderText = "";
            this.recipeAvailable.Name = "recipeAvailable";
            this.recipeAvailable.Width = 32;
            // 
            // recipeCooked
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.recipeCooked.DefaultCellStyle = dataGridViewCellStyle1;
            this.recipeCooked.HeaderText = "Cooked";
            this.recipeCooked.Name = "recipeCooked";
            this.recipeCooked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recipeCooked.ToolTipText = "Number of dishes cooked using this recipe.";
            this.recipeCooked.Width = 64;
            // 
            // recipeSecret
            // 
            this.recipeSecret.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.recipeSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipeSecret.HeaderText = "Secret";
            this.recipeSecret.Name = "recipeSecret";
            this.recipeSecret.Width = 80;
            // 
            // recipeSetDataGridView
            // 
            this.recipeSetDataGridView.AllowUserToAddRows = false;
            this.recipeSetDataGridView.AllowUserToDeleteRows = false;
            this.recipeSetDataGridView.AllowUserToResizeColumns = false;
            this.recipeSetDataGridView.AllowUserToResizeRows = false;
            this.recipeSetDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.recipeSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipeSetName,
            this.recipeSetAvailable});
            this.recipeSetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.recipeSetDataGridView.Location = new System.Drawing.Point(374, 25);
            this.recipeSetDataGridView.MultiSelect = false;
            this.recipeSetDataGridView.Name = "recipeSetDataGridView";
            this.recipeSetDataGridView.RowHeadersVisible = false;
            this.recipeSetDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recipeSetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.recipeSetDataGridView.Size = new System.Drawing.Size(212, 196);
            this.recipeSetDataGridView.TabIndex = 2;
            // 
            // recipeSetName
            // 
            this.recipeSetName.HeaderText = "Recipe Set";
            this.recipeSetName.Name = "recipeSetName";
            this.recipeSetName.ReadOnly = true;
            this.recipeSetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.recipeSetName.Width = 160;
            // 
            // recipeSetAvailable
            // 
            this.recipeSetAvailable.HeaderText = "";
            this.recipeSetAvailable.Name = "recipeSetAvailable";
            this.recipeSetAvailable.Width = 32;
            // 
            // allRecipeButton
            // 
            this.allRecipeButton.Location = new System.Drawing.Point(187, 227);
            this.allRecipeButton.Name = "allRecipeButton";
            this.allRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.allRecipeButton.TabIndex = 3;
            this.allRecipeButton.Text = "Unlock All";
            this.allRecipeButton.UseVisualStyleBackColor = true;
            this.allRecipeButton.Click += new System.EventHandler(this.allRecipeButton_Click);
            // 
            // allRecipeSetButton
            // 
            this.allRecipeSetButton.Location = new System.Drawing.Point(511, 227);
            this.allRecipeSetButton.Name = "allRecipeSetButton";
            this.allRecipeSetButton.Size = new System.Drawing.Size(75, 23);
            this.allRecipeSetButton.TabIndex = 4;
            this.allRecipeSetButton.Text = "Unlock All";
            this.allRecipeSetButton.UseVisualStyleBackColor = true;
            this.allRecipeSetButton.Click += new System.EventHandler(this.allRecipeSetButton_Click);
            // 
            // bestIngredientButton
            // 
            this.bestIngredientButton.Location = new System.Drawing.Point(268, 227);
            this.bestIngredientButton.Name = "bestIngredientButton";
            this.bestIngredientButton.Size = new System.Drawing.Size(100, 23);
            this.bestIngredientButton.TabIndex = 5;
            this.bestIngredientButton.Text = "Best Ingredient";
            this.bestIngredientButton.UseVisualStyleBackColor = true;
            this.bestIngredientButton.Click += new System.EventHandler(this.bestIngredientButton_Click);
            // 
            // RecipeEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(598, 262);
            this.Controls.Add(this.bestIngredientButton);
            this.Controls.Add(this.allRecipeSetButton);
            this.Controls.Add(this.allRecipeButton);
            this.Controls.Add(this.recipeSetDataGridView);
            this.Controls.Add(this.recipeDataGridView);
            this.Controls.Add(this.helpLabel);
            this.Name = "RecipeEditingForm";
            this.Text = "Recipe Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecipeEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.DataGridView recipeDataGridView;
        private System.Windows.Forms.DataGridView recipeSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeSetName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recipeSetAvailable;
        private System.Windows.Forms.Button allRecipeButton;
        private System.Windows.Forms.Button allRecipeSetButton;
        private System.Windows.Forms.Button bestIngredientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recipeAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeCooked;
        private System.Windows.Forms.DataGridViewComboBoxColumn recipeSecret;
    }
}