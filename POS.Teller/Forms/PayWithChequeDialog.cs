using POS.Windows.LOVs;
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
    public partial class PayWithChequeDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;

        public PayWithChequeDialog()
        {
            InitializeComponent();
        }

        private void PayWithChequeDialog_Load(object sender, EventArgs e)
        {

        }
        private void Show_Bank_ID_LOV()
        {
            BankLov lov = new BankLov();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtBank_ID.Text = lov.getSelectedBankId().ToString();
                txtBank_Name.Text = lov.getSelectedBankName();
            }

        }
        private void btnShow_Bank_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Bank_ID_LOV();
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
    }
}
