using POS.Teller.LOVs;
using POS.Windows.Forms;
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

namespace POS.Teller.Forms
{
    public partial class PayDetailsDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Accepted { get; set; } = false;

        public PayDetailsDialog()
        {
            InitializeComponent();
        }
        private void Show_Person_ID_LOV()
        {
            CustomerLov lov = new CustomerLov();
            lov.initForm();
            lov.ShowDialog();
            if (lov.mboolAccepted == true)
            {
                txtPerson_No.Text = lov.getSelectedCustomerId().ToString();
                lblPerson_Name.Text = lov.getSelectedCustomerName();
                //msngPersonDiscountPercent = lov.getSelectedCustomerDiscountPercent();
                txtAmount.Focus();
            }

        }
        private void btnShow_Person_ID_LOV_Click(object sender, EventArgs e)
        {
            Show_Person_ID_LOV();
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

        private void btnBarcodeNumericCalc_Click(object sender, EventArgs e)
        {
            NumericKeyBoardDialog frm = new NumericKeyBoardDialog();
            frm.ShowDialog();
            if (frm.Accepted)
            {
                txtAmount.Text = Convert.ToString(frm.Result);
            }
        }

    }
}
