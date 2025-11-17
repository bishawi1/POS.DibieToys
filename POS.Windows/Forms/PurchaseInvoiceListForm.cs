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
    public partial class PurchaseInvoiceListForm : Form
    {
        public PurchaseInvoiceListForm()
        {
            InitializeComponent();
        }

        public void initForm()
        {

        }

        private void getData()
        {
            DataTable dt = new DataTable();
            PurchaseInvoiceQueryCriteriaViewModel criteria = new PurchaseInvoiceQueryCriteriaViewModel();

            ResultModel result = Client.VoucherRepository.getPurchaseInvoiceQuery(criteria);
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    dt = General.ConvertToDataTable(result.Data);
                    grdList.AutoGenerateColumns = false;
                    grdList.DataSource = dt;
                }
            }
        }
        public void initForm(DateTime dtFromDate, DateTime dtToDate, VoucherTypeEnum TransactionTypeId = VoucherTypeEnum.All, int PayWay = -1, string manualVoucherNo = "", int personId = 0, string personName = "", bool forProvider = false)
        {
            txtPerson_No.Text = personId.ToString();
            lblPerson_Name.Text = personName;


            cmbPay_Way_Id.SelectedIndex = 0;

            if (PayWay >= 0)
            {
                cmbPay_Way_Id.SelectedIndex = PayWay;
            }

            if (dtFromDate != DateTime.MinValue)
            {
                txtFrom_Trans_Date.Checked = true;
                txtFrom_Trans_Date.Value = dtFromDate;
            }
            else
            {
                txtFrom_Trans_Date.Checked = false;
                //txtFrom_Trans_Date.Value = DateTime.Today;
            }
            if (dtToDate != DateTime.MinValue)
            {
                txtTo_Trans_Date.Checked = true;
                txtTo_Trans_Date.Value = dtToDate;
            }
            else
            {
                txtTo_Trans_Date.Checked = false;
                //txtTo_Trans_Date.Value = DateTime.Today;
            }

            getData();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            VoucherDialog frm = new VoucherDialog();
            frm.initForm((byte)VoucherTypeEnum.PurchaseInvoice, -99, true, (byte)PersonCatEnum.Provider);
            frm.ShowDialog();
        }



        private void tsbtnDetails_Click_1(object sender, EventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                int voucherId = Convert.ToInt32(grdList.CurrentRow.Cells[colVoucher_ID.Name].Value);
                VoucherDialog frm = new VoucherDialog();
                frm.initForm((byte)VoucherTypeEnum.PurchaseInvoice, voucherId, true, (byte)PersonCatEnum.Provider);
                frm.ShowDialog();
            }
        }

        private void tsbtnSarfVoucherList_Click(object sender, EventArgs e)
        {
            VoucherListForm frm = new VoucherListForm();
            string manualVoucherNo = Convert.ToString(grdList.CurrentRow.Cells[colVoucher_ID.Name].Value);
            int personId = Convert.ToInt32(grdList.CurrentRow.Cells[colPerson_ID.Name].Value);
            string personName = Convert.ToString(grdList.CurrentRow.Cells[colPerson_Name.Name].Value);

            frm.MdiParent = this.MdiParent;
            frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.Sarf, -1, manualVoucherNo, personId, personName,true);
            frm.Show();
        }
    }
}
