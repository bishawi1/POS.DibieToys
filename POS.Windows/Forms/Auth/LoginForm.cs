
using POS.Client;
using POS.DAL;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Windows;
using POS.Windows.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public async Task initForm()
        {
            ResultModel result = await Client.TellerRepository.getTellerList();
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    List<Teller_UserModel> tellers= (List<Teller_UserModel>)result.Data;
                }
            }
        }
        private void applyLogin()
        {
            ResultModel result = UsersRepository.verifyLogin(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (result != null)
            {
                if (chkChangePassword.Checked)
                {
                    //ChangePasswordForm frm = new ChangePasswordForm();
                    //frm.ShowDialog();
                    //frm.Close();
                    //frm.Dispose();
                }
                General.mboolLogedin = true;
                //Accepted = true;
                this.Hide();
            }
        }
        void Login()
        {
            //applyLogin();
            if (General.HaveInternetConnection())
            {
                try
                {
                    General.verifyHotLogin(txtUserName.Text, txtPassword.Text, true);
                    if (General.mboolLogedin)
                    {
                        string userName = txtUserName.Text;
                        string password = txtPassword.Text;
                        if (chkChangePassword.Checked)
                        {
                            this.Close();
                            this.Dispose();
                            ChangePasswordForm frm = new ChangePasswordForm();
                            frm.initForm(userName, password);
                            frm.ShowDialog();

                        }
                        else
                        {
                            this.Close();
                            this.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No internet connection!");
                }
                ;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            Login();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Return)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.F7)
            {

            }
        }
    }
}
