
using POS.Client;
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

namespace POS.Teller.Lookups
{
    public partial class BankForm : Form
    {
        public bool mboolNewRecord = true;
        public bool mboolAccepted = false;
        public int LastAddedBankId = 0;
        public string LastAddedBankName = string.Empty;

        public BankForm()
        {
            InitializeComponent();
        }
        public int getBankId()
        {
            return Convert.ToInt32(txtBank_ID.Text);
        }
        public string getBankName()
        {
            return txtBank_Name.Text;
        }
        public bool validateForm()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(txtBank_Name.Text.Trim()))
            {
                valid = false;
                MessageBox.Show("يرجى تحديد الوصف");
            }
            return valid;
        }
        public bool addBank()
        {
            bool saved = false;
            CreateBankRequestDto model = new CreateBankRequestDto()
            {
                Bank_Name = txtBank_Name.Text.Trim(),
                Bank_Notes = txtBank_Notes.Text.Trim(),
            };
            ResultModel result = BankRepository.addBank(model);
            if (result != null)
                if (result.StatusCode == "200")
                    if (result.Data != null)
                    {
                        BankModel store = (BankModel)result.Data;
                        txtBank_ID.Text = store.Bank_No.ToString();
                        LastAddedBankId = store.Bank_No;
                        LastAddedBankName = store.Bank_Name;
                        saved = true;
                        return saved;
                    }
            return saved;
        }
        private bool editBank()
        {
            bool saved = false;
            return saved;
        }
        public void showData()
        {

        }
        public bool saveForm()
        {
            bool saved = false;
            if (mboolNewRecord)
            {
                saved = addBank();
            }
            else
            {
                saved = editBank();
            }
            return saved;
        }
        public void initForm()
        {
            mboolNewRecord = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (saveForm())
            {
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = true;
            this.Hide();
        }
    }
}
