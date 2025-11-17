using POS.DAL.Repositories;
using POS.Shared.Models;
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

namespace POS.Windows.Forms
{
    public partial class ItemBrandListForm : Form
    {
        public ItemBrandListForm()
        {
            InitializeComponent();
        }
        private async Task getData()
        {
            SQLItem_BrandRepository repository = new (General.dataContext);
            List<Item_BrandModel>brands =await repository.getAllAsync("","","");
            grdBrandList.AutoGenerateColumns = false;
            grdBrandList.DataSource = brands;
        }
        public void InitForm()
        {
            getData();
        }
    }
}
