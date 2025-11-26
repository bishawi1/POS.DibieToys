

using POS.Teller;
using POS.Teller.Lookups;
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
    public partial class BankLov : Form
    {
        public bool mboolAccepted = false;
        public DataTable moDataTable;
        public bool newBank = false;
        public string bankName = string.Empty;
        public int bankId = 0;


        public BankLov()
        {
            InitializeComponent();
        }
        public int getSelectedBankId()
        {
            if (newBank)
                return bankId;
            else if (grdBankList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdBankList.Rows[grdBankList.CurrentCell.RowIndex].Cells[colBank_No.Name].Value);
            }
        }

        public string getSelectedBankName()
        {
            if (newBank)
                return bankName;
            if (grdBankList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdBankList.Rows[grdBankList.CurrentCell.RowIndex].Cells[colBank_Name.Name].Value.ToString();
            }
        }

        private async void applySearch()
        {
            try
            {
                DataRow[] rows = General.BanksDatatable.Select("Bank_Name Like '%" + txtBankName.Text + "%'");
                if (rows.Count() > 0)
                {
                    grdBankList.AutoGenerateColumns = false;
                    grdBankList.DataSource = rows.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                throw;
            }


            //ResultModel oResult;
            //BankRepository oRepos = new BankRepository();
            //oResult = await oRepos.getAllAsync();
            //if (oResult.StatusCode == "200")
            //{
            //    grdBankList.AutoGenerateColumns = false;
            //    grdBankList.DataSource = General.ConvertToDataTable(oResult.Data);
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }
        public void initForm()
        {
            grdBankList.AutoGenerateColumns = false;
            grdBankList.DataSource = General.BanksDatatable;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdBankList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }

        private void grdBankList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBankName_TextChanged(object sender, EventArgs e)
        {
            applySearch();
        }

        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
                grdBankList.Focus();
            else if (e.KeyCode == Keys.Escape)
            {
                mboolAccepted = false;
                this.Hide();
            }
        }

        private void grdBankList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BankForm frm = new BankForm();
            frm.initForm();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                newBank = true;
                bankId = frm.LastAddedBankId;
                bankName = frm.LastAddedBankName;
                frm.Close();
                frm.Dispose();
                mboolAccepted = true;
                this.Hide();

            }
        }

        private void grdBankList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdBankList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }
    }
}
