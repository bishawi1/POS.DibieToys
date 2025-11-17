
using Bookshop.TestClient;
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
using System.Transactions;
using System.Windows.Forms;

namespace POS.Windows.Forms
{
    public enum ShowPayWayEnum
    {
        Not_Applyed = 0,
        Cash = 1,
        Cheque = 2,
        Transfer = 3,
        Card=4
    }

    public partial class VoucherListForm : Form
    {
        DataTable moDataTable;
        private byte mintTransactionTypeId = 0;
        private bool forProvider = false;
        string manualVoucherNoCriteria = string.Empty;
        public VoucherListForm()
        {
            InitializeComponent();
        }
        private void getData()
        {
            VoucherQueryCriteriaViewModel criteria = new VoucherQueryCriteriaViewModel();
            if (cmbPay_Way_Id.SelectedIndex != 0)
            {
                criteria.PayWayId = Convert.ToString(cmbPay_Way_Id.SelectedIndex - 1);
            }
            if (!string.IsNullOrEmpty(manualVoucherNoCriteria))
            {
                criteria.manualVoucherNo= manualVoucherNoCriteria;
            }
            if (mintTransactionTypeId != 0)
                criteria.VoucherTypeId = mintTransactionTypeId;

            if (txtFrom_Trans_Date.Checked)
                criteria.FromDate = $"{txtFrom_Trans_Date.Value.Day}-{txtFrom_Trans_Date.Value.Month}-{txtFrom_Trans_Date.Value.Year}";
            if (txtTo_Trans_Date.Checked)
                criteria.ToDate = $"{txtTo_Trans_Date.Value.Day}-{txtTo_Trans_Date.Value.Month}-{txtTo_Trans_Date.Value.Year}";
            if (!string.IsNullOrEmpty(txtPerson_No.Text.Trim()))
            {
                if(txtPerson_No.Text!="0")
                    criteria.PersonId = Convert.ToInt16(txtPerson_No.Text);
            }
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = VoucherRepository.getVoucherQuery(criteria);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        moDataTable = General.ConvertToDataTable(result.Data);
                        grdVoucherList.AutoGenerateColumns = false;
                        grdVoucherList.DataSource = moDataTable;
                    }
        }

        public void initForm(DateTime dtFromDate, DateTime dtToDate, VoucherTypeEnum TransactionTypeId = VoucherTypeEnum.All, int PayWay = -1, string manualVoucherNo="",int personId = 0, string personName="", bool forProvider = false)
        {
            mintTransactionTypeId = Convert.ToByte(TransactionTypeId);
            txtPerson_No.Text = personId.ToString();
            lblPerson_Name.Text = personName;

            if (mintTransactionTypeId ==(byte) VoucherTypeEnum.Qabd)
            {
                this.Text = "ايصالات القبض";
                colCredit_Amount.Visible = true;
                colDebit_Amount.Visible = false;
            }
            if (mintTransactionTypeId == (byte)VoucherTypeEnum.Sarf)
            {
                this.Text = "سندات الصرف";
                colCredit_Amount.Visible = false;
                colDebit_Amount.Visible = true;
                this.forProvider = forProvider;
            }
            if (mintTransactionTypeId == (byte)VoucherTypeEnum.SalesInvoice)
            {
                this.Text = "فاتورة مبيعات";
                colCredit_Amount.Visible = false;
                colDebit_Amount.Visible = true;
            }
            if (mintTransactionTypeId == 4)
            {
                this.Text = "فاتورة مشتريات";
                colCredit_Amount.Visible = true;
                colDebit_Amount.Visible = false;
                txtPerson_No.Text = string.Empty;
            }

            if (mintTransactionTypeId == 5)
                this.Text = "مردودات مبيعات";
            if (mintTransactionTypeId == 6)
                this.Text = "مردودات مشتريات";
            if (mintTransactionTypeId == 7)
                this.Text = "مردودات مساعدات";

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
            if (!string.IsNullOrEmpty(manualVoucherNo))
            {
                manualVoucherNoCriteria = manualVoucherNo;
            }
            if (mintTransactionTypeId == (byte)VoucherTypeEnum.Sarf)
            {
                if (!forProvider)
                {
                    lblPerson.Visible = false;
                    txtPerson_No.Visible = false;
                    btnShow_Person_ID_LOV.Visible = false;
                    lblPerson_Name.Visible = false;
                    txtPerson_No.Text = "0";
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
                int voucherId = Convert.ToInt32(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colVoucher_ID.Name].Value);
                byte VoucherTypeId = Convert.ToByte(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colvoucher_Type_ID.Name].Value);
                VoucherDialog frm = new VoucherDialog();
                frm.initForm(VoucherTypeId, voucherId);
                frm.ShowDialog();
            }
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

        private void grdVoucherList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdVoucherList.CurrentRow != null)
            {
                int voucherId = Convert.ToInt32(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colVoucher_ID.Name].Value);
                byte TransactionTypeId = Convert.ToByte(grdVoucherList.Rows[grdVoucherList.CurrentRow.Index].Cells[colvoucher_Type_ID.Name].Value);
                VoucherDialog frm = new VoucherDialog();
                frm.initForm(TransactionTypeId, voucherId);
                frm.ShowDialog();
            }
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            ReportViewer report = new ReportViewer();
            report.initForm(moDataTable.Copy(), General.getStartupPath() + @"\Reports\VoucherList.rdlc", null);
            report.Show();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            decimal amount = 0;
            int saleTransactionId = 0;

            if (grdVoucherList.CurrentRow == null)
            {
                VoucherDialog frm = new VoucherDialog();
                if (mintTransactionTypeId == (byte)VoucherTypeEnum.Qabd)
                {
                    amount = 0;// Convert.ToDecimal(grdVoucherList.CurrentRow.Cells[colCredit_Amount.Name].Value);
                    saleTransactionId = Convert.ToInt32(manualVoucherNoCriteria);// Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colManual_Voucher_No.Name].Value);
                    int personId = Convert.ToInt32(txtPerson_No.Text);// Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colPerson_ID.Name].Value);
                    string personName = lblPerson_Name.Text;// Convert.ToString(grdVoucherList.CurrentRow.Cells[colPerson_Name.Name].Value);
                    frm.initQabd(saleTransactionId, amount, personId, personName);
                    frm.ShowDialog();
                }
                else if (mintTransactionTypeId == (byte)VoucherTypeEnum.Sarf && forProvider ==false)
                {
                     frm.initForm(mintTransactionTypeId, -99, false);
                        frm.ShowDialog();
               }
                else
                {
                    //frm.initForm(mintTransactionTypeId, -99, false);
                    //frm.ShowDialog();
                }
            }
            else 
            { 
                VoucherDialog frm = new VoucherDialog();
                if (mintTransactionTypeId == (byte)VoucherTypeEnum.Qabd)
                {
                    amount = Convert.ToDecimal(grdVoucherList.CurrentRow.Cells[colCredit_Amount.Name].Value);
                    saleTransactionId= Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colManual_Voucher_No.Name].Value);
                    int personId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colPerson_ID.Name].Value);
                    string personName=Convert.ToString(grdVoucherList.CurrentRow.Cells[colPerson_Name.Name].Value);
                    frm.initQabd(saleTransactionId, amount,personId, personName);
                }
                else if (mintTransactionTypeId == (byte)VoucherTypeEnum.Sarf)
                {
                    if (forProvider)
                    {
                        int purchaseInvoiceId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colManual_Voucher_No.Name].Value);
                        int personId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colPerson_ID.Name].Value);
                        string personName = Convert.ToString(grdVoucherList.CurrentRow.Cells[colPerson_Name.Name].Value);

                        amount = 0;// Convert.ToDecimal(grdVoucherList.CurrentRow.Cells[colDebit_Amount.Name].Value);
                        frm.initSarf(purchaseInvoiceId, amount, personId, personName, forProvider);
                    }
                    else
                    {
                        amount = 0;// Convert.ToDecimal(grdVoucherList.CurrentRow.Cells[colDebit_Amount.Name].Value);
                        frm.initSarf(0, amount, 0, "", forProvider);
                    }
                }
                else if(mintTransactionTypeId == Convert.ToByte(VoucherTypeEnum.PurchaseInvoice))
                { 
                    int personId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colPerson_ID.Name].Value);
                    string personName = Convert.ToString(grdVoucherList.CurrentRow.Cells[colPerson_Name.Name].Value);
                    int voucherId = Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colVoucher_ID.Name].Value);
                    frm.initPurchaseInvoice(voucherId,0,personId,personName);
                }
                else
                {
                    frm.initForm(mintTransactionTypeId, -99, false);
                }
                frm.ShowDialog();
            }
        }



        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (grdVoucherList.CurrentRow != null)
            {
                ChangeVoucherTypeDialog frm = new ChangeVoucherTypeDialog();
                frm.initForm();
                frm.ShowDialog();
                if (frm.mboolAccepted == true)
                {
                    byte newVoucherId = Convert.ToByte(frm.retSelectedVoucherType());
                    ResultModel oResult = VoucherRepository.changeVoucherType(Convert.ToInt32(grdVoucherList.CurrentRow.Cells[colDaily_Trans_ID.Name].Value), newVoucherId);
                    if (oResult.StatusCode == "success")
                    {
                        if (oResult.ErrorText == "")
                        {
                            MessageBox.Show("تم التغيير");
                        }
                    }
                }
            }
        }
    }
}
