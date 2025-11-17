using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms.Lookups
{
    public partial class ItemBrandDialog : Form
    {
        public bool mboolNewRecord = true;
        public bool mboolAccepted = false;
        public int LastAddedItemBrandId = 0;
        public string LastAddedItemBrandName = string.Empty;
        public int mintItemBrandId = -99;
        private Item_BrandModel model = null;

        public ItemBrandDialog()
        {
            InitializeComponent();
        }
        public short getItemBrandId()
        {
            return Convert.ToInt16(txtItem_Brand_ID.Text);
        }
        public string getItemBrandName()
        {
            return txtItem_Brand_Name.Text;
        }
        public bool validateForm()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(txtItem_Brand_Name.Text.Trim()))
            {
                valid = false;
                MessageBox.Show("يرجى تحديد الوصف");
                txtItem_Brand_Name.Focus();
            }
            return valid;
        }
        public bool addItemBrand()
        {
            bool saved = false;
            AddItemBrandRequestDto request = new AddItemBrandRequestDto()
            {
                Item_Brand_Name = txtItem_Brand_Name.Text.Trim(),
            };
            ResultModel result = ItemBrandRepository.addItemBrand(request);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        Item_BrandModel itemBrand = (Item_BrandModel)result.Data;
                        txtItem_Brand_ID.Text = itemBrand.Item_Brand_ID.ToString();
                        LastAddedItemBrandId = itemBrand.Item_Brand_ID;
                        LastAddedItemBrandName = itemBrand.Item_Brand_Name;
                        saved = true;
                        return saved;
                    }
            return saved;
        }
        private bool editItemBrand()
        {

            bool saved = false;
            UpdateItemBrandRequestDto modifyModel = new UpdateItemBrandRequestDto()
            {
                Item_Brand_ID = Convert.ToInt32(txtItem_Brand_ID.Text.Trim()),
                Item_Brand_Name = txtItem_Brand_Name.Text.Trim(),
            };
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = ItemBrandRepository.editItemBrand(modifyModel, model.Item_Brand_ID);
            if (result != null)
            {
                if (result.StatusCode == "200")
                    saved = true;
            }
            return saved;
        }
        public void showData()
        {
            txtItem_Brand_ID.Text = model.Item_Brand_ID.ToString();
            txtItem_Brand_Name.Text = model.Item_Brand_Name;
        }
        public bool saveForm()
        {
            bool saved = false;
            if (mboolNewRecord)
            {
                saved = addItemBrand();
            }
            else
            {
                saved = editItemBrand();
            }
            return saved;
        }
        private async void getData()
        {
            ResultModel result = await ItemBrandRepository.getItemBrand(Convert.ToInt16(mintItemBrandId));
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    if (result.Data != null)
                    {
                        model = (Item_BrandModel)result.Data;
                        showData();
                    }
                }
            }
        }
        public void initForm(int itemBrandId = -99)
        {

            mintItemBrandId = itemBrandId;
            if (itemBrandId < 0)
            {
                mboolNewRecord = true;
            }
            else
            {
                mboolNewRecord = false;
                getData();
            }
            ;

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (saveForm())
            {
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }
    }
}
