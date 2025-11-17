using Microsoft.Reporting.Map.WebForms.BingMaps;
using POS.Client;
using POS.DAL.Repositories;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.Forms.Lookups;
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
    public partial class ItemBrandLOV : Form
    {
        public bool mboolAccepted = false;
        private byte mintItemBrandID = 0;
        public DataTable moDataTable;
        public bool newItemBrand = false;
        public string itemBrandName = string.Empty;
        public int itemBrandId = 0;

        public ItemBrandLOV()
        {
            InitializeComponent();
        }
        public int getSelectedItemBrandId()
        {
            if (newItemBrand)
                return itemBrandId;
            else if (grdBrandList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdBrandList.Rows[grdBrandList.CurrentCell.RowIndex].Cells[colItem_Brand_ID.Name].Value);
            }
        }
        public string getSelectedItemBrandName()
        {
            if (newItemBrand)
                return itemBrandName;
            if (grdBrandList.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdBrandList.Rows[grdBrandList.CurrentCell.RowIndex].Cells[colItem_Brand_Name.Name].Value.ToString();
            }
        }

        private async Task applySearch()
        {

            try
            {

                if (string.IsNullOrEmpty(txtItem_Brand_Name.Text.Trim()))
                {
                    moDataTable = General.ItemBrandsDatatable;
                    grdBrandList.AutoGenerateColumns = false;
                    grdBrandList.DataSource = moDataTable;
                }
                else
                {
                    DataRow[] rows = General.ItemBrandsDatatable.Select("Item_Brand_Name Like '%" + txtItem_Brand_Name.Text + "%'");
                    if (rows.Count() > 0)
                    {
                        grdBrandList.AutoGenerateColumns = false;
                        grdBrandList.DataSource = rows.CopyToDataTable();
                    }
                }
                //ItemBrandRepository repository = new ItemBrandRepository();
                //ResultModel result = await repository.getAllAsync();

                //moDataTable = General.ConvertToDataTable(result.Data);

                //grdBrandList.AutoGenerateColumns = false;
                //grdBrandList.DataSource = moDataTable;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void initForm()
        {
            applySearch();
            grdBrandList.AutoGenerateColumns = false;
            grdBrandList.DataSource = moDataTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdBrandList.CurrentRow != null)
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

        private void grdBrandList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mboolAccepted = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemBrandDialog frm = new ItemBrandDialog();
            frm.initForm();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                newItemBrand = true;
                itemBrandId = frm.LastAddedItemBrandId;
                itemBrandName = frm.LastAddedItemBrandName;
                General.LoadItemBrands();
                frm.Close();
                frm.Dispose();
                mboolAccepted = true;
                this.Hide();

            }
        }

        private void txtItem_Brand_Name_TextChanged(object sender, EventArgs e)
        {
            applySearch();
        }

        private void grdBrandList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                mboolAccepted = true;
                this.Hide();
            }

        }

        private void grdBrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

