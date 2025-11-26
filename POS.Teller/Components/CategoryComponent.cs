using Microsoft.Identity.Client;
using POS.Shared.Models;
using POS.Teller.Components.ViewModels;
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

namespace POS.Teller.Components
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
        public bool drawCategories(List<Item_GroupModel> Categories, RoundedButtonStyleViewModel style=null)
        {
            pnlContent.Controls.Clear();
            Button button;
            foreach (Item_GroupModel category in Categories)
            {
                button = new RoundedButton();
                //button.BackColor = Color.Green;
                if (style == null) 
                {
                    button.Height = 35;                   
                }
                else
                {
                    button.Height = style.ButtonHeight;
                    if(style.ButtonFont != null)
                    {
                        button.Font= style.ButtonFont;
                    }
                    if (style.TextColor != null)
                    {
                        button.ForeColor= (Color)style.TextColor;
                    }
                    if (style.BackColor != null)
                    {
                        button.BackColor = (Color)style.BackColor;
                    }
                    if(style.ButtonSize!= null)
                    {
                        button.Size = (Size)style.ButtonSize;
                    }

                    button.FlatAppearance.BorderSize = style.BorderSize;

                }

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
