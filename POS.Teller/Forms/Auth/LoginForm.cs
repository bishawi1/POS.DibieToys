using Newtonsoft.Json;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Teller;
using POS.Teller.ViewModel;
using POS.Windows.Auth;
using POS.Windows.Forms;
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
        public bool Accepted = false;
        private string passwordPrefix = "Mena@";
        DataTable tellersDatatable;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Accepted = false;
            this.Close();
        }
        public async Task initForm()
        {
            UserStartupViewModel dataModel = null;
            if (Path.Exists($@"{General.getStartupPath()}\{Constants.startupLoginFile}"))
            {
                string content = Util.readFile($@"{General.getStartupPath()}\{Constants.startupLoginFile}");
                dataModel = JsonConvert.DeserializeObject<UserStartupViewModel>(content);
            }
            if( dataModel != null)
            {
                chkRememberMe.Checked = dataModel.RememberMe;
                txtPassword.Text = dataModel.Password;
                txtUserName.Text = dataModel.UserName;
            }
            //ResultModel result = await Client.TellerRepository.getTellerList();
            //if (result != null)
            //{
            //    if (result.StatusCode == "200")
            //    {
            //        List<Teller_UserModel> tellers = (List<Teller_UserModel>)result.Data;
            //        tellersDatatable=General.ConvertToDataTable(tellers);
            //        cmbTellers.DisplayMember = "User_Name";
            //        cmbTellers.ValueMember = "Teller_User_ID";
            //        cmbTellers.DataSource = tellersDatatable;
            //        cmbTellers.SelectedIndex = 0;
            //        btnOK.Enabled = true;
            //    }
            //}
        }
        async void Login()
        {
            //applyLogin();
            if (General.HaveInternetConnection())
            {
                try
                {
                    //General.verifyHotLogin(txtUserName.Text, passwordPrefix + txtPassword.Text, true);
                    General.verifyHotLogin(txtUserName.Text, passwordPrefix + txtPassword.Text, true);
                    if (General.mboolLogedin)
                    {
                        string userName = txtUserName.Text;// txtUserName.Text;
                        string password = txtPassword.Text.Trim();
                        ResultModel result = await Client.TellerRepository.getLoginTeller(userName);
                        if (result != null)
                        {
                            if (result.StatusCode == "200")
                            {
                                Teller_UserModel teller = (Teller_UserModel)result.Data;
                                General.currentTellerId = teller.Teller_ID;
                                General.branchId = teller.Branch_ID;
                                UserStartupViewModel startupViewModel = new UserStartupViewModel() 
                                { 
                                    BranchId = General.branchId,
                                    UserName = userName,
                                    Password = password,
                                    RememberMe = chkRememberMe.Checked,
                                    TellerId = teller.Teller_User_ID
                                };
                                string jsonContent = System.Text.Json.JsonSerializer.Serialize(startupViewModel);
                                //string data= Util.ComputeSha256Hash(jsonContent);
                                if(chkRememberMe.Checked)
                                {
                                    Util.writeFile($@"{General.getStartupPath()}\{Constants.startupLoginFile}" , jsonContent);
                                }
                                else
                                {
                                    Util.writeFile($@"{General.getStartupPath()}\{Constants.startupLoginFile}", String.Empty);
                                }
                                //Util.writeFile(@"c:\temp\login.json", teller.Teller_User_ID.ToString());
                            }
                        }


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


        private async void btnOK_Click(object sender, EventArgs e)
        {
            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            Login();
        }

        private void btnPasswordNumericCalc_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.initForm(false);
            frm.ShowDialog();
            if (frm.Accepted)
            {
                txtPassword.Text = Convert.ToString(frm.Result);
            }

        }
    }
}
