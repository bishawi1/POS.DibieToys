using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Windows.LOVs;
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
    public partial class ItemGroupDialog : Form
    {
        public bool mboolNewRecord = true;
        public bool mboolAccepted = false;
        public int LastAddedItemGroupId = 0;
        public string LastAddedItemGroupDesc = string.Empty;
        public int mintItemGroupId = -99;
        private Item_GroupModel model = null;

        public ItemGroupDialog()
        {
            InitializeComponent();
        }
        public short getItemGroupId()
        {
            return Convert.ToInt16(txtItem_Group_ID.Text);
        }
        public string getItemGroupName()
        {
            return txtItem_Group_Desc.Text;
        }
        public bool validateForm()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(txtItem_Group_Desc.Text.Trim()))
            {
                valid = false;
                MessageBox.Show("يرجى تحديد الوصف");
                txtItem_Group_Desc.Focus();
            }
            else if (string.IsNullOrEmpty(txtParent_Item_Group_ID.Text.Trim())) 
            {
                valid |= false;
                MessageBox.Show("يرجى تحديد الفئة الاعلى (يتبع تـ)");
                txtParent_Item_Group_ID.Focus();
            }

                return valid;
        }
        public bool addItemGroup()
        {
            bool saved = false;
            AddItemGroupRequestDto request = new AddItemGroupRequestDto()
            {
                Item_Group_Desc = txtItem_Group_Desc.Text.Trim(),
                Item_Group_Notes = txtItem_Group_Notes.Text,
                Leaf_Item_Group = true,
                Parent_Item_Group_ID = Convert.ToInt16(string.IsNullOrEmpty(txtParent_Item_Group_ID.Text.Trim()) ? 0 : txtParent_Item_Group_ID.Text.Trim())
            };
            ResultModel result = ItemGroupRepository.addItemGroup(request);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        Item_GroupModel itemBrand = (Item_GroupModel)result.Data;
                        txtItem_Group_ID.Text = itemBrand.Item_Group_ID.ToString();
                        LastAddedItemGroupId = itemBrand.Item_Group_ID;
                        LastAddedItemGroupDesc = itemBrand.Item_Group_Desc;
                        saved = true;
                        return saved;
                    }
            return saved;
        }
        private bool editItemGroup()
        {

            bool saved = false;
            UpdateItemGroupRequestDto modifyModel = new UpdateItemGroupRequestDto()
            {
                Item_Group_ID = Convert.ToInt16(txtItem_Group_ID.Text.Trim()),
                Item_Group_No = txtItem_Group_ID.Text.Trim(),
                Item_Group_Desc = txtItem_Group_Desc.Text.Trim(),
                Item_Group_Notes = txtItem_Group_Notes.Text,
                Leaf_Item_Group = true,
                Parent_Item_Group_ID = Convert.ToInt16(txtParent_Item_Group_ID.Text)
            };
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = ItemGroupRepository.editItemGroup(modifyModel, model.Item_Group_ID);
            if (result != null)
            {
                if (result.StatusCode == "200")
                    saved = true;
            }
            return saved;
        }
        public void showData()
        {
            txtItem_Group_ID.Text = model.Item_Group_ID.ToString();
            txtItem_Group_Desc.Text = model.Item_Group_Desc;
            txtItem_Group_Notes.Text = model.Item_Group_Notes;
            txtParent_Item_Group_ID.Text = model.Parent_Item_Group_ID.ToString();
            txtParent_Item_Group_Desc.Text = model.Item_Group_Desc;
        }
        public bool saveForm()
        {
            bool saved = false;
            if (mboolNewRecord)
            {
                saved = addItemGroup();
            }
            else
            {
                saved = editItemGroup();
            }
            return saved;
        }
        private async void getData()
        {
            ResultModel result = await ItemBrandRepository.getItemBrand(Convert.ToInt16(mintItemGroupId));
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    if (result.Data != null)
                    {
                        model = (Item_GroupModel)result.Data;
                        showData();
                    }
                }
            }
        }
        public void initForm(int itemGroupId = -99)
        {

            mintItemGroupId = itemGroupId;
            if (itemGroupId < 0)
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

        private void Show_Parent_Item_Group_ID_LOV()
        {
            ItemGroupLOV lov = new ItemGroupLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtParent_Item_Group_ID.Text = lov.getSelectedItemGroupID().ToString();
                txtParent_Item_Group_Desc.Text = lov.getSelectedItemGroupDesc();
                txtItem_Group_Notes.Focus();
            }
        }
        private void btnShow_Parent_Item_Group_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Parent_Item_Group_ID_LOV();
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

        private void txtParent_Item_Group_ID_Enter(object sender, EventArgs e)
        {
            Show_Parent_Item_Group_ID_LOV();
        }
    }
}
