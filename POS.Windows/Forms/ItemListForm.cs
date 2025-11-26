using POS.Client;
using POS.DAL.Repositories;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.Forms;
using POS.Windows.LOVs;
using POS.Windows.Services.Repository;
using POS.Windows.Services.Repository.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public partial class ItemListForm : Form
    {
        private void initBranch()
        {
            cmbBranch_ID.ValueMember = "Branch_ID";
            cmbBranch_ID.DisplayMember = "Branch_Name";
            cmbBranch_ID.DataSource = General.BranchesDatatable;
            cmbBranch_ID.SelectedIndex = 0;
        }
        public void InitForm()
        {
            initBranch();
        }
        public ItemListForm()
        {
            InitializeComponent();
            General.initMyControls(this);
        }
        private async Task applySearch()
        {
            //ItemListCriteriaViewModel criteria = new ItemListCriteriaViewModel();
            Branch_ItemListCriteriaViewModel criteria = new Branch_ItemListCriteriaViewModel();
            if(txtItemId.Value>0)
                criteria.Item_ID= Convert.ToInt32(txtItemId.Value);
            if (!string.IsNullOrEmpty(txtBarcode.Text))
                criteria.Barcode = txtBarcode.Text.Trim();
            if (!string.IsNullOrEmpty(txtItem_Desc.Text.Trim()))
                criteria.Item_Desc = txtItem_Desc.Text.Trim();
            if (!string.IsNullOrEmpty(txtItem_Group_ID.Text))
                criteria.Item_Group_ID = Convert.ToInt32(txtItem_Group_ID.Text);
            if(Convert.ToByte(cmbBranch_ID.SelectedValue) != 0)
            {
                criteria.Branch_ID = Convert.ToByte(cmbBranch_ID.SelectedValue);
            }
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = await POS.Client.ItemQueryRepository.getAll(criteria);
            if (result.StatusCode == "200")
            {
                DataTable dt = General.ConvertToDataTable(result.Data);
                grdItems.AutoGenerateColumns = false;
                grdItems.DataSource = dt;
                txtItemCount.Text = grdItems.RowCount.ToString();
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }
        private async void btnGetData_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void tsbtnNew_Item_Click(object sender, EventArgs e)
        {
            ItemDialog frm = new ItemDialog();
            frm.InitForm();
            frm.ShowDialog();
            if (frm.GetAccepted())
            {
                applySearch();
            }
        }
        private void showDetails()
        {
            if (grdItems.CurrentRow != null)
            {
                ItemDialog frm = new ItemDialog();
                frm.InitForm(Convert.ToInt32(grdItems.CurrentRow.Cells[colItem_ID.Name].Value));
                frm.ShowDialog();
                if (frm.GetAccepted())
                {
                    applySearch();
                }
            }
        }
        private void tsbtnShowItemDetails_Click(object sender, EventArgs e)
        {
            showDetails();
        }

        private void Show_Item_Group_ID_LOV()
        {
            ItemGroupLOV lov = new ItemGroupLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtItem_Group_ID.Text = lov.getSelectedItemGroupID().ToString();
                txtItem_Group_Desc.Text = lov.getSelectedItemGroupDesc();
                txtItem_Group_ID.Focus();
            }
        }

        private async void btnShow_Item_Group_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Item_Group_ID_LOV();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //    applySearch();
        }

        private void grdItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showDetails();
        }

        private void ItemListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                applySearch();
            }
        }

        private void tsbtnItemStockDetails_Click(object sender, EventArgs e)
        {
            if (grdItems.CurrentRow != null)
            {
                int itemUnitId = Convert.ToInt32(grdItems.CurrentRow.Cells[colItem_Unit_ID.Name].Value);
                ItemUnitStockDetailsForm frm = new ItemUnitStockDetailsForm();
                frm.initForm(itemUnitId);
                frm.ShowDialog();
            }
        }

        private void tsbtnBeginingQnt_Click(object sender, EventArgs e)
        {
            if (grdItems.CurrentRow != null)
            {
                ItemUnitBeginQntDialog frm = new ItemUnitBeginQntDialog();
                frm.MdiParent = this.MdiParent;
                frm.initForm(Convert.ToString(grdItems.CurrentRow.Cells[colBarcode.Name].Value));
                frm.Show();
            }
        }
    }
}
