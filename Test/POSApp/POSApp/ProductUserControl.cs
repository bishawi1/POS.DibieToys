using POSApp.Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApp
{
    public partial class ProductUserControl : UserControl
    {
        public event EventHandler OnProductClick;
        //public delegate void UserControlClickHandler(object sender, EventArgs e);

        public ProductModel _product;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ProductModel Product
        {
            get { return _product; }
            set
            {
                _product = value;
                lblItem_Name.Text = _product.Product_Name;
                lblPrice.Text = _product.Price.ToString();
            }
        }
        public ProductUserControl()
        {
            InitializeComponent();
        }

        private void lblItem_Name_Click(object sender, EventArgs e)
        {
            OnProductClick.Invoke(this, e);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            OnProductClick.Invoke(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnProductClick.Invoke(this, e);

        }
    }
}
