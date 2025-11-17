using POS.Shared.DTOs;
using POS.Shared.ViewModels;
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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void clearSreen()
        {
            txtCashAvailableAmount.Value = 0;
            txtCashQabdAmount.Value = 0;
            txtCashSarfAmount.Value = 0;
            txtChequeQabdAmount.Value = 0;
            txtChequeSarfAmount.Value = 0;
            txtDebitSalesInvoice.Value = 0;
            txtQabTotalAmount.Value = 0;
            txtSalesInvoiceAmount.Value = 0;
            txtTransfereQabdAmount.Value = 0;
            txtTransfereSarfAmount.Value = 0;
            txtVisaQabdAmount.Value = 0;
            txtVisaSarfAmount.Value = 0;
        }
        private void applySearch()
        {
            clearSreen();
            VoucherQueryCriteriaViewModel criteria = new VoucherQueryCriteriaViewModel();
            List<VoucherTotalViewModel> list = new List<VoucherTotalViewModel>();
            DateTime fromDate = DateTime.MinValue;
            DateTime toDate = DateTime.MinValue;
            if (txtFrom_Trans_Date.Checked)
            {
                fromDate = txtFrom_Trans_Date.Value;
                criteria.FromDate = $"{fromDate.Day}-{fromDate.Month}-{fromDate.Year}";
            }
            if (txtTo_Trans_Date.Checked)
            {
                toDate = txtTo_Trans_Date.Value;
                criteria.ToDate = $"{toDate.Day}-{toDate.Month}-{toDate.Year}"; ;
            }
            criteria.VoucherTypeId = 0;
            ResultModel result = Client.VoucherRepository.getVoucherTotal(criteria);
            if (result.StatusCode == "200")
                list = (List<VoucherTotalViewModel>)result.Data;
            foreach (VoucherTotalViewModel voucher in list)
            {
                if (voucher.voucher_Type_ID == 1)
                {
                    if (voucher.Pay_Way_Id == 1)
                    {
                        txtCashQabdAmount.Value = voucher.Amount;
                    }
                    else if (voucher.Pay_Way_Id == 3)
                    {
                        txtChequeQabdAmount.Value = voucher.Amount;
                    }
                    else if (voucher.Pay_Way_Id == 4)
                    {
                        txtTransfereQabdAmount.Value = voucher.Amount;
                    }
                    else if (voucher.Pay_Way_Id == 5)
                    {
                        txtVisaQabdAmount.Value = voucher.Amount;
                    }
                }
                else if (voucher.voucher_Type_ID == 2)
                {
                    if (voucher.Pay_Way_Id == 1)
                    {
                        txtCashSarfAmount.Value = voucher.Amount;
                    }
                    else if (voucher.Pay_Way_Id == 3)
                    {
                        txtChequeSarfAmount.Value = voucher.Amount;
                    }
                    else if (voucher.Pay_Way_Id == 4)
                    {
                        txtTransfereSarfAmount.Value = voucher.Amount;
                    }
                    else if (voucher.Pay_Way_Id == 5)
                    {
                        txtVisaSarfAmount.Value = voucher.Amount;
                    }

                }
                else if (voucher.voucher_Type_ID == 3)
                {
                    txtSalesInvoiceAmount.Value = voucher.Amount;
                }


            }
            txtQabTotalAmount.Value = txtCashQabdAmount.Value + txtChequeQabdAmount.Value + txtVisaQabdAmount.Value + txtTransfereQabdAmount.Value;
            txtDebitSalesInvoice.Value = txtSalesInvoiceAmount.Value - txtQabTotalAmount.Value;

            txtCashAvailableAmount.Value = txtCashQabdAmount.Value - txtCashSarfAmount.Value;

        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void lblDebtitSalestText_Click(object sender, EventArgs e)
        {

        }

        private void lblDebtitSalestText_DoubleClick(object sender, EventArgs e)
        {
            OnlineSalesTransactionListForm frm = new OnlineSalesTransactionListForm();
            frm.MdiParent = this.MdiParent;
            DateTime fromDate = DateTime.MinValue;
            DateTime toDate = DateTime.MinValue;
            if (txtFrom_Trans_Date.Checked)
            {
                fromDate = txtFrom_Trans_Date.Value;
            }
            if (txtTo_Trans_Date.Checked)
            {
                toDate = txtTo_Trans_Date.Value;
            }
            frm.initForm(fromDate, toDate);
            frm.Show();
        }

        private void lblAllSalesText_Click(object sender, EventArgs e)
        {

        }

        private void lblAllSalesText_DoubleClick(object sender, EventArgs e)
        {
            OnlineSalesTransactionListForm frm = new OnlineSalesTransactionListForm();
            frm.MdiParent = this.MdiParent;
            DateTime fromDate = DateTime.MinValue;
            DateTime toDate = DateTime.MinValue;
            if (txtFrom_Trans_Date.Checked)
            {
                fromDate = txtFrom_Trans_Date.Value;
            }
            if (txtTo_Trans_Date.Checked)
            {
                toDate = txtTo_Trans_Date.Value;
            }
            frm.initForm(fromDate, toDate, 0);
            frm.Show();
        }
        public void initForm()
        {
            cmbPeriod.SelectedIndex = 1;
        }
        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFrom_Trans_Date.Visible = false;
            txtTo_Trans_Date.Visible = false;
            txtFrom_Trans_Date.Checked = true;
            txtTo_Trans_Date.Checked = true;
            lblFrom.Visible = false;
            lblTo.Visible = false;
            btnGetData.Visible = false;
            switch (cmbPeriod.SelectedIndex)
            {
                case 0:
                    txtFrom_Trans_Date.Checked = true;
                    txtTo_Trans_Date.Checked=true;
                    txtFrom_Trans_Date.Value = DateTime.Today;
                    txtTo_Trans_Date.Value=DateTime.Today;
                    applySearch();
                    break;
                case 1:
                    txtFrom_Trans_Date.Checked = true;
                    txtTo_Trans_Date.Checked = true;
                    txtFrom_Trans_Date.Value = DateTime.Today.AddDays(-1);
                    txtTo_Trans_Date.Value = DateTime.Today.AddDays(-1);
                    applySearch();
                    break;
                case 2:
                    txtFrom_Trans_Date.Checked = true;
                    txtTo_Trans_Date.Checked = true;
                    txtFrom_Trans_Date.Value = DateTime.Today.AddDays(-7);
                    txtTo_Trans_Date.Value = DateTime.Today;
                    applySearch();
                    break;
                case 3:
                    txtFrom_Trans_Date.Checked = true;
                    txtTo_Trans_Date.Checked = false;
                    txtFrom_Trans_Date.Value =new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    //txtTo_Trans_Date.Value = DateTime.Today.AddDays(-7);
                    applySearch();
                    break;

                case 4:
                    clearSreen();
                    txtFrom_Trans_Date.Checked = true;
                    txtTo_Trans_Date.Checked = false;
                    txtFrom_Trans_Date.Value = DateTime.Today;
                    txtFrom_Trans_Date.Visible = true;
                    txtTo_Trans_Date.Visible = true;
                    txtTo_Trans_Date.Value = DateTime.Today;
                    lblFrom.Visible = true;
                    lblTo.Visible = true;
                    btnGetData.Visible = true;
                    break;
            }
        }
    }
}
