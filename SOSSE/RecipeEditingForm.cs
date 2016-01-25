using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOSSE
{
    public partial class RecipeEditingForm : Form
    {
        private const int recipeSetOffset = 0x433E8;
        private const int recipeOffset = 0x43578;
        private static string[] secretNameList;
        private static int[] secretList = { 4, 4, 3, 2, 1, 1, 2, 2, 1, 4, 6, 4,
            6, 1, 1, 2, 6, 3, 4, 2, 4, 4, 5, 1, 6, 1, 4, 4, 1, 6, 3, 5, 1, 6, 1,
            6, 1, 1, 6, 6, 7, 7, 6, 1, 6, 3, 1, 1, 1, 6, 6, 1, 1, 1, 8, 8, 6, 8,
            8, 1, 1, 6, 3, 3, 1, 6, 1, 1, 2, 5, 2, 4, 2, 2, 1, 6, 2, 3, 6, 2, 2,
            6, 3, 6, 4, 8, 6, 5, 3, 2, 6, 1, 6, 5, 6, 3, 6, 2, 6, 6, 8, 1, 6, 2,
            6, 1, 2, 8, 8, 1, 8, 3, 4, 8, 4, 6, 3, 6, 6, 3, 3, 1, 1, 6, 2, 5, 6,
            5, 6, 1, 6, 1, 3, 8, 2, 1, 3, 1, 5, 8, 2, 1, 1, 2, 6, 8, 6, 6, 3, 5,
            6, 1, 3, 3, 3, 2, 1, 1, 2, 6, 6, 2, 7, 5, 2, 6, 3, 3, 6, 2, 2, 6, 2,
            2, 2, 2, 2, 1, 4, 5, 5, 7, 4, 7, 7, 5, 4, 6, 5, 4, 2, 4, 6, 6, 1, 1,
            4, 5, 2, 2, 8, 2, 6, 3, 6, 6, 1, 1, 3, 1, 6, 2, 1, 2, 2, 2, 7, 1, 5,
            7, 5, 7, 1, 5, 7, 7, 5, 5, 7, 1, 6, 2, 5, 7, 5, 1, 5, 7, 5, 7, 5, 5,
            7, 5, 1, 5, 5, 1, 5, 1, 5, 5, 7, 5, 1, 7, 7, 1, 7, 1, 5, 1, 7, 1, 7,
            5, 5, 7, 1, 5, 1, 5, 1, 5, 5, 1, 5, 5, 1, 5, 5, 7, 5, 7, 5, 7, 5, 1,
            7, 5, 5, 7, 5, 5, 1, 7, 2, 2, 5, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0 };

        /// <summary>
        /// Maximum number of recipe set in the game
        /// </summary>
        public const int MaxRecipeSet = 396;
        /// <summary>
        /// Maximum number of recipe in the game
        /// </summary>
        public const int MaxRecipe = 358;
        /// <summary>
        /// Indicate whether recipe data in the save file have been loaded or not.
        /// </summary>
        public bool DataLoaded { get; private set; }
        // Recipe name and recipe set name use the same list.
        public static string[] RecipeSetNameList;

        public RecipeEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            Util.LoadRecipeSetNameList();
            Util.LoadItemNameList();

            // Recipe List
            recipeDataGridView.Rows.Add(MaxRecipe);
            secretNameList = new string[9];
            secretNameList[0] = "None";
            secretNameList[1] = Item.ItemNameList[773];  // Salt
            secretNameList[2] = Item.ItemNameList[771];  // Soy Sauce
            secretNameList[3] = Item.ItemNameList[775];  // Spice
            secretNameList[4] = Item.ItemNameList[749];  // Mayonnaise
            secretNameList[5] = Item.ItemNameList[774];  // Sugar
            secretNameList[6] = Item.ItemNameList[1768]; // Pepper
            secretNameList[7] = Item.ItemNameList[1769]; // Cinnamon
            secretNameList[8] = Item.ItemNameList[772];  // Miso
            recipeSecret.Items.AddRange(secretNameList);
            for (int i = 0; i < MaxRecipe; i++)
            {
                var row = recipeDataGridView.Rows[i];
                row.Cells[0].Value = RecipeSetNameList[38 + i];
                bool unlocked = (MainForm.SaveData[recipeOffset + 6 * i] & 0x1) == 0x1;
                row.Cells[1].Value = unlocked;
                if (!unlocked)
                {
                    row.Cells[2].ReadOnly = true;
                    row.Cells[2].Style = MainForm.GrayCellStyle;
                    row.Cells[3].ReadOnly = true;
                    row.Cells[3].Style = MainForm.GrayCellStyle;
                }
                row.Cells[2].Value = BitConverter.ToUInt16(MainForm.SaveData,
                    recipeOffset + 6 * i + 0x2);
                int itemIndex = BitConverter.ToInt16(MainForm.SaveData,
                    recipeOffset + 6 * i + 0x4);
                if (itemIndex == -1)
                    row.Cells[3].Value = "None";
                else
                    row.Cells[3].Value = Item.ItemNameList[itemIndex];
            }

            // Recipe Set List
            recipeSetDataGridView.Rows.Add(MaxRecipeSet);
            for (int i = 0; i < MaxRecipeSet; i++)
            {
                var row = recipeSetDataGridView.Rows[i];
                row.Cells[0].Value = RecipeSetNameList[i];
                row.Cells[1].Value = (MainForm.SaveData[recipeSetOffset + i] & 0x1) == 0x1;
            }
            DataLoaded = true;
        }

        private void recipeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3) return;
            var cb = (ComboBox)recipeDataGridView.EditingControl;
            if (cb != null) cb.DroppedDown = true;
        }

        private void recipeDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (recipeDataGridView.CurrentCell.ColumnIndex == 1)
                recipeDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // Validate number of dishes.
        private void recipeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ushort cooked;
                bool isValid = UInt16.TryParse(e.FormattedValue.ToString(), out cooked);
                if (!isValid)
                {
                    recipeDataGridView.Rows[e.RowIndex].Cells[2].ErrorText =
                        "Number of cooked dishes must be a valid number between 0 and 65535";
                    recipeDataGridView.CancelEdit();
                }
                else
                    recipeDataGridView.Rows[e.RowIndex].Cells[2].ErrorText = null;
            }
        }

        // Update other related cells when a recipe is unlocked
        private void recipeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            if (e.ColumnIndex == 1)
            {
                var row = recipeDataGridView.Rows[e.RowIndex];
                if ((bool)row.Cells[1].Value)
                {
                    row.Cells[2].ReadOnly = false;
                    row.Cells[2].Style = recipeDataGridView.DefaultCellStyle;
                    row.Cells[3].ReadOnly = false;
                    row.Cells[3].Style = recipeDataGridView.DefaultCellStyle;
                }
                else
                {
                    row.Cells[2].ReadOnly = true;
                    row.Cells[2].Style = MainForm.GrayCellStyle;
                    row.Cells[3].ReadOnly = true;
                    row.Cells[3].Style = MainForm.GrayCellStyle;
                }
            }
        }

        private void allRecipeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxRecipe; i++)
            {
                var row = recipeDataGridView.Rows[i];
                if (!(bool)row.Cells[1].Value)
                {
                    row.Cells[1].Value = true;
                    row.Cells[2].ReadOnly = false;
                    row.Cells[2].Style = recipeDataGridView.DefaultCellStyle;
                    row.Cells[3].ReadOnly = false;
                    row.Cells[3].Style = recipeDataGridView.DefaultCellStyle;
                }
            }
        }

        private void bestIngredientButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxRecipe; i++)
                recipeDataGridView.Rows[i].Cells[3].Value =
                    secretNameList[secretList[i]];
        }

        private void allRecipeSetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxRecipeSet; i++)
                recipeSetDataGridView.Rows[i].Cells[1].Value = true;
        }

        /// <summary>
        /// Save all recipe data to the main save
        /// </summary>
        public void SaveRecipes()
        {
            for (int i = 0; i < MaxRecipeSet; i++)
                if ((bool)recipeSetDataGridView.Rows[i].Cells[1].Value)
                    MainForm.SaveData[recipeSetOffset + i] |= 0x1;
                else
                    MainForm.SaveData[recipeSetOffset + i] &= 0xFE;
            for (int i = 0; i < MaxRecipe; i++)
            {
                var row = recipeDataGridView.Rows[i];
                if ((bool)row.Cells[1].Value)
                    MainForm.SaveData[recipeOffset + 6 * i] |= 0x1;
                else
                    MainForm.SaveData[recipeOffset + 6 * i] &= 0xFE;
                ushort cooked = UInt16.Parse(row.Cells[2].Value.ToString());
                Array.Copy(BitConverter.GetBytes(cooked), 0, MainForm.SaveData,
                    recipeOffset + 6 * i + 0x2, 2);
                int secret = Array.IndexOf(Item.ItemNameList, row.Cells[3].Value.ToString());
                MainForm.SaveData[recipeOffset + 6 * i + 0x4] = (byte)(secret & 0xFF);
                MainForm.SaveData[recipeOffset + 6 * i + 0x5] = (byte)((secret >> 8) & 0xFF);
            }
        }

        private void RecipeEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRecipes();
        }
    }
}
