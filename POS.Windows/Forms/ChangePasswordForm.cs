using POS.DAL.Repositories;
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
    public partial class ChangePasswordForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Changed { get; set; } = false;


        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewPassword.Text) && !string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    SQLUsersRepository repos = new SQLUsersRepository();
                    if (repos.changePassword(General.currentUserId, txtNewPassword.Text, txtConfirmPassword.Text))
                    {
                        Changed = true;
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("كلمة المرور غير متطابقة!");
                }
            }
            else
            {
                MessageBox.Show("يجب ادخال كلمة المرور");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Changed = false;
            this.Hide();
        }
    }
}
