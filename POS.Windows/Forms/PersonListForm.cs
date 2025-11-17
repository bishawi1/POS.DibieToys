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
    public partial class PersonListForm : Form
    {
        DataTable moTable = new DataTable();
        private byte personCatId = 0;
        public PersonListForm()
        {
            InitializeComponent();
        }

        public void initForm(PersonCatEnum personCatId)
        {
            this.personCatId = Convert.ToByte(personCatId);
            if (personCatId == PersonCatEnum.Customer)
            {
                this.Text = "فهرس الزبائن";
                tsbtnPersonSales.Visible = true;
            }
            else if (personCatId == PersonCatEnum.Provider)
            {
                this.Text = "فهرس الموردين";
               // tsbtnPersonPurcaheInvoices.Visible = true;
                tsbtnAddSardVoucher.Visible = true;
                tsbtnNewInvoice.Visible = true;
            }
            else if (personCatId == PersonCatEnum.Partner)
            {
                this.Text = "فهرس الشركاء - الساحبين";
                tsbtnAddSardVoucher.Visible = true;
            }
        }
        private async void getData()
        {
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            PersonQueryCriteriaViewModel criteria = new PersonQueryCriteriaViewModel();
            if (!string.IsNullOrEmpty(txtPerson_No.Text.Trim()))
                criteria.PersonNo = txtPerson_No.Text.Trim();
            if (!string.IsNullOrEmpty(txtCity_ID.Text.Trim()))
                criteria.CityId = Convert.ToByte(txtCity_ID.Text);
            if (!string.IsNullOrEmpty(txtCustomer_Name.Text.Trim()))
                criteria.PersonName = txtCustomer_Name.Text.Trim();
            if (personCatId > 0)
            {
                criteria.Person_Cat_ID = Convert.ToByte(personCatId);
            }
            ResultModel result = await CustomerRepository.getCustomerQuery(criteria);
            //CustomerRepository.getCustomerQuery(criteria);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        moTable = General.ConvertToDataTable(result.Data);
                        grdList.AutoGenerateColumns = false;
                        grdList.DataSource = moTable;
                    }
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            CustomerDialog frm = new CustomerDialog();
            frm.initForm(-99, personCatId);
            frm.ShowDialog();
        }

        private void tsbtnDetails_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                CustomerDialog frm = new CustomerDialog();
                frm.initForm(Convert.ToInt16(grdList.Rows[grdList.CurrentRow.Index].Cells[colPerson_ID.Name].Value));
                frm.ShowDialog();

            }
        }
        private void Show_City_ID_LOV()
        {
            CityLOV lov = new CityLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtCity_ID.Text = lov.getSelectedCityId().ToString();
                txtCity_Name.Text = lov.getSelectedCityName();
            }
        }
        private void btnShow_City_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_City_ID_LOV();
        }

        private void txtCity_ID_Validating(object sender, CancelEventArgs e)
        {
            if (txtCity_ID.Text.Trim() != "")
            {
                string name = General.getCityName(Convert.ToByte(txtCity_ID.Text));
                if (name == "")
                {
                    txtCity_Name.Text = "";
                    MessageBox.Show("غير معرف");
                    txtCity_ID.Text = "";
                    txtCity_ID.Focus();
                }
                else
                {
                    txtCity_Name.Text = name;
                }
            }
        }

        private void tsbtnStatement_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                int personId = Convert.ToInt32(grdList.Rows[grdList.CurrentRow.Index].Cells[colPerson_ID.Name].Value);
                string personName = Convert.ToString(grdList.Rows[grdList.CurrentRow.Index].Cells[colPerson_Name.Name].Value);
                StatementOfAccountForm frm = new StatementOfAccountForm();
                frm.initForm(personId, personName);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void txtCity_ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                CustomerDialog frm = new CustomerDialog();
                frm.initForm(Convert.ToInt16(grdList.Rows[grdList.CurrentRow.Index].Cells[colPerson_ID.Name].Value));
                frm.ShowDialog();

            }
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getData();
            }
        }

        private void tsbtnAddSardVoucher_Click(object sender, EventArgs e)
        {
            int personId = 0;
            string personName = string.Empty;
            if (grdList.CurrentRow != null)
            {
                personId = Convert.ToInt32(grdList.CurrentRow.Cells[colPerson_ID.Name].Value);
                personName = Convert.ToString(grdList.CurrentRow.Cells[colPerson_Name.Name].Value);
            }
            VoucherDialog frm = new VoucherDialog();
            if (personCatId == Convert.ToByte(PersonCatEnum.Customer))
            {
                frm.initForm(Convert.ToByte(VoucherTypeEnum.Sarf), -99, true, personCatId, personId, personName);
            }
            else if (personCatId == Convert.ToByte(PersonCatEnum.Provider))
            {
                frm.initForm(Convert.ToByte(VoucherTypeEnum.Sarf), -99, true, personCatId, personId, personName);
            }
            else if (personCatId == Convert.ToByte(PersonCatEnum.Partner))
            {
                frm.initForm(Convert.ToByte(VoucherTypeEnum.Sarf), -99, true, personCatId, personId, personName);
            }

            frm.ShowDialog();
        }

        private void tsbtnPersonSales_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                int personId = Convert.ToInt32(grdList.CurrentRow.Cells[colPerson_ID.Name].Value);
                string personName = Convert.ToString(grdList.CurrentRow.Cells[colPerson_Name.Name].Value);
                OnlineSalesTransactionListForm frm = new OnlineSalesTransactionListForm();
                frm.MdiParent = this.MdiParent;
                frm.initForm(DateTime.MinValue, DateTime.MinValue, 1, personId, personName);
                frm.Show();
            }
        }

        private void tsbtnPersonPurcaheInvoices_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                int personId = Convert.ToInt32(grdList.CurrentRow.Cells[colPerson_ID.Name].Value);
                string personName = Convert.ToString(grdList.CurrentRow.Cells[colPerson_Name.Name].Value);
                PurchaseInvoiceListForm frm = new PurchaseInvoiceListForm();
                frm.MdiParent = this.MdiParent;
                frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.PurchaseInvoice, -1, "", personId, personName);
                frm.Show();
            }
        }

        private void tsbtnNewInvoice_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow != null)
            {
                PurchaseInvoiceDialog frm = new PurchaseInvoiceDialog();
                if (personCatId == (byte)PersonCatEnum.Provider)
                {
                    int personId = Convert.ToInt32(grdList.CurrentRow.Cells[colPerson_ID.Name].Value);
                    string personName = Convert.ToString(grdList.CurrentRow.Cells[colPerson_Name.Name].Value);
                    //int voucherId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colVoucher_ID.Name].Value);
                    frm.initPurchaseInvoice(0, 0, personId, personName);

                }
                frm.ShowDialog();
            }
        }
    }
}
