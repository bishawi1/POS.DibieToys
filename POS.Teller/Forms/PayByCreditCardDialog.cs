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
    public partial class PayByCreditCardDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Amount { get; set; }
        public PayByCreditCardDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Accepted = true;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Accepted = false;
            this.Hide();
        }

        private void btnDiscountPercent_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                Amount = Convert.ToDecimal(frm.Result);
                lblAmount.Text = Amount.ToString("0.00");
            }
        }
    }
}
