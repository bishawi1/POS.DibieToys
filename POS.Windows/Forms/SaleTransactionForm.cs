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

namespace POS.Windows.Forms
{
    public partial class SaleTransactionForm : Form
    {
        private int saleTransactionId = 0;
        public SaleTransactionForm()
        {
            InitializeComponent();
        }
        private void showData(List<vInvoiceReportModel> invoiceList)
        {
            DataTable dt = General.ConvertToDataTable(invoiceList);
            vInvoiceReportModel invoice = invoiceList[0];
            txtTotal_Amount.Value= (decimal)invoice.Total_Amount;
            txtCustomerId.Text = invoice.Customer_ID.ToString();
            lblCustomerName.Text = invoice.Customer_Name;
            txtTransactionDate.Value= invoice.Transaction_Date;
            txtDelevery_Fees.Value= (decimal)invoice.Delevery_Fees;
            txtDelevery_Place.Text= invoice.Delevery_Place;
            txtDelevery_Transaction_No.Text = invoice.Delevery_Transaction_No;
            txtDiscount_Amount.Value=invoice.Discount_Amount;
            txtPaidAmountSum.Value = (decimal)invoice.PaidAmountSum;
            txtRemainAmount.Value=invoice.RemainAmount;
            grdItems.AutoGenerateColumns = false;
            grdItems.DataSource = dt;
        }
        private async Task applySearch()
        {
            try
            {
                ResultModel result = await Client.SaleTransactionRepository.getInvoiceReportData(new Shared.ViewModels.InvoiceReportCriteriaViewModel()
                {
                    Sale_Transaction_ID = saleTransactionId
                });
                if (result != null)
                {
                    if (result.Data != null)
                    {
                        List<vInvoiceReportModel> invoice = (List<vInvoiceReportModel>)result.Data;
                        showData(invoice);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        public void initForm(int saleTransactionId)
        {
            this.saleTransactionId = saleTransactionId;
            applySearch();
        }
    }
}
