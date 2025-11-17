using POS.Shared;
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
    public partial class DebitSalesTransactionListForm : Form
    {
        DataTable moDataTable;
        private byte mintTransactionTypeId = 0;


        public DebitSalesTransactionListForm()
        {
            InitializeComponent();
        }
        private void fillSummary()
        {
            decimal amount = 0;
            foreach (DataRow row in moDataTable.Rows)
            {
                amount += Convert.ToDecimal((row[colAmount.DataPropertyName]));
            }
            lblTotalAmount.Text = amount.ToString("###,##0.0");
        }
        private async Task getData()
        {
            SalesQueryCriteriaViewModel criteria = new SalesQueryCriteriaViewModel();
            if (txtFrom_Trans_Date.Checked == true)
                criteria.From_Transaction_Date = $"{txtFrom_Trans_Date.Value.Day}-{txtFrom_Trans_Date.Value.Month}-{txtFrom_Trans_Date.Value.Year}";
            if (txtTo_Trans_Date.Checked == true)
                criteria.To_Transaction_Date = $"{txtTo_Trans_Date.Value.Day}-{txtTo_Trans_Date.Value.Month}-{txtTo_Trans_Date.Value.Year}";

            criteria.PayStatusId = Convert.ToByte(cmbPayStatusId.SelectedIndex);
            criteria.DebitSalesOnly=true;
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
        public void initForm(DateTime dtFromDate, DateTime dtToDate, VoucherTypeEnum TransactionTypeId = VoucherTypeEnum.BackSalesTransaction)
        {
            mintTransactionTypeId = Convert.ToByte(TransactionTypeId);
            cmbPayStatusId.SelectedIndex = 1;
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
            //getData();
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void tsbtnDetails_Click(object sender, EventArgs e)
        {
            if (grdVoucherList.CurrentRow != null)
            {
                //int voucherId = Convert.ToInt32(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colVoucher_ID.Name].Value);
                //byte VoucherTypeId = Convert.ToByte(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colvoucher_Type_ID.Name].Value);
                //VoucherDialog frm = new VoucherDialog();
                //frm.initForm(VoucherTypeId, voucherId);
                //frm.ShowDialog();
            }
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            VoucherDialog frm = new VoucherDialog();
            int saleTransactionId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colSale_Transaction_ID.Name].Value);
            decimal amount = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colRemainAmount.Name].Value);
            int personId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colCustomer_ID.Name].Value);
            string personName = Convert.ToString(grdVoucherList.CurrentRow.Cells[colCustomer_Name.Name].Value);

            // frm.initForm(Convert.ToByte(ShowVoucherTypeEnum.Qabd), -99, true,Convert.ToByte(PersonCatEnum.Customer),Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colCustomer_ID.Name].Value), Convert.ToString(grdVoucherList.CurrentRow.Cells[colCustomer_Name.Name].Value));
            frm.initQabd(saleTransactionId, amount, personId, personName);
            frm.ShowDialog();
        }

        private void tsbtnAddForProvider_Click(object sender, EventArgs e)
        {
            VoucherListForm frm = new VoucherListForm();
            string manualVoucherNo = Convert.ToString(grdVoucherList.CurrentRow.Cells[colSale_Transaction_ID.Name].Value);
            frm.MdiParent = this.MdiParent;
            frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.Qabd, -1, manualVoucherNo);
            frm.Show();
        }
    }
}
