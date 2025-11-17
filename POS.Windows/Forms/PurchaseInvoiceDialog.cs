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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms
{
    public partial class PurchaseInvoiceDialog : Form
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

        public PurchaseInvoiceDialog()
        {
            InitializeComponent();
        }
        private void clearScreen()
        {
            txtAmount.Text = string.Empty;
            txtManual_Trans_No.Text = string.Empty;
            txtTrans_Details.Text = string.Empty;
            txtVoucherId.Value = 0;
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
            {
                if (result.StatusCode == "200")
                {
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
            }
        }
        private void setDefaults()
        {
            txtTrans_Currency_Rate.Value = 1;
            txtTrans_Currency_ID.Text = "1";
            setCurrencyName();
        }
        public void initPurchaseInvoice(int manualVoucherNo, decimal amount, int personId, string personName)
        {
            transTypeId = (Byte)VoucherTypeEnum.PurchaseInvoice;
            this.mintPerson_ID = personId;
            personCatId = Convert.ToByte(PersonCatEnum.Customer);
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


            this.Text = "فاتورة مشتريات";
            personCatId = (byte)PersonCatEnum.Provider;
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
            if (personCatId == (byte)PersonCatEnum.Partner)
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
    }
}
