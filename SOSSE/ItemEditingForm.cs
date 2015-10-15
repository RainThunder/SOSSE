using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SOSSE
{
    public partial class ItemEditingForm : Form
    {
        private Item[] bagItems;
        private Item[] toolboxItems;
        private Item[] fridgeItems;
        private Item[] storageItems;
        private Item[] materialItems;
        private Item[] wardrobeItems;
        private const int bagItemOffset = 0x1A24;
        private const int toolboxItemOffset = 0x1ED4;
        private const int fridgeItemOffset = 0x4DA8;
        private const int storageItemOffset = 0x7C7C;
        private const int materialItemOffset = 0xAB50;
        private const int wardrobeItemOffset = 0xDA24;
        private const int maxBagItem = 100;
        private const int maxContainerItem = 999;
        private const int maxQuality = 300;

        public bool DataLoaded { get; private set; }
        public bool IsModified { get; private set; }

        public static string[] StarQualityList = { "--", "0", "0.5", "1",
            "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5" };

        public ItemEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            IsModified = false;
            Util.LoadItemNameList();
            LoadItemData();
        }

        private void LoadItemData()
        {
            bagItemColumn.Items.Add("None");
            bagItemColumn.Items.AddRange(Item.ItemNameList);
            bagStarColumn.Items.AddRange(StarQualityList);
            bagItems = displayItem(bagDataGridView, bagItemOffset, maxBagItem);

            toolboxItemColumn.Items.Add("None");
            for (int i = 0; i < Item.MaxItem; i++)
                if (Item.ItemContainer[i] == 0)
                    toolboxItemColumn.Items.Add(Item.ItemNameList[i]);
            toolboxStarColumn.Items.AddRange(StarQualityList);
            toolboxItems = displayItem(toolboxDataGridView, toolboxItemOffset, maxContainerItem);

            fridgeItemColumn.Items.Add("None");
            for (int i = 0; i < Item.MaxItem; i++)
                if (Item.ItemContainer[i] == 1)
                    fridgeItemColumn.Items.Add(Item.ItemNameList[i]);
            fridgeStarColumn.Items.AddRange(StarQualityList);
            fridgeItems = displayItem(fridgeDataGridView, fridgeItemOffset, maxContainerItem);

            storageItemColumn.Items.Add("None");
            for (int i = 0; i < Item.MaxItem; i++)
                if (Item.ItemContainer[i] == 2)
                    storageItemColumn.Items.Add(Item.ItemNameList[i]);
            storageStarColumn.Items.AddRange(StarQualityList);
            storageItems = displayItem(storageDataGridView, storageItemOffset, maxContainerItem);

            materialItemColumn.Items.Add("None");
            for (int i = 0; i < Item.MaxItem; i++)
                if (Item.ItemContainer[i] == 3)
                    materialItemColumn.Items.Add(Item.ItemNameList[i]);
            materialStarColumn.Items.AddRange(StarQualityList);
            materialItems = displayItem(materialDataGridView, materialItemOffset, maxContainerItem);

            wardrobeItemColumn.Items.Add("None");
            for (int i = 0; i < Item.MaxItem; i++)
                if (Item.ItemContainer[i] == 4)
                    wardrobeItemColumn.Items.Add(Item.ItemNameList[i]);
            wardrobeStarColumn.Items.AddRange(StarQualityList);
            wardrobeItems = displayItem(wardrobeDataGridView, wardrobeItemOffset, maxContainerItem);

            DataLoaded = true;
        }

        private Item[] displayItem(DataGridView dataGridView, int offset, int count)
        {
            Item[] items = new Item[count];
            int localOffset = offset;
            for (int i = 0; i < count; i++)
            {
                byte[] itemBytes = new byte[12];
                Array.Copy(MainForm.SaveData, localOffset, itemBytes, 0, 12);
                Item item = new Item(itemBytes);
                items[i] = item;
                localOffset += 12;
            }
            Array.Sort<Item>(items, (x, y) => x.CompareTo(y));
            
            dataGridView.Rows.Add(count);
            for (int i = 0; i < count; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = items[i].GetItemName();
                if (items[i].Quality < 0)
                    dataGridView.Rows[i].Cells[1].Value = StarQualityList[0];
                if (items[i].Quality == 0)
                    dataGridView.Rows[i].Cells[1].Value = StarQualityList[1];
                if (items[i].Quality > 0)
                    dataGridView.Rows[i].Cells[1].Value =
                        StarQualityList[(items[i].Quality - 1) / 30 + 2];
                dataGridView.Rows[i].Cells[2].Value = items[i].Quality;
                dataGridView.Rows[i].Cells[3].Value = items[i].Quantity;
                if (items[i].ItemIndex == 0xFFFF || Item.BaseQuality[items[i].ItemIndex] == -1)
                {
                    dataGridView.Rows[i].Cells[1].ReadOnly = true;
                    dataGridView.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    dataGridView.Rows[i].Cells[2].ReadOnly = true;
                    dataGridView.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
                    dataGridView.Rows[i].Cells[3].ReadOnly = true;
                    dataGridView.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                }
            }
            return items;
        }

        #region CellClick
        private void dataGridView_CellClick(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != 0) && (e.ColumnIndex != 1)) return;
            ComboBox cb = (ComboBox) dataGridView.EditingControl;
            if (cb != null) cb.DroppedDown = true;
        }

        private void bagDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(bagDataGridView, e);
        }

        private void toolboxDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(toolboxDataGridView, e);
        }

        private void fridgeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(fridgeDataGridView, e);
        }

        private void storageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(storageDataGridView, e);
        }

        private void materialDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(materialDataGridView, e);
        }

        private void wardrobeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(wardrobeDataGridView, e);
        }
        #endregion

        #region CurrentCellDirtyStateChanged
        private void bagDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (bagDataGridView.IsCurrentCellDirty &&
                bagDataGridView.CurrentCell.ColumnIndex == 0)
            {
                bagDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void toolboxDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (toolboxDataGridView.IsCurrentCellDirty &&
                toolboxDataGridView.CurrentCell.ColumnIndex == 0)
            {
                toolboxDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void fridgeDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (fridgeDataGridView.IsCurrentCellDirty &&
                fridgeDataGridView.CurrentCell.ColumnIndex == 0)
            {
                fridgeDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void storageDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (storageDataGridView.IsCurrentCellDirty &&
                storageDataGridView.CurrentCell.ColumnIndex == 0)
            {
                storageDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void materialDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (materialDataGridView.IsCurrentCellDirty &&
                materialDataGridView.CurrentCell.ColumnIndex == 0)
            {
                materialDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void wardrobeDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (wardrobeDataGridView.IsCurrentCellDirty &&
                wardrobeDataGridView.CurrentCell.ColumnIndex == 0)
            {
                wardrobeDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        #endregion

        #region CellValueChanged
        private int dataGridView_CellValueChanged(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            if (!IsModified) IsModified = true;
            // Edit item
            if (e.ColumnIndex == 0)
            {
                int itemIndex = Array.IndexOf(Item.ItemNameList,
                    dataGridView.Rows[e.RowIndex].Cells[0].Value);
                // Check if quality value of that item can be edited
                // Check if number of that item can be 99
                // Set default parameters
                // Change ReadOnly property of related cells
                if (itemIndex == -1 || Item.BaseQuality[itemIndex] == -1)
                {
                    dataGridView.Rows[e.RowIndex].Cells[1].Value =
                        StarQualityList[0];
                    dataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = true;
                    dataGridView.Rows[e.RowIndex].Cells[1].Style.BackColor =
                        Color.LightGray;
                    dataGridView.Rows[e.RowIndex].Cells[2].Value = -1;
                    dataGridView.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                    dataGridView.Rows[e.RowIndex].Cells[2].Style.BackColor =
                        Color.LightGray;
                    if (itemIndex == -1)
                        dataGridView.Rows[e.RowIndex].Cells[3].Value = 0;
                    else
                        dataGridView.Rows[e.RowIndex].Cells[3].Value = 1;
                    dataGridView.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                    dataGridView.Rows[e.RowIndex].Cells[3].Style.BackColor =
                        Color.LightGray;
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[1].Value =
                        StarQualityList[(Item.BaseQuality[itemIndex] - 1) / 30 + 1];
                    dataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;
                    dataGridView.Rows[e.RowIndex].Cells[1].Style.BackColor = 
                        dataGridView.DefaultCellStyle.BackColor;
                    dataGridView.Rows[e.RowIndex].Cells[2].Value =
                        Item.BaseQuality[itemIndex];
                    dataGridView.Rows[e.RowIndex].Cells[2].ReadOnly = false;
                    dataGridView.Rows[e.RowIndex].Cells[2].Style.BackColor =
                        dataGridView.DefaultCellStyle.BackColor;
                    dataGridView.Rows[e.RowIndex].Cells[3].Value = 1;
                    dataGridView.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                    dataGridView.Rows[e.RowIndex].Cells[3].Style.BackColor =
                        dataGridView.DefaultCellStyle.BackColor;
                }
                return itemIndex;
            }
            return -2;
        }
        
        private void bagDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            int itemIndex = dataGridView_CellValueChanged(bagDataGridView, e);
            if (itemIndex == -1) bagItems[e.RowIndex] = new Item();
            if (itemIndex > -1)
                bagItems[e.RowIndex] = new Item((ushort)itemIndex);
        }

        private void toolboxDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            int itemIndex = dataGridView_CellValueChanged(toolboxDataGridView, e);
            if (itemIndex == -1) toolboxItems[e.RowIndex] = new Item();
            if (itemIndex > -1)
                toolboxItems[e.RowIndex] = new Item((ushort)itemIndex);
        }

        private void fridgeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            int itemIndex = dataGridView_CellValueChanged(fridgeDataGridView, e);
            if (itemIndex == -1) fridgeItems[e.RowIndex] = new Item();
            if (itemIndex > -1)
                fridgeItems[e.RowIndex] = new Item((ushort)itemIndex);
        }

        private void storageDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            int itemIndex = dataGridView_CellValueChanged(storageDataGridView, e);
            if (itemIndex == -1) storageItems[e.RowIndex] = new Item();
            if (itemIndex > -1)
                storageItems[e.RowIndex] = new Item((ushort)itemIndex);
        }

        private void materialDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            int itemIndex = dataGridView_CellValueChanged(materialDataGridView, e);
            if (itemIndex == -1) materialItems[e.RowIndex] = new Item();
            if (itemIndex > -1)
                materialItems[e.RowIndex] = new Item((ushort)itemIndex);
        }

        private void wardrobeDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataLoaded) return;
            int itemIndex = dataGridView_CellValueChanged(wardrobeDataGridView, e);
            if (itemIndex == -1) wardrobeItems[e.RowIndex] = new Item();
            if (itemIndex > -1)
                wardrobeItems[e.RowIndex] = new Item((ushort)itemIndex);
        }
        #endregion

        #region CellValidating
        private void dataGridView_CellValidating(DataGridView dataGridView, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].IsNewRow) return;
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
                return;
            if (e.ColumnIndex == 2)
            {
                int quality;
                bool isValidQuality = Int32.TryParse(e.FormattedValue.ToString(), out quality);
                if (!isValidQuality || quality < -1 || quality > maxQuality)
                {
                    dataGridView.Rows[e.RowIndex].Cells[2].ErrorText =
                        "Quality value must be a valid number between -1 and 300";
                    dataGridView.CancelEdit();
                }
                else
                    dataGridView.Rows[e.RowIndex].Cells[2].ErrorText = null;
            }
            if (e.ColumnIndex == 3)
            {
                int quantity;
                bool isValidQuantity = Int32.TryParse(e.FormattedValue.ToString(), out quantity);
                if (!isValidQuantity || quantity < 1 || quantity > 99)
                {
                    dataGridView.Rows[e.RowIndex].Cells[3].ErrorText =
                        "Amount must be a valid number between 1 and 99";
                    dataGridView.CancelEdit();
                }
                else
                    dataGridView.Rows[e.RowIndex].Cells[3].ErrorText = null;
            }
        }

        private void bagDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView_CellValidating(bagDataGridView, e);
        }

        private void toolboxDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView_CellValidating(toolboxDataGridView, e);
        }

        private void fridgeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView_CellValidating(fridgeDataGridView, e);
        }

        private void storageDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView_CellValidating(storageDataGridView, e);
        }

        private void materialDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView_CellValidating(materialDataGridView, e);
        }

        private void wardrobeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridView_CellValidating(wardrobeDataGridView, e);
        }
        #endregion

        #region CellEndEdit
        private void dataGridView_CellEndEdit(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            // Edit star quality
            if (e.ColumnIndex == 1)
            {
                string starQuality = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                int starQualityIndex = Array.IndexOf(StarQualityList, starQuality);
                if (starQualityIndex == 0)
                    dataGridView.Rows[e.RowIndex].Cells[2].Value = -1;
                else
                    dataGridView.Rows[e.RowIndex].Cells[2].Value =
                        (starQualityIndex - 1) * 30;
            }
            // Edit true quality value
            if (e.ColumnIndex == 2)
            {
                string qualityInput = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                int quality;
                bool isValidQuality = Int32.TryParse(qualityInput, out quality);
                if (isValidQuality)
                {
                    if (quality > 0)
                        dataGridView.Rows[e.RowIndex].Cells[1].Value =
                            StarQualityList[(quality - 1) / 30 + 2];
                    if (quality == 0)
                        dataGridView.Rows[e.RowIndex].Cells[1].Value = StarQualityList[1];
                    if (quality < 0)
                        dataGridView.Rows[e.RowIndex].Cells[1].Value = StarQualityList[0];
                }
            }
        }

        private void bagDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellEndEdit(bagDataGridView, e);
        }

        private void toolboxDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellEndEdit(toolboxDataGridView, e);
        }

        private void fridgeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellEndEdit(fridgeDataGridView, e);
        }

        private void storageDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellEndEdit(storageDataGridView, e);
        }

        private void materialDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellEndEdit(materialDataGridView, e);
        }

        private void wardrobeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellEndEdit(wardrobeDataGridView, e);
        }
        #endregion

        private void qualityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (qualityCheckBox.Checked)
            {
                bagDataGridView.Columns[1].Visible = false;
                toolboxDataGridView.Columns[1].Visible = false;
                fridgeDataGridView.Columns[1].Visible = false;
                storageDataGridView.Columns[1].Visible = false;
                materialDataGridView.Columns[1].Visible = false;
                wardrobeDataGridView.Columns[1].Visible = false;
                bagDataGridView.Columns[2].Visible = true;
                toolboxDataGridView.Columns[2].Visible = true;
                fridgeDataGridView.Columns[2].Visible = true;
                storageDataGridView.Columns[2].Visible = true;
                materialDataGridView.Columns[2].Visible = true;
                wardrobeDataGridView.Columns[2].Visible = true;
            }
            else
            {
                bagDataGridView.Columns[1].Visible = true;
                toolboxDataGridView.Columns[1].Visible = true;
                fridgeDataGridView.Columns[1].Visible = true;
                storageDataGridView.Columns[1].Visible = true;
                materialDataGridView.Columns[1].Visible = true;
                wardrobeDataGridView.Columns[1].Visible = true;
                bagDataGridView.Columns[2].Visible = false;
                toolboxDataGridView.Columns[2].Visible = false;
                fridgeDataGridView.Columns[2].Visible = false;
                storageDataGridView.Columns[2].Visible = false;
                materialDataGridView.Columns[2].Visible = false;
                wardrobeDataGridView.Columns[2].Visible = false;
            }
        }

        private void saveItems(DataGridView dataGridView, int offset, int count, Item[] items)
        {
            byte[] itemBytes = new byte[12 * count];
            for (int i = 0; i < count; i++)
            {
                //int itemIndex = Array.IndexOf(Item.ItemNameList, dataGridView.Rows[i].Cells[0].Value.ToString());
                short itemQuality;
                bool isValidQuality = Int16.TryParse(dataGridView.Rows[i].Cells[2].Value.ToString(), out itemQuality);
                byte itemQuantity;
                bool isValidQuantity = Byte.TryParse(dataGridView.Rows[i].Cells[3].Value.ToString(), out itemQuantity);
                items[i].Quality = itemQuality;
                items[i].Quantity = itemQuantity;
                Array.Copy(items[i].ToArray(), 0, itemBytes, 12 * i, 12);
            }
            Array.Copy(itemBytes, 0, MainForm.SaveData, offset, 12 * count);
        }

        /// <summary>
        /// Save item changes to save data
        /// </summary>
        public void SaveItems()
        {
            if (IsModified)
            {
                saveItems(bagDataGridView, bagItemOffset, maxBagItem, bagItems);
                saveItems(toolboxDataGridView, toolboxItemOffset, maxContainerItem, toolboxItems);
                saveItems(fridgeDataGridView, fridgeItemOffset, maxContainerItem, fridgeItems);
                saveItems(storageDataGridView, storageItemOffset, maxContainerItem, storageItems);
                saveItems(materialDataGridView, materialItemOffset, maxContainerItem, materialItems);
                saveItems(wardrobeDataGridView, wardrobeItemOffset, maxContainerItem, wardrobeItems);
            }
        }

        private void itemx99Button_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = null;
            Item[] items = null;
            int count = 0;
            if (itemTabControl.SelectedTab == bagTab)
            {
                dataGridView = bagDataGridView;
                items = bagItems;
                count = maxBagItem;
            }
            else
                count = maxContainerItem;
            if (itemTabControl.SelectedTab == toolboxTab)
            {
                dataGridView = toolboxDataGridView;
                items = toolboxItems;
            }
            if (itemTabControl.SelectedTab == fridgeTab)
            {
                dataGridView = fridgeDataGridView;
                items = fridgeItems;
            }
            if (itemTabControl.SelectedTab == storageTab)
            {
                dataGridView = storageDataGridView;
                items = storageItems;
            }
            if (itemTabControl.SelectedTab == materialTab)
            {
                dataGridView = materialDataGridView;
                items = materialItems;
            }
            if (itemTabControl.SelectedTab == wardrobeTab)
            {
                dataGridView = wardrobeDataGridView;
                items = wardrobeItems;
            }
            if (dataGridView != null && items != null)
                for (int i = 0; i < count; i++)
                {
                    //int itemIndex = Array.IndexOf(Item.ItemNameList, dataGridView.Rows[i].Cells[0].Value);
                    int itemIndex = items[i].ItemIndex;
                    if (itemIndex == 0xFFFF) continue;
                    if (Item.BaseQuality[itemIndex] != -1)
                        dataGridView.Rows[i].Cells[3].Value = 99;
                }
        }

        private void maxQualityButton_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = null;
            Item[] items = null;
            int count = 0;
            if (itemTabControl.SelectedTab == bagTab)
            {
                dataGridView = bagDataGridView;
                items = bagItems;
                count = maxBagItem;
            }
            else
                count = maxContainerItem;
            if (itemTabControl.SelectedTab == toolboxTab)
            {
                dataGridView = toolboxDataGridView;
                items = toolboxItems;
            }
            if (itemTabControl.SelectedTab == fridgeTab)
            {
                dataGridView = fridgeDataGridView;
                items = fridgeItems;
            }
            if (itemTabControl.SelectedTab == storageTab)
            {
                dataGridView = storageDataGridView;
                items = storageItems;
            }
            if (itemTabControl.SelectedTab == materialTab)
            {
                dataGridView = materialDataGridView;
                items = materialItems;
            }
            if (itemTabControl.SelectedTab == wardrobeTab)
            {
                dataGridView = wardrobeDataGridView;
                items = wardrobeItems;
            }
            if (dataGridView != null && items != null)
                for (int i = 0; i < count; i++)
                {
                    //int itemIndex = Array.IndexOf(Item.ItemNameList, dataGridView.Rows[i].Cells[0].Value);
                    int itemIndex = items[i].ItemIndex;
                    if (itemIndex == 0xFFFF) continue;
                    if (Item.BaseQuality[itemIndex] != -1)
                    {
                        dataGridView.Rows[i].Cells[1].Value = StarQualityList[11];
                        dataGridView.Rows[i].Cells[2].Value = maxQuality;
                    }
                }
        }

        private void ItemEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
