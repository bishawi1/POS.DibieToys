using POSApp.Services.Models;
using POSApp.Services.Repositories;
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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        private void initForm()
        {
            InvoiceRepository repository = new InvoiceRepository(General.Connection);
            DataTable moSoldItemsDatatable = repository.GetInvoiceDetails(-99);
            ProductRepository productRepository = new ProductRepository(General.Connection);
            List<CategoryModel> Categories = productRepository.GetCategories();
            categoryComponent1.drawCategories(Categories);
            //grdSoldItems.AutoGenerateColumns = false;
            //grdSoldItems.DataSource = moSoldItemsDatatable;
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            if (General.Connection == null)
            {
                General.Connection = new Microsoft.Data.SqlClient.SqlConnection();
                General.Connection.ConnectionString = Constants.ConnectionString;
                General.Connection.Open();
            }
            initForm();

        }

        private void categoryComponent1_OnCategoryClick(object sender, EventArgs e)
        {
            CategoryModel model = (CategoryModel)sender;
            MessageBox.Show(model.Category);
        }
    }
}
