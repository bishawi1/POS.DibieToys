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
    public partial class LabelCountDialog : Form
    {
        public bool mboolAccepted = false;
        public int mintRecordCount = 1;
        public LabelCountDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtLabelCount.Value > 0)
            {
                mintRecordCount = Convert.ToInt32(txtLabelCount.Value);
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();

        }
    }
}
