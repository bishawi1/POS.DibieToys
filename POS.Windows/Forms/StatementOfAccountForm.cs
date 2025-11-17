using POS.Client;
using POS.DAL.Repositories;
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
    public partial class StatementOfAccountForm : Form
    {
        DataTable moDataTable;

        public StatementOfAccountForm()
        {
            InitializeComponent();
        }

        private void getData()
        {
            PersonStatementOfAccountCriteriaViewModel criteria = new PersonStatementOfAccountCriteriaViewModel();
            if (txtFrom_Trans_Date.Checked)
                criteria.FromDate = $"{txtFrom_Trans_Date.Value.Day}-{txtFrom_Trans_Date.Value.Month}-{txtFrom_Trans_Date.Value.Year}";
            if (txtTo_Trans_Date.Checked)
                criteria.ToDate = $"{txtTo_Trans_Date.Value.Day}-{txtTo_Trans_Date.Value.Month}-{txtTo_Trans_Date.Value.Year}";
            if (!string.IsNullOrEmpty(txtPerson_No.Text.Trim()))
                criteria.PersonId = Convert.ToInt16(txtPerson_No.Text);
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = CustomerRepository.getFinanceStatement(criteria);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        moDataTable = General.ConvertToDataTable(result.Data);
                        grdVoucherList.AutoGenerateColumns = false;
                        grdVoucherList.DataSource = moDataTable;
                    }
        }
        public void initForm()
        {

        }
        public void initForm(int personId, string personName)
        {
            txtPerson_No.Text = personId.ToString();
            lblPerson_Name.Text = personName;
            getData();
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void Show_Person_ID_LOV()
        {
            CustomerLov lov = new CustomerLov();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtPerson_No.Text = lov.getSelectedCustomerId().ToString();
                lblPerson_Name.Text = lov.getSelectedCustomerName();
            }

        }
        private void btnShow_Person_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Person_ID_LOV();
        }

        private void tsbtnShow_TransactionDetails_Click(object sender, EventArgs e)
        {
            int voucherId = 0;
            if (grdVoucherList.CurrentRow != null)
            {
                switch(Convert.ToByte(grdVoucherList.CurrentRow.Cells[colvoucher_Type_ID.Name].Value))
                {
                    case (byte) VoucherTypeEnum.PurchaseInvoice:
                        PurchaseInvoiceDialog frm = new PurchaseInvoiceDialog();
                        voucherId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colVoucher_ID.Name].Value);
                        frm.initForm((byte)VoucherTypeEnum.PurchaseInvoice,voucherId,true,(byte)PersonCatEnum.Provider,0,"");
                        frm.ShowDialog();
                        break;
                    case (byte)VoucherTypeEnum.Sarf:
                        voucherId = Convert.ToInt32(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colVoucher_ID.Name].Value);
                        byte VoucherTypeId = Convert.ToByte(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colvoucher_Type_ID.Name].Value);
                        VoucherDialog sarf = new VoucherDialog();
                        sarf.initForm(VoucherTypeId, voucherId);
                        sarf.ShowDialog();
                        break;
                }
                ;
                   
                    
            }
        }
    }
}
