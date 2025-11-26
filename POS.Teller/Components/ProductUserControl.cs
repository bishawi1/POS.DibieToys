using POS.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Teller.Components
{
    public partial class ProductUserControl : UserControl
    {
        public event EventHandler OnProductClick;
        //public delegate void UserControlClickHandler(object sender, EventArgs e);

        public vBranch_Item_UnitModel _product;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public vBranch_Item_UnitModel Product
        {
            get { return _product; }
            set
            {
                _product = value;
                lblItem_Name.Text = _product.Item_Desc;
                lblPrice.Text = _product.Item_Unit_Price.ToString();
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

        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            OnProductClick.Invoke(this, e);
        }
    }
}
