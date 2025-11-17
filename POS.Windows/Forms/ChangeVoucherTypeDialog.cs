using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop.TestClient
{
    public partial class ChangeVoucherTypeDialog : Form
    {
        public bool mboolAccepted = false;
        public ChangeVoucherTypeDialog()
        {
            InitializeComponent();
        }
        public void initForm()
        {
            cmbVoucherType.SelectedIndex = 0;
        }
        public int retSelectedVoucherType()
        {
            return cmbVoucherType.SelectedIndex + 1;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mboolAccepted = true;
            this.Hide();
        }
    }
}
