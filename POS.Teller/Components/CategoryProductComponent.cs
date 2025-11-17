using POS.DAL.Repositories;
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
    public partial class CategoryProductComponent : UserControl
    {

        public CategoryProductComponent()
        {
            InitializeComponent();
        }
        public event EventHandler OnProductClick;
        public void clearContent()
        {
            pnlContent.Controls.Clear();
        }
        public bool drawCategoryProducts(List<vBranch_Item_UnitModel> products)
        {
            pnlContent.Controls.Clear();
            pnlContent.AutoScroll = false;
            pnlContent.VerticalScroll.Enabled = true;
            pnlContent.VerticalScroll.Visible = true;
            //pnlContent.Dock = DockStyle.Fill;
            pnlContent.AutoScroll = true;
            ProductUserControl product;
            foreach (vBranch_Item_UnitModel model in products)
            {
                product = new ProductUserControl();
                product.Product = model;

                product.Text = product.Name;
                product.Visible = true;
                product.Tag = product;
                if (model.FileUrl != null)
                {
                    //product.ItemImage.Load($"{Client.Constants.ArchiveBaseUrl}/{model.FileUrl}");
                }                
                //product.Click += new EventHandler(CategoryProductButtonClick);
                product.OnProductClick += new EventHandler(ProductButtonClick);
                pnlContent.Controls.Add(product);
            }
            return true;
        }
        protected void ProductButtonClick(object sender, EventArgs e)
        {
            ProductUserControl product = (ProductUserControl)sender;
            vBranch_Item_UnitModel model = (vBranch_Item_UnitModel)product.Product;
            
            if (OnProductClick != null)
                OnProductClick.Invoke(product, e);
            //MessageBox.Show(button.Tag.ToString());
        }

    }
}
