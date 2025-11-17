using POS.Shared.DTOs;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows.Forms
{
    public partial class SearchForItemDialog : Form
    {
        public bool mboolAccepted = false;
        private byte mintItemBrandID = 0;
        public DataTable moDataTable;
        public bool newItemDesc = false;
        public string itemBrandName = string.Empty;
        public int itemId = 0;
        public SearchForItemDialog()
        {
            InitializeComponent();
        }

        private void SearchForItemDialog_Load(object sender, EventArgs e)
        {

        }
        public int getSelectedItemUnitId()
        {
            if (newItemDesc)
                return itemId;
            else if (grdItems.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return Convert.ToInt32(grdItems.Rows[grdItems.CurrentCell.RowIndex].Cells[colItem_Unit_ID.Name].Value);
            }
        }
        public string getSelectedItemName()
        {
            if (newItemDesc)
                return itemBrandName;
            if (grdItems.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdItems.Rows[grdItems.CurrentCell.RowIndex].Cells[colItem_Desc.Name].Value.ToString();
            }
        }
        public string getSelectedItemBarcode()
        {
            //if (newItemDesc)
            //    return itemBrandName;
            if (grdItems.CurrentCell == null)
            {
                throw new Exception("no record is selected");
            }
            else
            {
                return grdItems.Rows[grdItems.CurrentCell.RowIndex].Cells[colBarcode.Name].Value.ToString();
            }
        }
        private async void applySearchAsync()
        {
            //applySearch();
            ItemListCriteriaViewModel criteria = new ItemListCriteriaViewModel();
            if (!string.IsNullOrEmpty(txtItem_Desc.Text.Trim()))
                criteria.Item_Desc = txtItem_Desc.Text.Trim();

            General.Show_Wait_Form(Constants.mstrWaitingMessage);
            ResultModel result = await POS.Client.ItemQueryRepository.getAll(criteria);
            if (result.StatusCode == "200")
            {
                DataTable dt = General.ConvertToDataTable(result.Data);
                grdItems.AutoGenerateColumns = false;
                grdItems.DataSource = dt;
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
            //ItemRepository itemRepository = new ItemRepository(General.Connection);
            //ItemListCriteriaViewModel criteria = new ItemListCriteriaViewModel();
            //DataTable dt = itemRepository.GetItemUnitLIst(criteria);
            //MessageBox.Show(dt.Rows.Count.ToString());

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            applySearchAsync();
        }

        private void grdItems_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mboolAccepted = true;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mboolAccepted = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mboolAccepted = false;
            this.Close();
        }
    }
}
