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

namespace POS.Windows.Forms
{
    class ItemControl
    {
        public string Id { get; set; }
        public SoldItemListComponent component { get; set; }

    }
    public partial class Test : Form
    {
        List<ItemControl> soldItems = new List<ItemControl>();
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoldItemListComponent component = new SoldItemListComponent();
            Button btnInvoice0 = new Button();
            btnInvoice0.Text = soldItems.Count.ToString();
            btnInvoice0.Tag=component.Name;
            btnInvoice0.Click += new EventHandler(drawCategoryButtonClick);

            flowLayoutPanel1.Controls.Add(btnInvoice0);
            btnInvoice0.Visible = true;
            soldItems.Add(new ItemControl
            {
                component = component,
                Id=btnInvoice0.Name
            });
            component.Visible=true;
            panel1.Controls.Clear();
            panel1.Controls.Add(component);
        }
        protected void drawCategoryButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            ItemControl itemControl=soldItems.Where(r=>r.Id==button.Name).FirstOrDefault();
            if (itemControl != null)
            {
                panel1.Controls.Clear();
                soldItems.Remove(itemControl);
                flowLayoutPanel1.Controls.Remove(button);

            }
        }
    }
}
