using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using POS.Client;
using POS.DAL.Repositories;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Windows;
using POS.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RealEstateRentalApp
{
    public partial class LoginForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;

        public void initForm()
        {

        }
        //private bool verifyLogin(string userName, string password)
        //{
        //    bool isValid = false;
        //    if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
        //    {
        //        MessageBox.Show("تحقق من اسم المستخدم وكلمة المرور");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            SQLUsersRepository repos = new SQLUsersRepository();
        //            UsersModel model =  repos.login(userName, password);
        //            if (model == null)
        //            {
        //                MessageBox.Show("تحقق من اسم المستخدم وكلمة المرور!");
        //            }
        //            else
        //            {
        //                General.currentUserName = userName;
        //                General.currentUserId = model.User_ID;
        //                isValid = true;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("تحقق من اسم المستخدم وكلمة المرور!");
        //        }
        //        return isValid;
        //    }
        //    return isValid;
        //}
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accepted = false;
        }
        private  void applyLogin()
        {            
            ResultModel result = UsersRepository.verifyLogin(txtUser_Name.Text.Trim(), txtPassword.Text.Trim());
            if (result != null)
            {
                if (chkChangePassword.Checked)
                {
                    ChangePasswordForm frm = new ChangePasswordForm();
                    frm.ShowDialog();
                    frm.Close();
                    frm.Dispose();
                }
                Accepted = true;
                this.Hide();
            }
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            applyLogin();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                applyLogin();
            }else if(e.KeyCode == Keys.Escape)
            {
                Accepted=false;
                this.Hide();
            }
        }
    }
}
