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
    public partial class ManualProductUnitPriceDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;
        public ManualProductUnitPriceDialog()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                lblItemUnitPrice.Text = Convert.ToString(frm.Result);
            }
        }
        private bool validateItemUnitPrice()
        {
            bool isValid = true;
            if(string.IsNullOrEmpty(lblItemUnitPrice.Text))
            {
                MessageBox.Show("يرجى تحديد سعر الوحدة");
                isValid = false;
            }
            return isValid;
        }
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (validateItemUnitPrice())
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
    }
}
