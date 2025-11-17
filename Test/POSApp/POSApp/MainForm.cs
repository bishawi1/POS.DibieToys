using POSApp.Services.Models;
using POSApp.Services.Repositories;
using System.Data;

namespace POSApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void drawCategoyButtons()
        {
            ProductRepository repository = new ProductRepository(General.Connection);
            List<CategoryModel> Categories = repository.GetCategories();
            Button button;
            foreach (CategoryModel category in Categories)
            {
                button = new Button();
                button.Text = category.Category;
                button.Name = "Cat" + category.Id.ToString();
                button.Visible = true;
                button.Tag = category;
                button.Click += new EventHandler(drawCategoryButtonClick);
                pnlCategory.Controls.Add(button);
            }
        }
        protected void drawCategoryButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            CategoryModel category = (CategoryModel)button.Tag;
            drawProductButtons(category.Id);
            //MessageBox.Show(button.Tag.ToString());
        }
        private void drawProductButtons(int categoryId)
        {
            pnlCategoryProducts.Controls.Clear();
            pnlCategoryProducts.VerticalScroll.Enabled = true;
            ProductUserControl product;
            ProductRepository repository = new ProductRepository(General.Connection);
            List<ProductModel> products = repository.GetProduct(categoryId);
            foreach (ProductModel model in products)
            {
                product = new ProductUserControl();
                product.Product = model;
                product.Text = product.Name;
                product.Visible = true;
                product.Tag = product;
                //product.Click += new EventHandler(CategoryProductButtonClick);
                product.OnProductClick += new EventHandler(ProductButtonClick);
                pnlCategoryProducts.Controls.Add(product);
            }
        }
        private void initForm()
        {
            InvoiceRepository repository = new InvoiceRepository(General.Connection);
            DataTable moSoldItemsDatatable = repository.GetInvoiceDetails(-99);
            grdSoldItems.AutoGenerateColumns = false;
            grdSoldItems.DataSource = moSoldItemsDatatable;
        }
        protected void ProductButtonClick(object sender, EventArgs e)
        {
            ProductUserControl product = (ProductUserControl)sender;
            ProductModel model = (ProductModel)product.Product;
            MessageBox.Show(model.Product_Name);
        }
        private void tlBasic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Set_Day_Name();
            if (General.Connection == null)
            {
                General.Connection = new Microsoft.Data.SqlClient.SqlConnection();
                General.Connection.ConnectionString = Constants.ConnectionString;
                General.Connection.Open();
            }
            initForm();

            drawCategoyButtons();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Set_Day_Name()
        {
            switch (dtToday.Value.DayOfWeek)
            {
                case (DayOfWeek)0:
                    lblDay_Name.Text = "الاحد";
                    break;
                case (DayOfWeek)1:
                    lblDay_Name.Text = "الاثنين";
                    break;
                case (DayOfWeek)2:
                    lblDay_Name.Text = "الثلاثاء";
                    break;
                case (DayOfWeek)3:
                    lblDay_Name.Text = "الاربعاء";
                    break;
                case (DayOfWeek)4:
                    lblDay_Name.Text = "الخميس";
                    break;
                case (DayOfWeek)5:
                    lblDay_Name.Text = "الجمعة";
                    break;
                case (DayOfWeek)6:
                    lblDay_Name.Text = "السبت";
                    break;
            }
        }
        private void dtToday_ValueChanged(object sender, EventArgs e)
        {
            Set_Day_Name();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm frm = new TestForm();
            frm.Show();
        }
    }
}
