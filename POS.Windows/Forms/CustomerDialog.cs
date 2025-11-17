using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows;
using POS.Windows.LOVs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public partial class CustomerDialog : Form
    {
        private short mintPerson_ID = 0;
        private bool NewRecord = true;
        private List<vPersonModel> model = null;
        private byte personCatId = 0;
        public bool mboolAccepted = false;
        public CustomerDialog()
        {
            InitializeComponent();
            General.initMyControls(this);
        }
        private bool validateCustomer()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(txtCustomer_Name.Text.Trim()))
            {
                valid = false;
                MessageBox.Show("يرجى ادخال اسم الزبون");
                txtCustomer_Name.Focus();
            }

            return valid;
        }
        private async Task<bool> AddPerson()
        {
            bool added = false;
            CreatePersonRequestDto addModel = new CreatePersonRequestDto();

            addModel.Address = txtAddress.Text.Trim();
            addModel.Begining_Balance_Amount = 0;
            if (txtCity_ID.Text != "")
            {
                addModel.City_ID = Convert.ToByte(txtCity_ID.Text);
            }
            addModel.Person_Notes = txtPerson_Notes.Text.Trim();
            addModel.Commercial_Name = txtCommercial_Name.Text.Trim();
            if(!string.IsNullOrEmpty(txtPerson_Account_ID.Text))
                addModel.Person_Account_ID = Convert.ToInt16(txtPerson_Account_ID.Text);
            addModel.Person_Name = txtCustomer_Name.Text.Trim();
            addModel.Sell_Discount_Percent = Convert.ToByte(txtSell_Discount_Percent.Value);
            addModel.Mobile=txtMobile.Text.Trim();
            if(cmbDebitCredit.SelectedIndex == 0)
                addModel.Begining_Balance_Amount = txtBegining_Balance_Amount.Value;
            else
                addModel.Begining_Balance_Amount = txtBegining_Balance_Amount.Value * -1;

                addModel.User_Name = General.userSession.UserName;
            addModel.Person_Cat_ID = personCatId;
            ResultModel result = await CustomerRepository.addCustomer(addModel);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        mintPerson_ID = ((PersonModel)result.Data).Person_ID;
                        added = true;
                        //showData();
                    }
            return added;
        }
        private bool UpdateCustomer()
        {
            bool modified = false;
            UpdatePersonRequestDto editModel = new UpdatePersonRequestDto();
            editModel.Person_ID=mintPerson_ID;
            editModel.Address = txtAddress.Text.Trim();
            if (txtCity_ID.Text != "")
            {
                editModel.City_ID = Convert.ToByte(txtCity_ID.Text);
            }
            editModel.Person_Notes = txtPerson_Notes.Text.Trim();
            editModel.Commercial_Name = txtCommercial_Name.Text.Trim();
            editModel.Person_Name = txtCustomer_Name.Text.Trim();
            if (!string.IsNullOrEmpty(txtPerson_Account_ID.Text.Trim()))
                editModel.Person_Account_ID = Convert.ToInt16(txtPerson_Account_ID.Text);
            editModel.Mobile = txtMobile.Text.Trim();
            editModel.Sell_Discount_Percent = Convert.ToByte(txtSell_Discount_Percent.Value);
            if (cmbDebitCredit.SelectedIndex == 0)
                editModel.Begining_Balance_Amount = txtBegining_Balance_Amount.Value;
            else
                editModel.Begining_Balance_Amount = txtBegining_Balance_Amount.Value * -1;

            editModel.User_Name = General.userSession.UserName;
            editModel.Person_Cat_ID = personCatId;
            ResultModel result = CustomerRepository.editCustomer(editModel, mintPerson_ID);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        mintPerson_ID = ((PersonModel)result.Data).Person_ID;
                        modified = true;
                        //showData();
                    }
            return modified;
        }
        private async Task<bool> SaveCustomer()
        {
            bool saved = false;
            if (NewRecord)
            {
                saved = await AddPerson();
            }
            else
            {
                saved = UpdateCustomer();
            }
            return saved;
        }
        private async void showData()
        {
            PersonQueryCriteriaViewModel criteria = new PersonQueryCriteriaViewModel();
            criteria.PersonId = mintPerson_ID;
            ResultModel result = await CustomerRepository.getCustomerQuery(criteria);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        model = (List<vPersonModel>)result.Data;
                        if (model.Count() > 0)
                        {
                            personCatId= model[0].Person_Cat_ID;
                            txtAddress.Text = model[0].Address;
                            txtCity_ID.Text = model[0].City_ID.ToString();
                            txtCity_Name.Text = model[0].City_Name;
                            txtCommercial_Name.Text = model[0].Commercial_Name;
                            txtCustomer_Name.Text = model[0].Person_Name;
                            txtCustomer_No.Text = model[0].Person_No.ToString();
                            txtMobile.Text = model[0].Mobile;
                            if (Convert.ToDecimal(model[0].Begining_Balance_Amount) >= 0)
                            {
                                cmbDebitCredit.SelectedIndex = 0;
                            }
                            else
                            {
                                cmbDebitCredit.SelectedIndex = 1; 
                            }
                            txtBegining_Balance_Amount.Value = Math.Abs( Convert.ToDecimal(model[0].Begining_Balance_Amount));
                            txtSell_Discount_Percent.Value = Convert.ToDecimal(model[0].Sell_Discount_Percent);
                            txtPerson_Notes.Text = model[0].Person_Notes;
                            txtPerson_Account_ID.Text = model[0].Person_Account_ID.ToString();
                        }
                    }
        }
        public void initForm(short customerId = -99,byte Person_Cat_ID=0)
        {
            cmbDebitCredit.SelectedIndex = 0;
            mintPerson_ID = customerId;
            personCatId=Person_Cat_ID;
            if (customerId > 0)
            {
                NewRecord = false;
                showData();
            }
            if (personCatId > 0)
            {
                if (personCatId == 1)
                {
                    this.Text = "بطاقة الزبون";
                }
                else if (personCatId == 2)
                {
                    this.Text = "بطاقة المورد";
                }
                else if (personCatId == 3)
                {
                    this.Text = "بطاقة الشريك/الساحب";
                }
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

        private void txtCity_ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private async void btnOk_Click(object sender, EventArgs e)
        {
            if (await SaveCustomer())
            {
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }

        private void CustomerDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                SendKeys.Send("{Tab}");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleted = false;
            if (MessageBox.Show("في حال الاستمرار في الالغاء لا يمكن التراجع، تود الاستمرار؟", "ادارة المكتبات", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                try
                {
                    //deleted = await CustomerRepository.deleteCustomer(mintPerson_ID);
                    //MessageBox.Show("تم الالغاء");
                    //this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
