using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
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

namespace POS.Windows.Forms
{
    public partial class SupplyItemListForm : Form
    {
        public SupplyItemListForm()
        {
            InitializeComponent();
        }
        private async void applySearch()
        {
            vSupplyTransactionCriteriaViewModel criteria = new vSupplyTransactionCriteriaViewModel();
            //if (cmbBranch_ID.SelectedValue > 0)
            //{
            //    criteria.br
            //}
            if (!string.IsNullOrEmpty(txtQNT.Text.Trim()))
            {
                criteria.QNT = Convert.ToInt32(txtQNT.Text);
            }
            if (txtFrom_Transaction_Date.Checked)
            {
                criteria.FromTransaction_Date = $"{txtFrom_Transaction_Date.Value.Day}-{txtFrom_Transaction_Date.Value.Month}-{txtFrom_Transaction_Date.Value.Year}";
            }
            if (txtTo_Transaction_Date.Checked)
            {
                criteria.ToTransaction_Date = $"{txtTo_Transaction_Date.Value.Day}-{txtTo_Transaction_Date.Value.Month}-{txtTo_Transaction_Date.Value.Year}";
            }
            if (!string.IsNullOrEmpty(txtItem_Unit_ID.Text.Trim()))
            {
                criteria.Item_Unit_ID = Convert.ToInt32(txtItem_Unit_ID.Text.Trim());
            }
            if (!string.IsNullOrEmpty(txtSource_ID.Text.Trim()))
            {
                criteria.Source_ID = Convert.ToInt16(txtSource_ID.Text.Trim());
            }
            ResultModel result = await Client.SupplyTransactionRepository.getAll(criteria);
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    DataTable dt = General.ConvertToDataTable(result.Data);
                    grdTransactionList.AutoGenerateColumns = false;
                    grdTransactionList.DataSource = dt;
                }
            }
        }
        private void initBranch()
        {
            cmbBranch_ID.ValueMember = "Branch_ID";
            cmbBranch_ID.DisplayMember = "Branch_Name";
            cmbBranch_ID.DataSource = General.BranchesDatatable;
            cmbBranch_ID.SelectedIndex = 0;
        }
        public void initForm()
        {
            initBranch();
            txtSupply_Transaction_ID.Text = string.Empty;
            txtQNT.Text = string.Empty;
            txtSource_ID.Text = string.Empty;
            txtItem_Unit_ID.Text = string.Empty;
        }
        public void initForm(byte branchId)
        {
            initBranch();
            cmbBranch_ID.SelectedValue = branchId;
            txtSupply_Transaction_ID.Text = string.Empty;
            txtQNT.Text = string.Empty;
            txtSource_ID.Text = string.Empty;
            txtItem_Unit_ID.Text = string.Empty;
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void tsbtnDetails_Click(object sender, EventArgs e)
        {
            if (grdTransactionList.CurrentRow != null)
            {
                int supplyTransactionId = Convert.ToInt32(grdTransactionList.CurrentRow.Cells[colSupply_Transaction_ID.Name].Value);
                SupplyTransactionDialog frm = new SupplyTransactionDialog();
                frm.initForm(supplyTransactionId);
                frm.ShowDialog();
            }
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            SupplyTransactionBranchDialog frm = new SupplyTransactionBranchDialog();
            //SupplyTransactionDialog frm = new SupplyTransactionDialog();
            frm.initForm(Convert.ToByte(cmbBranch_ID.SelectedValue));
            frm.ShowDialog();
        }
        private void Show_Source_ID_LOV()
        {
            SourceLOV lov = new SourceLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtSource_ID.Text = lov.getSelectedBookSourceId().ToString();
                txtSource_Name.Text = lov.getSelectedBookSourceDesc();
                //getInvoice();
                General.Show_Wait_Form(Constants.mstrWaitingMessage);
                General.LoadSources();
                txtItem_Unit_ID.Focus();
            }
        }
        private void btnShow_Book_Source_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Source_ID_LOV();
        }

        private void btnShow_Item_Unit_ID_LOV_Click(object sender, EventArgs e)
        {
            SearchForItemDialog frm = new SearchForItemDialog();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                txtItem_Unit_ID.Text = frm.getSelectedItemUnitId().ToString();
                txtItem_Desc.Text = frm.getSelectedItemName();
            }
        }
    }
}
