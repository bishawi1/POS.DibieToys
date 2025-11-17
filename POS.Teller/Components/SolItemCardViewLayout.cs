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

namespace POS.Windows.Components
{
    public partial class SolItemCardViewLayout : UserControl
    {
        private DataTable moDataTable;

        public SolItemCardViewLayout()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //private void reCalculateItemPrice()
        //{
        //    if (grdItemList.CurrentRow != null)
        //    {
        //        decimal itemUnitPrice = Convert.ToDecimal(grdItemList.CurrentRow.Cells[colItem_Unit_Price.Name].Value);
        //        grdItemList.CurrentRow.Cells[colTotalAmount.Name].Value = (Convert.ToInt32(grdItemList.CurrentRow.Cells[colQnt.Name].Value) * itemUnitPrice);
        //        grdItemList.Update();
        //        txtTotalAmount.Value = calcTotalAmount();
        //    }
        //}
        //public void AddItem(SoldItemViewModel item)
        //{
        //    if (moDataTable == null)
        //    {
        //        List<SoldItemViewModel> soldItems = new List<SoldItemViewModel>();
        //        soldItems.Add(item);
        //        moDataTable = General.ConvertToDataTable(soldItems);
        //    }
        //    else
        //    {
        //        //DataGridViewRow newRow = new DataGridViewRow();
        //        //newRow.
        //        DataRow row = moDataTable.NewRow();
        //        row["Item_Desc"] = item.Item_Desc;
        //        row["Qnt"] = item.Qnt;
        //        row["Item_ID"] = item.Item_ID;
        //        row["Item_Unit_Cost"] = item.Item_Unit_Cost;
        //        row["Item_Unit_ID"] = item.Item_Unit_ID;
        //        row["Item_Unit_Price"] = item.Item_Unit_Price;
        //        row["TotalAmount.DataPropertyName"] = (item.Qnt * item.Item_Unit_Price);
        //        row["Unit_ID"] = item.Unit_ID;
        //        row["Unit_Desc"] = item.Unit_Desc;
        //        row["Increase"] = "+";
        //        row["Descrease"] = "-";
        //        moDataTable.Rows.Add(row);
        //    }
        //    txtTotalAmount.Value = calcTotalAmount();
        //    grdItemList.AutoGenerateColumns = false;
        //    grdItemList.DataSource = moDataTable;
        //    var uniqueObjects = moDataTable.AsEnumerable().Select(x => x.Field<Int64>("Item_ID")).Distinct().ToList();
        //    txtItemCount.Value = uniqueObjects.Count();
        //}

    }
}
