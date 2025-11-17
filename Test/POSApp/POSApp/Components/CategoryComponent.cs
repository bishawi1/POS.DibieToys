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

namespace POSApp.Components
{
    public partial class CategoryComponent : UserControl
    {
        public CategoryComponent()
        {
            InitializeComponent();
        }
        public event EventHandler OnCategoryClick;

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public List<CategoryModel> Categories{ get; set; }
        public bool drawCategories(List<CategoryModel> Categories)
        {
            Button button;
            foreach (CategoryModel category in Categories)
            {
                button = new Button();
                button.Text = category.Category;
                button.Name = "Cat" + category.Id.ToString();
                button.Visible = true;
                button.Tag = category;
                button.Click += new EventHandler(drawCategoryButtonClick);
                pnlContent.Controls.Add(button);
            }
            return true;
        }
        protected void drawCategoryButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            CategoryModel category = (CategoryModel)button.Tag;
            if(OnCategoryClick!= null)
                OnCategoryClick.Invoke(category, e);
            //drawProductButtons(category.Id);
            ////MessageBox.Show(button.Tag.ToString());
        }
    }
}
