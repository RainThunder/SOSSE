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
    public partial class VendorEditingForm : Form
    {
        private int vendorOffset = 0x448E8;
        private int currentCountry;
        private ulong currentMoney;
        private uint currentItemQuantity;
        private uint currentCustomerPoint;

        public bool DataLoaded { get; private set; }

        public VendorEditingForm()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            DataLoaded = false;
            Util.LoadShopNameList();

            for (int i = 3; i < 10; i++)
                countryComboBox.Items.Add(ShopEditingForm.ShopNameList[i]);
            countryComboBox.SelectedIndex = 0;
            //Implicitly call countryComboBox_SelectedIndexChanged
        }

        private void displayVendorData(int country)
        {
            DataLoaded = false;
            currentMoney = BitConverter.ToUInt64(MainForm.SaveData,
                vendorOffset + 1616 * country);
            moneyTextBox.Text = currentMoney.ToString();
            currentItemQuantity = BitConverter.ToUInt32(MainForm.SaveData,
                vendorOffset + 1616 * country + 0x8);
            itemTextBox.Text = currentItemQuantity.ToString();
            currentCustomerPoint = BitConverter.ToUInt32(MainForm.SaveData,
                vendorOffset + 1616 * country + 0xC);
            customerPointTextBox.Text = currentCustomerPoint.ToString();
            DataLoaded = true;
        }


        private void saveCurrentVendorData()
        {
            ulong money = UInt64.Parse(moneyTextBox.Text);
            Array.Copy(BitConverter.GetBytes(money), 0, MainForm.SaveData,
                vendorOffset + 1616 * currentCountry, 8);
            int itemQuantity = Int32.Parse(itemTextBox.Text);
            Array.Copy(BitConverter.GetBytes(itemQuantity), 0, MainForm.SaveData,
                vendorOffset + 1616 * currentCountry + 0x8, 4);
            int customerPoint = Int32.Parse(customerPointTextBox.Text);
            Array.Copy(BitConverter.GetBytes(customerPoint), 0, MainForm.SaveData,
                vendorOffset + 1616 * currentCountry + 0xC, 4);
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataLoaded) saveCurrentVendorData();            
            currentCountry = countryComboBox.SelectedIndex;
            displayVendorData(currentCountry);
        }

        private void moneyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!DataLoaded) return;
            ulong money;
            bool isValid = UInt64.TryParse(itemTextBox.Text, out money);
            if (!isValid)
            {
                MessageBox.Show("Invalid number", "Error");
                moneyTextBox.Text = currentMoney.ToString();
            }
        }

        private void itemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!DataLoaded) return;
            uint itemQuantity;
            bool isValid = UInt32.TryParse(itemTextBox.Text, out itemQuantity);
            if (!isValid)
            {
                MessageBox.Show("Invalid number", "Error");
                itemTextBox.Text = currentItemQuantity.ToString();
            }
        }

        private void customerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!DataLoaded) return;
            uint customerPoint;
            bool isValid = UInt32.TryParse(customerPointTextBox.Text, out customerPoint);
            if (!isValid)
            {
                MessageBox.Show("Invalid number", "Error");
                itemTextBox.Text = currentCustomerPoint.ToString();
            }
        }

        private void VendorEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveCurrentVendorData();
        }
    }
}
