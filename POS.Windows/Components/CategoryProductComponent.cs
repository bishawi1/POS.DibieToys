using POS.DAL.Repositories;
using POS.Shared.Models;
using POS.Shared.ViewModels;
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
        public bool drawCategoryProducts(List<vItem_UnitModel> products)
        {
            pnlContent.VerticalScroll.Enabled = true;
            ProductUserControl product;
            foreach (vItem_UnitModel model in products)
            {
                product = new ProductUserControl();
                product.Product = model;
                product.Text = product.Name;
                product.Visible = true;
                product.Tag = product;
                //product.Click += new EventHandler(CategoryProductButtonClick);
                product.OnProductClick += new EventHandler(ProductButtonClick);
                pnlContent.Controls.Add(product);
            }
            return true;
        }
        protected void ProductButtonClick(object sender, EventArgs e)
        {
            ProductUserControl product = (ProductUserControl)sender;
            vItem_UnitModel model = (vItem_UnitModel)product.Product;
            
            if (OnProductClick != null)
                OnProductClick.Invoke(product, e);
            //MessageBox.Show(button.Tag.ToString());
        }

    }
}
