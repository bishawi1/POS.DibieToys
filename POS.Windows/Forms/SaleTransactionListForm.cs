using POS.Client;
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
    public partial class SaleTransactionListForm : Form
    {
        public SaleTransactionListForm()
        {
            InitializeComponent();
        }
        private SalesQueryCriteriaViewModel retCriteria()
        {
            SalesQueryCriteriaViewModel criteria = new SalesQueryCriteriaViewModel();
            if (txtFrom_Date.Checked)
            {
                criteria.From_Transaction_Date = $"{txtFrom_Date.Value.Day}-{txtFrom_Date.Value.Month}-{txtFrom_Date.Value.Year}";
            }
            if (txtTo_Date.Checked)
            {
                criteria.To_Transaction_Date = $"{txtTo_Date.Value.Day}-{txtTo_Date.Value.Month}-{txtTo_Date.Value.Year}";
            }
            if (txtFrom_Voucher_Amount.Value > 0)
            {
                criteria.From_Amount = txtFrom_Voucher_Amount.Value;
            }
            if (txtTo_Voucher_Amount.Value > 0)
            {
                criteria.To_Amount = txtTo_Voucher_Amount.Value;
            }
            return criteria;
        }
        public async void applySearch()
        {
            SaleTransactionRepository repository = new SaleTransactionRepository();
            ResultModel result = await SaleTransactionRepository.getAll(retCriteria());
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    DataTable dt = General.ConvertToDataTable(result.Data);
                    grdSalesList.AutoGenerateColumns = false;
                    grdSalesList.DataSource = dt;
                    txtItemCount.Text = dt.Rows.Count.ToString();
                }
            }
        }
        public void initForm()
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
