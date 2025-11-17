using Microsoft.IdentityModel.Tokens;
using POS.DAL.Repositories;
using POS.Shared.Models;
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
    public partial class ItemGroupLOV : Form
    {
        public bool mboolAccepted = false;
        private byte mintItemGroupID = 0;
        public DataTable moDataTable;
        public bool newItemGroup = false;
        public string itemGroupDesc = string.Empty;
        public int itemGroupID = 0;
        public ItemGroupLOV()
        {
            InitializeComponent();
        }
        public int getSelectedItemGroupID()
        {
            if (newItemGroup)
                return itemGroupID;
            else if (grdItemGroup.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdItemGroup.Rows[grdItemGroup.CurrentCell.RowIndex].Cells[colItem_Group_ID.Name].Value);
            }
        }
        public string getSelectedItemGroupDesc()
        {
            if (newItemGroup)
                return itemGroupDesc;
            if (grdItemGroup.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdItemGroup.Rows[grdItemGroup.CurrentCell.RowIndex].Cells[colItem_Group_Desc.Name].Value.ToString();
            }
        }

        private async Task applySearch()
        {
            try
            {
                if (string.IsNullOrEmpty(txtItem_Group_Desc.Text.Trim()))
                {
                    //moDataTable = General.ItemGroupsDatatable.Copy();
                    grdItemGroup.AutoGenerateColumns = false;
                    grdItemGroup.DataSource = moDataTable;
                }
                else
                {
                    DataRow[] rows = General.ItemGroupsDatatable.Select("Item_Group_Desc Like '%" + txtItem_Group_Desc.Text + "%'");
                    if (rows.Count() > 0)
                    {
                        grdItemGroup.AutoGenerateColumns = false;
                        grdItemGroup.DataSource = rows.CopyToDataTable();
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (grdItemGroup.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Hide();
            }
        }
        public void initForm(byte ItemGroupID)
        {
            mintItemGroupID = ItemGroupID;
            applySearch();
            grdItemGroup.AutoGenerateColumns = false;
            grdItemGroup.DataSource = moDataTable;
        }
        public void initForm()
        {
            DataRow[] rows = General.ItemGroupsDatatable.Select("Item_Group_ID > 0 And Parent_Item_Group_ID <> 0");
            moDataTable = rows.CopyToDataTable();
            applySearch();
            grdItemGroup.AutoGenerateColumns = false;
            grdItemGroup.DataSource = moDataTable;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearch();
        }

        private void grdItemGroup_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdItemGroup.CurrentRow != null)
            {
                mboolAccepted = true;
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemGroupDialog frm = new ItemGroupDialog();
            frm.initForm();
            frm.ShowDialog();
            if (frm.mboolAccepted)
            {
                newItemGroup = true;
                itemGroupID = frm.LastAddedItemGroupId;
                itemGroupDesc = frm.LastAddedItemGroupDesc;
                General.LoadItemGroups();
                frm.Close();
                frm.Dispose();
                mboolAccepted = true;
                this.Hide();
            }
        }

        private void txtItem_Group_Desc_TextChanged(object sender, EventArgs e)
        {
            applySearch();
        }

        private void grdItemGroup_KeyDown(object sender, KeyEventArgs e)
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
