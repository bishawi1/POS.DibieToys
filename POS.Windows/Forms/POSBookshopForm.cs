using POS.DAL;
using POS.DAL.Repositories;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.Components;
using POS.Windows.Services.Repository;
using POSApp;
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
    public partial class POSBookshopForm : Form
    {
        public POSBookshopForm()
        {
            InitializeComponent();
        }
        public async Task InitForm()
        {
            MaincategoryList.pnlContentBase.BackColor = Color.SteelBlue;
            SQLItem_GroupRepository repository = new(General.dataContext);
            //DataTable dt =
            List<Item_GroupModel> Categories = await repository.getSubItemGroupsAsync(0);
            //            List<Item_GroupModel> Categories = new List<Item_GroupModel>();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Categories.Add(
            //    new Item_GroupModel
            //    {
            //        Item_Group_ID = Convert.ToByte(dr["Item_Group_ID"]),
            //        Item_Group_Desc = Convert.ToString(dr["Item_Group_Desc"]),
            //    });
            //}
            MaincategoryList.drawCategories(Categories);
            for (int i = 0; i < 10; i++)
            {
                POSItemUserControl item = new POSItemUserControl();
                item.Visible = true;

                flowLayoutPanel1.Controls.Add(item);
            }
            //DataTable moSoldItemsDatatable = repository.GetInvoiceDetails(-99);
            //ProductRepository productRepository = new ProductRepository(General.Connection);
            //List<CategoryModel> Categories = productRepository.GetCategories();
            //categoryComponent1.drawCategories(Categories);
        }

        private async void MaincategoryList_OnCategoryClick(object sender, EventArgs e)
        {
            Item_GroupModel model = (Item_GroupModel)sender;

            SQLItem_GroupRepository repository = new(General.dataContext);
            List<Item_GroupModel> Categories;
            Categories = await repository.getSubItemGroupsAsync(model.Item_Group_ID);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Categories.Add(
            //    new Item_GroupModel
            //    {
            //        Item_Group_ID = Convert.ToByte(dr["Item_Group_ID"]),
            //        Item_Group_Desc = Convert.ToString(dr["Item_Group_Desc"]),
            //    });
            //}
            SubCategoryList.clearContent();
            SubCategoryList.drawCategories(Categories);

        }

        private async void SubCategoryList_OnCategoryClick(object sender, EventArgs e)
        {
            Item_GroupModel model = (Item_GroupModel)sender;
            SQLvItem_UnitRepository repository = new(General.dataContext);
            List<vItem_UnitModel> list = new List<vItem_UnitModel>();
            DataTable dt = new DataTable();
            ItemListCriteriaViewModel criteria = new();
            criteria.Item_Group_ID = model.Item_Group_ID;
            list = await repository.getAllAsync(criteria);
            categoryProductListComponent.clearContent();

            categoryProductListComponent.drawCategoryProducts(list);
        }

        private void categoryProductComponent1_OnProductClick(object sender, EventArgs e)
        {
            ProductUserControl product = (ProductUserControl)sender;
            SoldItemViewModel soldItem = new SoldItemViewModel
            {
                Item_Desc = product.Product.Item_Desc,
                Item_ID = product.Product.Item_ID,
                Item_Unit_Cost = product.Product.Item_Unit_Cost,
                Item_Unit_ID = product.Product.Item_Unit_ID,
                Item_Unit_Price = product.Product.Item_Unit_Price,
                QNT = 1,
                TotalAmount = 1 * product.Product.Item_Unit_Price,
                Unit_Desc = product.Product.Unit_Desc,
                Unit_ID = product.Product.Unit_ID
            };
            soldItemListComponent1.AddItem(soldItem);
        }

        private void MaincategoryList_Load(object sender, EventArgs e)
        {

        }

        private void SubCategoryList_Load(object sender, EventArgs e)
        {

        }
    }
}
