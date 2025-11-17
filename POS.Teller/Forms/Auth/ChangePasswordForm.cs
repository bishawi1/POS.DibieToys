
using POS.Shared.DTOs;
using POS.Shared.Models.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Auth
{
    public partial class ChangePasswordForm : Form
    {
        private string currentPassword = "";
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public void initForm(string userName, string currentPassword)
        {
            txtLoginName.Text = userName;
            txtLoginName.Enabled = false;
            this.currentPassword = currentPassword;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;

        private bool validateLogin()
        {
            string password = txtPassword.Text.ToString();
            string confirmPassword = txtConfirmPassword.Text.Trim().ToString();
            if (txtLoginName.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ادخال اسم المستخدم");
            }
            else if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("يرجى ادخال كلمة المرور");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("كلمة المرور غير صحيحية");
            }
            else
            {
                return true;
            }
            return false;
        }
        private bool changePassword(string userName, string password)
        {
            System.Data.DataSet oDataSet = new System.Data.DataSet();
            bool created = false;
            //try
            //{

            //    UserSession oUserSession;
            //    ResultModel oResult;
            //    oResult = Client.AuthRepository.changePassword(userName,currentPassword, password);
            //    if (oResult.StatusCode == "200")
            //    {
            //        oUserSession = (UserSession)oResult.Data;
            //        General.userSession = oUserSession;
            //        Accepted=true;
            //        created = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show(General.RetMessageText(oResult.StatusCode));
            //    }
            //    return created;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            return false;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validateLogin())
            {
                if (changePassword(txtLoginName.Text.Trim(), txtPassword.Text.Trim()))
                {
                    MessageBox.Show("تمت تغيير كلمة المرور");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
