using Microsoft.Identity.Client;
using POS.Shared.Models;
using POS.Windows.Components;
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
        public bool drawCategories(List<Item_GroupModel> Categories)
        {
            Button button;
            foreach (Item_GroupModel category in Categories)
            {
                button = new RoundedButton();
                //button.BackColor = Color.Green;
                button.Height = 35;
                button.Text = category.Item_Group_Desc;
                button.Name = "Cat" + category.Item_Group_ID.ToString();
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
            Item_GroupModel category = (Item_GroupModel)button.Tag;
            if(OnCategoryClick!= null)
                OnCategoryClick.Invoke(category, e);
            //drawProductButtons(category.Id);
            ////MessageBox.Show(button.Tag.ToString());
        }

        public void clearContent()
        {
            pnlContent.Controls.Clear();
        }
    }
}
