using POS.Client;
using POS.Shared.DTOs;
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
    
    public partial class CustomerLov : Form
    {
        public bool mboolAccepted = false;
        public DataTable moDataTable;
        public CustomerLov()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdCustomerList.CurrentRow != null)
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

        public int getSelectedCustomerId()
        {
            if (grdCustomerList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdCustomerList.Rows[grdCustomerList.CurrentCell.RowIndex].Cells[colPerson_ID.Name].Value);
            }
        }
        public int getSelectedCustomerDiscountPercent()
        {
            if (grdCustomerList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdCustomerList.Rows[grdCustomerList.CurrentCell.RowIndex].Cells[colSell_Discount_Percent.Name].Value);
            }
        }

        public string getSelectedCustomerName()
        {
            if (grdCustomerList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdCustomerList.Rows[grdCustomerList.CurrentCell.RowIndex].Cells[colPerson_Name.Name].Value.ToString();
            }
        }


        private async void applySearch()
        {
            ResultModel oResult;
            CustomerRepository oRepos = new CustomerRepository();
            oResult = await oRepos.getAllAsync(txtPerson_Name.Text.Trim());
            if (oResult.StatusCode == "200")
            {
                grdCustomerList.AutoGenerateColumns = false;
                grdCustomerList.DataSource = General.ConvertToDataTable(oResult.Data);
            }
        }
        public void initForm()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void grdCustomerList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtPerson_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPerson_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                grdCustomerList.Focus();
            else if (e.KeyCode == Keys.Enter)
                applySearch();
            else if (e.KeyCode == Keys.Escape)
            {
                mboolAccepted = false;
                this.Hide();
            }
        }

        private void grdCustomerList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void grdCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCustomerList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }
    }
}
