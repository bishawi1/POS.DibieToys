using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using POS.Client;
using POS.Shared;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace POS.Windows.Forms
{
    public partial class VoucherDialog : Form
    {
        private bool mboolAccepted = false;
        private int mintVoucherId = 0;
        private bool NewRecord = true;
        private int mintPerson_ID = 0;
        private byte transTypeId = 0;
        private vVoucherModel model;
        private bool mboolShowCitizen = true;
        private float msngPersonDiscountPercent = 0;
        private byte personCatId = 0;
        private byte payWayId = 0;
        private bool forProvider = false;
        private void clearScreen()
        {
            txtAmount.Text = string.Empty;
            txtCheque_Due_Date.Value = DateTime.Now;
            txtCheque_No.Text = string.Empty;
            //txtCurrency_Name.Text = string.Empty;
            txtManual_Trans_No.Text = string.Empty;
            txtTrans_Details.Text = string.Empty;
            txtVoucherId.Value = 0;
            if (cmbPay_Way_Id.SelectedIndex == 1)
            {
                txtPerson_No.Text = string.Empty;
                lblPerson_Name.Text = string.Empty;
                txtPerson_No.Focus();
            }
            else
            if (cmbPay_Way_Id.SelectedIndex == 2)
            {
                txtAmount.Focus();
            }
        }

        private bool saveVoucher()
        {
            bool saved = false;
            if (NewRecord)
            {
                saved = addVoucher();
            }
            else
            {
                saved = editVoucher();
            }
            return saved;
        }
        private bool addVoucher()
        {
            bool added = false;
            CreateVoucherRequestDto addModel = new CreateVoucherRequestDto();


            if (!string.IsNullOrEmpty(txtCheque_No.Text.Trim()))
            {
                addModel.Cheque_No = txtCheque_No.Text;
                addModel.Cheque_Due_Date = txtCheque_Due_Date.Value;
                addModel.Cheque_Bank_No = Convert.ToByte(txtBank_ID.Text);
            }
            if (transTypeId == 1 || transTypeId == 4)
            {
                addModel.Debit_Amount = 0;
                addModel.Credit_Amount = Convert.ToDecimal(txtAmount.Value);
            }
            else if (transTypeId == 2 || transTypeId == 3)
            {
                addModel.Debit_Amount = Convert.ToDecimal(txtAmount.Value);
                addModel.Credit_Amount = 0;
            }
            //addModel.Debit_Amount = Convert.ToDecimal(txtAmount.Value);
            //addModel.Credit_Amount = 0;
            addModel.Person_ID = Convert.ToInt16(txtPerson_No.Text);
            addModel.voucher_Type_ID = transTypeId;// (transTypeId == (byte)ShowVoucherTypeEnum.BackAssistantBook ? (byte)ShowVoucherTypeEnum.BackSalesInvoices : transTypeId);
            addModel.Voucher_Currency_ID = Convert.ToByte(txtTrans_Currency_ID.Text.Trim());
            addModel.Voucher_Currency_Rate = 1;
            addModel.Voucher_Date = txtTrans_Date.Value;
            addModel.User_Name = General.userSession.UserName;
            addModel.Manual_Voucher_No = txtManual_Trans_No.Text.Trim();
            addModel.Voucher_Details = txtTrans_Details.Text.Trim();
            addModel.Pay_Way_Id = payWayId;// Convert.ToByte(cmbPay_Way_Id.SelectedIndex + 1);
            ResultModel resut = VoucherRepository.addVoucher(addModel);
            if (resut != null)
                if (resut.StatusCode == "200")
                    if (resut.Data != null)
                        added = true;
            return added;
        }
        private bool editVoucher()
        {
            bool modified = false;
            UpdateVoucherRequestDto editModel = new UpdateVoucherRequestDto();
            if (!string.IsNullOrEmpty(txtCheque_No.Text.Trim()))
            {
                editModel.Cheque_No = txtCheque_No.Text;
                editModel.Cheque_Due_Date = txtCheque_Due_Date.Value;
                editModel.Cheque_Bank_No = Convert.ToByte(txtBank_ID.Text);
            }
            editModel.Pay_Way_Id = Convert.ToByte(cmbPay_Way_Id.SelectedIndex);
            if (transTypeId == 1 || transTypeId == 4)
            {
                editModel.Debit_Amount = 0;
                editModel.Credit_Amount = Convert.ToDecimal(txtAmount.Value);
            }
            else if (transTypeId == 2 || transTypeId == 3)
            {
                editModel.Debit_Amount = Convert.ToDecimal(txtAmount.Value);
                editModel.Credit_Amount = 0;
            }


            editModel.Person_ID = Convert.ToInt16(txtPerson_No.Text);
            editModel.voucher_Type_ID = transTypeId;//(transTypeId == (byte)ShowVoucherTypeEnum.BackAssistantBook ? (byte)ShowVoucherTypeEnum.BackSalesInvoices : transTypeId);
            editModel.Voucher_Currency_ID = Convert.ToByte(txtTrans_Currency_ID.Text.Trim());
            editModel.Voucher_Currency_Rate = 1;
            editModel.Voucher_Date = txtTrans_Date.Value;
            editModel.User_Name = General.userSession.UserName;
            editModel.Manual_Voucher_No = txtManual_Trans_No.Text.Trim();
            editModel.Voucher_Details = txtTrans_Details.Text.Trim();
            editModel.Pay_Way_Id = payWayId;// Convert.ToByte(cmbPay_Way_Id.SelectedIndex);
            ResultModel resut = VoucherRepository.editVoucher(editModel, mintVoucherId);
            if (resut != null)
                if (resut.StatusCode == "200")
                    if (resut.Data != null)
                        modified = true;

            return modified;
        }
        private void showData()
        {
            VoucherQueryCriteriaViewModel criteria = new VoucherQueryCriteriaViewModel()
            {
                VoucherId = mintVoucherId,
                VoucherTypeId = 0
            };
            ResultModel result = VoucherRepository.getVoucherQuery(criteria);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        List<vVoucherModel> oList = (List<vVoucherModel>)result.Data;
                        if (oList.Count() > 0)
                        {
                            model = oList[0];
                            txtVoucherId.Text = model.Voucher_ID.ToString();
                            transTypeId = model.voucher_Type_ID;
                            if (model.Debit_Amount == 0)
                            {
                                txtAmount.Value = Convert.ToDecimal(model.Credit_Amount);
                            }
                            else
                            {
                                txtAmount.Value = Convert.ToDecimal(model.Debit_Amount);
                            }

                            txtTrans_Currency_ID.Text = model.Voucher_Currency_ID.ToString();
                            txtCurrency_Name.Text = model.Currency_Name;
                            txtManual_Trans_No.Text = model.Manual_Voucher_No;
                            txtPerson_No.Text = model.Person_ID.ToString();
                            lblPerson_Name.Text = model.Person_Name;
                            txtTrans_Currency_Rate.Value = Convert.ToDecimal(model.Voucher_Currency_Rate);
                            txtTrans_Date.Value = model.Voucher_Date;
                            txtTrans_Details.Text = model.Voucher_Details;

                            payWayId = model.Pay_Way_Id;
                            setPayWay();

                            if (!string.IsNullOrEmpty(model.Cheque_No))
                            {
                                txtBank_ID.Text = model.Cheque_Bank_No.ToString();
                                txtBank_Name.Text = model.Bank_Name;
                                txtCheque_Due_Date.Value = Convert.ToDateTime(model.Cheque_Due_Date);
                                txtCheque_No.Text = model.Cheque_No;
                            }
                            if (model.voucher_Type_ID == 2)
                            {
                                if (model.Person_No == "262")
                                {
                                    lblPerson.Text = "الزبون";
                                    lblPerson.Visible = false;
                                    txtPerson_No.Visible = false;
                                    lblPerson_Name.Visible = false;
                                    btnShow_Person_ID_LOV.Visible = false;
                                }
                                else
                                {
                                    lblPerson.Text = "المورد";
                                    lblPerson.Visible = true;
                                    txtPerson_No.Visible = true;
                                    lblPerson_Name.Visible = true;
                                    btnShow_Person_ID_LOV.Visible = true;

                                }
                            }
                        }

                    }
        }
        private void setDefaults()
        {
            txtTrans_Currency_Rate.Value = 1;
            txtTrans_Currency_ID.Text = "1";
            setCurrencyName();
        }
        public void initSarf(int purchaseInvoiceId, decimal amount, int personId, string personName, bool forProvider = false)
        {
            this.forProvider = forProvider;
            transTypeId = (byte)VoucherTypeEnum.Sarf;//Sarf
                            // PersonId = PersonId;
            initPayWay();
           personCatId = Convert.ToByte(PersonCatEnum.Provider);
            this.Text = "سند صرف";
            // cmbPay_Way_Id.SelectedIndex = 1;
            this.mintPerson_ID = personId;
            NewRecord = true;
            txtAmount.Value = amount;
            txtTrans_Currency_ID.Text = "1";
            txtCurrency_Name.Text = General.getCurrencyName(Convert.ToByte(txtTrans_Currency_ID.Text));
            txtTrans_Currency_Rate.Value = 1;
            //txtManual_Trans_No.Text = salesTransactionId.ToString();




            if (forProvider)
            {
                txtManual_Trans_No.Text = purchaseInvoiceId.ToString();
                txtPerson_No.Text = personId.ToString();
                lblPerson_Name.Text = personName;
                txtAmount.Focus();
                lblPerson.Visible = true;
                btnShow_Person_ID_LOV.Visible = true;
                txtPerson_No.Visible = true;
                lblPerson_Name.Visible = true;
                txtPerson_No.Focus();
            }
            else
            {
                txtPerson_No.Text = "0";
                lblPerson.Visible = false;
                btnShow_Person_ID_LOV.Visible = false;
                txtPerson_No.Visible = false;
                lblPerson_Name.Visible = false;
                txtAmount.Focus();
            }

            //lblPerson_Name.Text = personName;

        }
        private void initPayWay()
        {
            switch (transTypeId)
            {
                case (byte)VoucherTypeEnum.Qabd:
                    cmbPay_Way_Id.Items.Clear();
                    cmbPay_Way_Id.Items.Add("نقدا");
                    cmbPay_Way_Id.Items.Add("فيزا");
                    cmbPay_Way_Id.Items.Add("شيكات");
                    cmbPay_Way_Id.Items.Add("حوالات");
                    cmbPay_Way_Id.SelectedIndex = 0;
                    payWayId = 1;
                    break;
                case (byte)VoucherTypeEnum.Sarf:
                    cmbPay_Way_Id.Items.Clear();
                    cmbPay_Way_Id.Items.Add("نقدا");
                    cmbPay_Way_Id.Items.Add("فيزا");
                    cmbPay_Way_Id.Items.Add("شيكات");
                    cmbPay_Way_Id.Items.Add("حوالات");
                    cmbPay_Way_Id.SelectedIndex = 0;
                    payWayId = 1;
                    break;
            }
        }
        private void setPayWay()
        {
            if (transTypeId == (byte)VoucherTypeEnum.Qabd)
            {
                switch (payWayId)
                {
                    case (byte)PayWayEnum.Cash:
                        cmbPay_Way_Id.SelectedIndex = 0;
                        break;
                    case (byte)PayWayEnum.Visa:
                        cmbPay_Way_Id.SelectedIndex = 1;
                        break;
                    case (byte)PayWayEnum.Cheque:
                        cmbPay_Way_Id.SelectedIndex = 2;
                        break;
                    case (byte)PayWayEnum.Transfere:
                        cmbPay_Way_Id.SelectedIndex = 3;
                        break;
                }
            }
            else if (transTypeId == (byte)VoucherTypeEnum.Sarf)
            {
                switch (payWayId)
                {
                    case (byte)PayWayEnum.Cash:
                        cmbPay_Way_Id.SelectedIndex = 0;
                        break;
                    case (byte)PayWayEnum.Visa:
                        cmbPay_Way_Id.SelectedIndex = 1;
                        break;
                    case (byte)PayWayEnum.Cheque:
                        cmbPay_Way_Id.SelectedIndex = 2;
                        break;
                    case (byte)PayWayEnum.Transfere:
                        cmbPay_Way_Id.SelectedIndex = 3;
                        break;
                }
            }
        }
        public void initQabd(int salesTransactionId, decimal amount, int personId, string personName)
        {
            transTypeId =(Byte) VoucherTypeEnum.Qabd;
            initPayWay();
            this.mintPerson_ID = personId;
            personCatId = Convert.ToByte(PersonCatEnum.Customer);
            this.Text = "ايصال قبض";
            NewRecord = true;
            txtAmount.Value = amount;
            txtTrans_Currency_ID.Text = "1";
            txtCurrency_Name.Text = General.getCurrencyName(Convert.ToByte(txtTrans_Currency_ID.Text));
            txtTrans_Currency_Rate.Value = 1;
            txtManual_Trans_No.Text = salesTransactionId.ToString();
            txtPerson_No.Text = personId.ToString();
            lblPerson_Name.Text = personName;
            txtAmount.Focus();
        }
        public void initPurchaseInvoice(int manualVoucherNo, decimal amount, int personId, string personName)
        {
            transTypeId = (Byte)VoucherTypeEnum.PurchaseInvoice;
            lblPay_Way_ID.Visible = false;
            cmbPay_Way_Id.Visible = false;
            grpCheques.Visible = false;
           // initPayWay();
            this.mintPerson_ID = personId;
            personCatId = Convert.ToByte(PersonCatEnum.Customer);
           // this.Text = "سند صرف";
            this.Text = "فاتورة مشتريات";
            NewRecord = true;
            txtAmount.Value = amount;
            txtTrans_Currency_ID.Text = "1";
            txtCurrency_Name.Text = General.getCurrencyName(Convert.ToByte(txtTrans_Currency_ID.Text));
            txtTrans_Currency_Rate.Value = 1;
            txtManual_Trans_No.Text = manualVoucherNo.ToString();
            txtPerson_No.Text = personId.ToString();
            lblPerson_Name.Text = personName;
            txtAmount.Focus();
        }
        public void initForm(byte transTypeId = 1, int voucherId = -99, bool showCitizen = true, byte personCatId = 0, int personId = 0, string personName = "")
        {
            this.mboolShowCitizen = showCitizen;
            this.transTypeId = transTypeId;
            this.personCatId = personCatId;
            if (transTypeId == (byte)VoucherTypeEnum.Qabd)
            {
                this.Text = "ايصال قبض";
            }
            else if (transTypeId == (byte) VoucherTypeEnum.Sarf)
            {
                this.Text = "سند صرف";
                payWayId =(byte) PayWayEnum.Cash;
                initPayWay();
                txtPerson_No.Visible = mboolShowCitizen;
                btnShow_Person_ID_LOV.Visible = mboolShowCitizen;
                lblPerson_Name.Visible = mboolShowCitizen;
                if (mboolShowCitizen)
                {
                    if (personId > 0)
                    {
                        txtPerson_No.Text = personId.ToString();
                        lblPerson_Name.Text = personName;
                    }
                    if (personCatId == 0 || personCatId == Convert.ToByte(PersonCatEnum.Provider))
                    {
                        lblPerson.Text = "المورد";
                    }
                    else if (personCatId == Convert.ToByte(PersonCatEnum.Partner))
                    {
                        lblPerson.Text = "الشريك/الساحب";
                    }
                    else if (personCatId == Convert.ToByte(PersonCatEnum.Customer))
                    {
                        lblPerson.Text = "الزبون";
                    }
                }
                else
                {
                    txtPerson_No.Text = "1";
                }
                lblPerson.Visible = mboolShowCitizen;
            }
            else if (transTypeId == (byte) VoucherTypeEnum.SalesInvoice)
            {
                this.Text = "فاتورة مبيعات";
                cmbPay_Way_Id.SelectedIndex = 0;
            }
            else if (transTypeId == (byte) VoucherTypeEnum.PurchaseInvoice)
            {
                this.Text = "فاتورة مشتريات";
                cmbPay_Way_Id.Items.Clear();
                cmbPay_Way_Id.Items.Add("لا ينطبق");
                cmbPay_Way_Id.Enabled = false;
                lblPerson.Text = "المورد";
                cmbPay_Way_Id.SelectedIndex = 0;
                personCatId = (byte) PersonCatEnum.Provider;
            }
            else if (transTypeId == 7)
            {
                this.Text = "فاتورة مرتجعات مساعدات";
                lblPerson.Text = "الزبون";
                cmbPay_Way_Id.SelectedIndex = 0;
            }
            if (voucherId < 0)
            {
                NewRecord = true;
                setDefaults();
            }
            else
            {
                NewRecord = false;
                mintVoucherId = voucherId;
                showData();
            }
        }
        public VoucherDialog()
        {
            InitializeComponent();
        }
        private bool validateVoucher()
        {
            bool valid = true;
            return valid;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validateVoucher())
            {
                if (saveVoucher())
                {
                    mboolAccepted = true;
                    this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();

        }
        private void Show_Person_ID_LOV()
        {
            CustomerLov lov = new CustomerLov();
            if (personCatId ==(byte) PersonCatEnum.Partner)
            {
                lov.initForm(personCatId);
            }
            else
            {
                lov.initForm();
            }
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtPerson_No.Text = lov.getSelectedCustomerId().ToString();
                lblPerson_Name.Text = lov.getSelectedCustomerName();
                msngPersonDiscountPercent = lov.getSelectedCustomerDiscountPercent();
                txtAmount.Focus();
            }

        }

        private void btnShow_Person_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Person_ID_LOV();
        }

        private void txtPerson_No_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPerson_No_Validating(object sender, CancelEventArgs e)
        {

        }
        private void Show_Trans_Currency_ID_LOV()
        {
            CurrencyLOV lov = new CurrencyLOV();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtTrans_Currency_ID.Text = lov.getSelectedCurrencyId().ToString();
                txtCurrency_Name.Text = lov.getSelectedCurrencyName();
            }

        }
        private void btnShow_Trans_Currency_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Trans_Currency_ID_LOV();
        }
        private void Show_Bank_ID_LOV()
        {
            BankLov lov = new BankLov();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtBank_ID.Text = lov.getSelectedBankId().ToString();
                txtBank_Name.Text = lov.getSelectedBankName();
            }

        }
        private void btnShow_Bank_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Bank_ID_LOV();
        }
        private void setCurrencyName()
        {
            if (txtTrans_Currency_ID.Text.Trim() != "")
            {
                string name = General.getCurrencyName(Convert.ToByte(txtTrans_Currency_ID.Text));
                if (name == "")
                {
                    txtCurrency_Name.Text = "";
                    MessageBox.Show("غير معرف");
                    txtTrans_Currency_ID.Text = "";
                    txtCurrency_Name.Focus();
                }
                else
                {
                    txtCurrency_Name.Text = name;
                }
            }
        }
        private void txtTrans_Currency_ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnShowReference_Transaction_Click(object sender, EventArgs e)
        {
            if (model.voucher_Type_ID == 3)
            {
                //SalesForm frm = new SalesForm();
                //frm.initForm(0, Convert.ToInt32(txtManual_Trans_No.Text), false, false);
                ////frm.MdiParent = this;
                //frm.ShowDialog();
            }
            else if (model.voucher_Type_ID == 5)
            {
                //SalesForm frm = new SalesForm();
                //frm.initForm(1, Convert.ToInt32(txtManual_Trans_No.Text), false, false);
                ////frm.MdiParent = this;
                //frm.ShowDialog();
            }
        }
        private void validatePayWay()
        {
            grpCheques.Enabled = false;
            if (transTypeId == (byte)VoucherTypeEnum.Qabd)
            {
                switch ((int)cmbPay_Way_Id.SelectedIndex)
                {
                    case 0:
                        payWayId = (byte)PayWayEnum.Cash;
                        break;
                    case 1:
                        payWayId = (byte)PayWayEnum.Visa;
                        break;
                    case 2:
                        payWayId = (byte)PayWayEnum.Cheque;
                        grpCheques.Enabled = true;
                        break;
                    case 3:
                        payWayId = (byte)PayWayEnum.Transfere;
                        break;
                 }
            }
            else if (transTypeId == (byte)VoucherTypeEnum.Sarf)
            {
                switch ((int)cmbPay_Way_Id.SelectedIndex)
                {
                case 0:
                    payWayId = (byte)PayWayEnum.Cash;
                    break;
                case 1:
                    payWayId = (byte)PayWayEnum.Visa;
                    break;
                case 2:
                    payWayId = (byte)PayWayEnum.Cheque;
                    grpCheques.Enabled = true;
                    break;
                case 3:
                    payWayId = (byte)PayWayEnum.Transfere;
                    break;
                }
            }
        }
        private void cmbPay_Way_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            validatePayWay();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            if (validateVoucher())
            {
                if (saveVoucher())
                {
                    NewRecord = true;
                    clearScreen();
                }
            }
        }

        private void btnBackAssistantCalculator_Click(object sender, EventArgs e)
        {
            //BackAssistantCalculatorDialog frm = new BackAssistantCalculatorDialog();
            //frm.initForm(Convert.ToInt32( txtPerson_No.Text), lblPerson_Name.Text, msngPersonDiscountPercent);
            //frm.ShowDialog();
            //if (frm.mboolAccepted == true)
            //{
            //    txtAmount.Value =Convert.ToDecimal( frm.amountAfterDiscount);
            //    txtTrans_Details.Text = frm.backDetails;
            //}
            //frm.Close();
            //frm.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtVoucherId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
