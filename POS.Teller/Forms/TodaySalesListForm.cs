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
    public partial class TodaySalesListForm : Form
    {
        public bool Accepted = false;
       public int SelectedSalesTransactionId()
        {
            return Convert.ToInt32(grdSales.CurrentRow.Cells[colSale_Transaction_ID.Name].Value);
        }
        public TodaySalesListForm()
        {
            InitializeComponent();
        }
        public void initForm(DataTable dt)
        {
            grdSales.AutoGenerateColumns = false;
            grdSales.DataSource = dt;
        }

        private void tsbtnEditSaleTransaction_Click(object sender, EventArgs e)
        {
            if (grdSales.CurrentRow != null)
            {
                Accepted = true;
                this.Hide();
            }
        }
    }
}
