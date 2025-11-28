using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using POS.Client;
using POS.Shared;
using POS.Shared.DTOs;
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
    public partial class OnlineSalesTransactionListForm : Form
    {
        DataTable moDataTable;
        private byte mintTransactionTypeId = 0;

        public OnlineSalesTransactionListForm()
        {
            InitializeComponent();
        }
        private void fillSummary()
        {
            decimal amount = 0;
            decimal remainAmount = 0;
            foreach (DataRow row in moDataTable.Rows)
            {
                amount += Convert.ToDecimal((row[colAmount.DataPropertyName]));
                remainAmount += Convert.ToDecimal((row[colRemainAmount.DataPropertyName]));
            }
            lblTotalAmount.Text = amount.ToString("###,##0.0");
            lblRemainAmount.Text = remainAmount.ToString("###,##0.0");
        }
        private async Task getData()
        {
            SalesQueryCriteriaViewModel criteria = new SalesQueryCriteriaViewModel();
            criteria.BranchId = Convert.ToByte(cmbBranch.SelectedValue);
            if (txtFrom_Trans_Date.Checked == true)
                criteria.From_Transaction_Date = $"{txtFrom_Trans_Date.Value.Day}-{txtFrom_Trans_Date.Value.Month}-{txtFrom_Trans_Date.Value.Year}";
            if (txtTo_Trans_Date.Checked == true)
                criteria.To_Transaction_Date = $"{txtTo_Trans_Date.Value.Day}-{txtTo_Trans_Date.Value.Month}-{txtTo_Trans_Date.Value.Year}";
            if (cmbSalesType.SelectedIndex > 0)
            {
                if(cmbSalesType.SelectedIndex==2)
                    criteria.DebitSalesOnly = true ;


                if(!string.IsNullOrEmpty(txtPerson_No.Text))
                    criteria.Sales_Person_ID = Convert.ToInt16(txtPerson_No.Text);
            }
            criteria.PayStatusId = Convert.ToByte(cmbPayStatusId.SelectedIndex);
            criteria.DebitSalesOnly = false;

            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = await Client.SaleTransactionRepository.getAll(criteria);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        moDataTable = General.ConvertToDataTable(result.Data);
                        grdVoucherList.AutoGenerateColumns = false;
                        grdVoucherList.DataSource = moDataTable;
                    }
            fillSummary();
        }

        public void initForm(DateTime dtFromDate, DateTime dtToDate,int payStateId=1, int personId=0, string personName="")
        {
            cmbBranch.ValueMember = "Branch_ID";
            cmbBranch.DisplayMember = "Branch_Name";
            cmbBranch.DataSource = General.BranchesDatatable;
            cmbBranch.SelectedIndex = 0;
            mintTransactionTypeId = Convert.ToByte(VoucherTypeEnum.All);
            cmbPayStatusId.SelectedIndex = payStateId;
            cmbSalesType.SelectedIndex = 0;
            if (dtFromDate != DateTime.MinValue)
            {
                txtFrom_Trans_Date.Checked = true;
                txtFrom_Trans_Date.Value = dtFromDate;
            }
            else
            {
                txtFrom_Trans_Date.Checked = false;
            }
            if (dtToDate != DateTime.MinValue)
            {
                txtTo_Trans_Date.Checked = true;
                txtTo_Trans_Date.Value = dtToDate;
            }
            else
            {
                txtTo_Trans_Date.Checked = false;
            }
            if (personId > 0)
            {
                txtPerson_No.Text = personId.ToString();
                lblPerson_Name.Text = personName;
                if(personId == 1)
                {
                    cmbSalesType.SelectedIndex = 3;
                }
                else if (personId== 2) // 
                {
                    cmbSalesType.SelectedIndex = 1;
                }
                else
                {
                    cmbSalesType.SelectedIndex = 2;
                }
                    
            }
            getData();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void tsbtnDetails_Click(object sender, EventArgs e)
        {
            if (grdVoucherList.CurrentRow != null)
            {
                SaleTransactionForm frm = new SaleTransactionForm();
                frm.MdiParent = this.MdiParent;
                frm.initForm(Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colSale_Transaction_ID.Name].Value));
                frm.Show();

                //int voucherId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colVoucher_ID.Name].Value);
                //byte VoucherTypeId = Convert.ToByte(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colvoucher_Type_ID.Name].Value);
                //VoucherDialog frm = new VoucherDialog();
                //frm.initForm(VoucherTypeId, voucherId);
                //frm.ShowDialog();
            }
        }

        private void OnlineSalesTransactionListForm_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            if(grdVoucherList.CurrentRow!= null)
            {
                VoucherDialog frm = new VoucherDialog();
                int saleTransactionId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colSale_Transaction_ID.Name].Value);
                decimal amount = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colRemainAmount.Name].Value);
                int personId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colCustomer_ID.Name].Value);
                string personName = Convert.ToString(grdVoucherList.CurrentRow.Cells[colCustomer_Name.Name].Value);

                // frm.initForm(Convert.ToByte(ShowVoucherTypeEnum.Qabd), -99, true,Convert.ToByte(PersonCatEnum.Customer),Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colCustomer_ID.Name].Value), Convert.ToString(grdVoucherList.CurrentRow.Cells[colCustomer_Name.Name].Value));
                frm.initQabd( saleTransactionId, amount, personId, personName);
                frm.ShowDialog();
            }
        }

        private void tsbtnAddForProvider_Click(object sender, EventArgs e)
        {
            if (grdVoucherList.CurrentRow != null)
            {
                VoucherListForm frm = new VoucherListForm();
                string manualVoucherNo = Convert.ToString(grdVoucherList.CurrentRow.Cells[colSale_Transaction_ID.Name].Value);
                int personId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colCustomer_ID.Name].Value);
                string personName = Convert.ToString(grdVoucherList.CurrentRow.Cells[colCustomer_Name.Name].Value);

                frm.MdiParent = this.MdiParent;
                frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.Qabd, -1, manualVoucherNo,personId,personName);
                frm.Show();
           }
        }

        private void cmbSalesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPerson.Visible = false;
            lblPerson_Name.Visible = false;
            txtPerson_No.Visible = false;
            btnShow_Person_ID_LOV.Visible = false;

            if (cmbSalesType.SelectedIndex == 0)
            {
                colCustomer_Name.Visible = true;
                txtPerson_No.Text = string.Empty;
                cmbPayStatusId.SelectedIndex = 0;
            }
            else if (cmbSalesType.SelectedIndex == 1)
            {
                txtPerson_No.Text = "2";
                colCustomer_Name.Visible = false;
                cmbPayStatusId.SelectedIndex = 1;
            } 
            else if (cmbSalesType.SelectedIndex == 2)
            {
                lblPerson.Visible = true;
                lblPerson_Name.Visible = true;
                txtPerson_No.Visible = true;
                btnShow_Person_ID_LOV.Visible = true;
                colCustomer_Name.Visible = true;
                cmbPayStatusId.SelectedIndex = 1;
                txtPerson_No.Text = string.Empty;
                //txtPerson_No.Text = string.Empty;
            }
            else if (cmbSalesType.SelectedIndex == 3)
            {
                txtPerson_No.Text = "1";
                colCustomer_Name.Visible = false;
                cmbPayStatusId.SelectedIndex = 2;
            }
        }
    }
}
