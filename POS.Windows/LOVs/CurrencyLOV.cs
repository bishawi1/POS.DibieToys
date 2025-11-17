
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.LOVs
{
    public partial class CurrencyLOV : Form
    {
        public bool mboolAccepted = false;
        public DataTable moDataTable;

        public CurrencyLOV()
        {
            InitializeComponent();
        }
        public int getSelectedCurrencyId()
        {
            if (grdCurrencyList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdCurrencyList.Rows[grdCurrencyList.CurrentCell.RowIndex].Cells[colCurrency_ID.Name].Value);
            }
        }

        public string getSelectedCurrencyName()
        {
            if (grdCurrencyList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdCurrencyList.Rows[grdCurrencyList.CurrentCell.RowIndex].Cells[colCurrency_Name.Name].Value.ToString();
            }
        }
        private async void applySearch()
        {
            try
            {
                DataRow[] rows = General.CurrenciesDatatable.Select("Currency_Name Like '%" + txtCurrencyName.Text + "%'");
                if (rows.Count() > 0)
                {
                    grdCurrencyList.AutoGenerateColumns = false;
                    grdCurrencyList.DataSource = rows.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }
        public void initForm()
        {
            grdCurrencyList.AutoGenerateColumns = false;
            grdCurrencyList.DataSource = General.CurrenciesDatatable;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdCurrencyList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Close();
        }

        private void grdCurrencyList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCurrencyName_TextChanged(object sender, EventArgs e)
        {
            applySearch();
        }

        private void txtCurrencyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                grdCurrencyList.Focus();
            else if (e.KeyCode == Keys.Escape)
            {
                mboolAccepted = false;
                this.Hide();
            }
        }

        private void grdCurrencyList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void grdCurrencyList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCurrencyList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }
    }
}
