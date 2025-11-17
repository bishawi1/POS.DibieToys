using Microsoft.Identity.Client;
using POS.Shared.Models;
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
    public partial class SoldItemListComponent : UserControl
    {
        private DataTable moDataTable;
        public void AddItem(SoldItemViewModel item)
        {
            if (moDataTable == null)
            {
                List<SoldItemViewModel> soldItems = new List<SoldItemViewModel>();
                soldItems.Add(item);
                moDataTable = General.ConvertToDataTable(soldItems);
            }
            else
            {
                DataRow row = moDataTable.NewRow();
                row[colItem_Desc.DataPropertyName] = item.Item_Desc;
                row[colQnt.DataPropertyName] = item.QNT;
                row[colItem_ID.DataPropertyName] = item.Item_ID;
                row[colItem_Unit_Cost.DataPropertyName] = item.Item_Unit_Cost;
                row[colItem_Unit_ID.DataPropertyName]=item.Item_Unit_ID;
                row[colItem_Unit_Price.DataPropertyName] = item.Item_Unit_Price;
                row[colTotalAmount.DataPropertyName]=(item.QNT * item.Item_Unit_Price);
                row[colUnit_ID.DataPropertyName] = item.Unit_ID;
                row[colUnit_Desc.DataPropertyName] = item.Unit_Desc;
                row[colIncrease.DataPropertyName] = "+";
                row[colDescrease.DataPropertyName] = "-";
                moDataTable.Rows.Add(row);
            }
                txtTotalAmount.Value = calcTotalAmount();
            grdItemList.AutoGenerateColumns = false;
            grdItemList.DataSource = moDataTable;
            var uniqueObjects = moDataTable.AsEnumerable().Select(x => x.Field<Int64>("Item_ID")).Distinct().ToList();
            txtItemCount.Value = uniqueObjects.Count();
        }
        private decimal calcTotalAmount()
        {
            decimal itemPriceTotal = 0;
            decimal discountAmount = 0;
            int itemCount = 0;

            decimal totalAmount = 0;
            foreach (DataRow band in moDataTable.Rows)
            {
                itemPriceTotal += Convert.ToDecimal(band[colTotalAmount.DataPropertyName]);
                //creditAmount += Convert.ToDecimal(band[colCredit_Voucher_Detail_Amount.DataPropertyName]);
                itemCount += 1;
            }
            totalAmount = Math.Abs(itemPriceTotal - discountAmount);
            return totalAmount;
        }
        public SoldItemListComponent()
        {
            InitializeComponent();
        }

        private void grdItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdItemList_SelectionChanged(object sender, EventArgs e)
        {
            if (grdItemList.CurrentRow != null)
            {
                txtQnt.Value = Convert.ToDecimal(grdItemList.CurrentRow.Cells[colQnt.Name].Value);
            }
        }
        private void reCalculateItemPrice()
        {
            if (grdItemList.CurrentRow != null)
            {
                decimal itemUnitPrice =Convert.ToDecimal(grdItemList.CurrentRow.Cells[colItem_Unit_Price.Name].Value);
                grdItemList.CurrentRow.Cells[colTotalAmount.Name].Value = (txtQnt.Value * itemUnitPrice);
                grdItemList.Update();
                txtTotalAmount.Value= calcTotalAmount();
            }
        }
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if(grdItemList.CurrentRow != null)
            {
                txtQnt.Value += 1;
                grdItemList.CurrentRow.Cells[colQnt.Name].Value = txtQnt.Value;
                grdItemList.Update();
                reCalculateItemPrice();
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (txtQnt.Value > 1)
            {
                if (grdItemList.CurrentRow != null)
                {
                    txtQnt.Value -= 1;
                    grdItemList.CurrentRow.Cells[colQnt.Name].Value = txtQnt.Value;
                    grdItemList.Update();
                    reCalculateItemPrice();
                }
            }
        }
    }
}
