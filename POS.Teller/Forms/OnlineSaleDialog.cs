using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Teller.Forms
{
    public partial class OnlineSaleDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;
        public OnlineSaleDialog()
        {
            InitializeComponent();
        }
        public void initForm()
        {
            cmbDelevery_Place.SelectedIndex = 0;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validateSale())
            {
                Accepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Accepted = false;
            this.Hide();
        }
        private bool validateSale()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtDelevery_Transaction_No.Text.Trim()))
            {
                MessageBox.Show("يرجى ادخال رقم البوليصة");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(txtDelevery_Fees.Text.Trim()))
            {
                txtDelevery_Fees.Text = "0";
            }
            return isValid;
        }
        private void btnFeesNumericCalc_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                txtDelevery_Fees.Text = Convert.ToString(frm.Result);
            }
        }

        private void cmbDelevery_Place_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDelevery_Place.SelectedIndex != -1)
            {
                if (cmbDelevery_Place.SelectedIndex == 0)
                {
                    txtDelevery_Fees.Text = "15";
                }
                else if (cmbDelevery_Place.SelectedIndex == 1)
                {
                    txtDelevery_Fees.Text = "25";
                }
                else
                {
                    txtDelevery_Fees.Text = "65";
                }
            }
        }
    }
}
