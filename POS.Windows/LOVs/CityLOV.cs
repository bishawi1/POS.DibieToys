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
    public partial class CityLOV : Form
    {
        public bool mboolAccepted = false;
        public DataTable moDataTable;
        public bool newCity = false;
        public string cityName = string.Empty;
        public int cityId = 0;

        public CityLOV()
        {
            InitializeComponent();
        }
        public int getSelectedCityId()
        {
            if (newCity)
                return cityId;
            else if (grdCityList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdCityList.Rows[grdCityList.CurrentCell.RowIndex].Cells[colCity_ID.Name].Value);
            }
        }

        public string getSelectedCityName()
        {
            if (newCity)
                return cityName;
            else if (grdCityList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdCityList.Rows[grdCityList.CurrentCell.RowIndex].Cells[colCity_Name.Name].Value.ToString();
            }
        }
        private async void applySearch()
        {
            try
            {
                DataRow[] rows = General.CitiesDatatable.Select("City_Name Like '%" + txtCityName.Text + "%'");
                if (rows.Count() > 0)
                {
                    grdCityList.AutoGenerateColumns = false;
                    grdCityList.DataSource = rows.CopyToDataTable();
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
            grdCityList.AutoGenerateColumns = false;
            grdCityList.DataSource = General.CitiesDatatable;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdCityList.CurrentRow != null)
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

        private void grdCityList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdCityList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCityName_TextChanged(object sender, EventArgs e)
        {
            applySearch();
        }

        private void txtCityName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                grdCityList.Focus();
            else if (e.KeyCode == Keys.Escape)
            {
                mboolAccepted = false;
                this.Hide();
            }
        }

        private void grdCityList_KeyDown(object sender, KeyEventArgs e)
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
            //CityForm frm = new CityForm();
            //frm.initForm();
            //frm.ShowDialog();
            //if (frm.mboolAccepted)
            //{
            //    newCity = true;
            //    cityId = frm.LastAddedCityId;
            //    cityName = frm.LastAddedCityName;
            //    frm.Close();
            //    frm.Dispose();
            //    mboolAccepted = true;
            //    this.Hide();

            //}
        }

        private void grdCityList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCityList.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }
    }
}
