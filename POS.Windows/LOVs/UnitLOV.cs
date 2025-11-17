using POS.DAL.Repositories;
using POS.Shared.Models;
using POS.Windows.Services.Repository;
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
    public partial class UnitLOV : Form
    {
        public bool mboolAccepted = false;
        private byte mintItemGroupID = 0;
        public DataTable moDataTable;
        public bool newUnit = false;
        public string unitDesc = string.Empty;
        public int unitID = 0;
        public UnitLOV()
        {
            InitializeComponent();
        }
        public int getSelectedUnitId()
        {
            if (newUnit)
                return unitID;
            else if (grdUnitLIst.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdUnitLIst.Rows[grdUnitLIst.CurrentCell.RowIndex].Cells[colUnit_ID.Name].Value);
            }
        }
        public string getSelectedUnitDesc()
        {
            if (newUnit)
                return unitDesc;
            if (grdUnitLIst.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdUnitLIst.Rows[grdUnitLIst.CurrentCell.RowIndex].Cells[colUnit_Desc.Name].Value.ToString();
            }
        }

        private async Task applySearch()
        {
            try
            {
                moDataTable = General.UnitsDatatable.Copy();
                //SQLUnitRepository repository = new SQLUnitRepository(General.dataContext);
                //List<UnitModel> units = await repository.getAllAsync("", "", "");
                //moDataTable = General.ConvertToDataTable(units);
                grdUnitLIst.AutoGenerateColumns = false;
                grdUnitLIst.DataSource = moDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public void initForm()
        {
            applySearch();
            grdUnitLIst.AutoGenerateColumns = false;
            grdUnitLIst.DataSource = moDataTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdUnitLIst.CurrentRow != null)
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

        private void grdUnitLIst_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUnitLIst.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }

        private void grdUnitLIst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                mboolAccepted = true;
                this.Hide();
            }
        }
    }
}
