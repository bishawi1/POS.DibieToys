using Microsoft.EntityFrameworkCore.Query;
using POS.Client;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Windows.Components;
using POS.Windows.Components.ViewModels;
using POS.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{
    public partial class POSForm : Form
    {
        private SoldItemListComponent currentInvoice;
        List<SoldItemComponentViewModel> soldItems = new List<SoldItemComponentViewModel>();
        private bool isBacked = false;

        public POSForm()
        {
            InitializeComponent();
        }
        public void draw()
        {

            List<Item_GroupModel> list = General.retSubItemGroupList(0);
            subCategoryComponent.clearContent();
            subCategoryComponent.drawCategories(list, new Components.ViewModels.RoundedButtonStyleViewModel
            {
                ButtonHeight = 50,
                TextColor = Color.Black,
                BackColor = Color.YellowGreen,// Color.LightYellow,
                ButtonFont = new Font(this.Font.FontFamily, 14, FontStyle.Bold),
                BorderSize = 1,
                ButtonSize = new Size(200, 50)
            });

        }
        private void initInvoice()
        {
            SoldItemListComponent component = new SoldItemListComponent();
            component.Branch_ID = General.branchId;
            soldItems.Add(new SoldItemComponentViewModel()
            {
                Component = component,
                Id = "1" //btnInvoice0.Name
            });
            component.OnInvoiceCancelClick += new EventHandler(OnInvoiceCancelClick);
            pnlInvoices.Controls.Add(component);
            currentInvoice = component;
            component.Dock = DockStyle.Fill;
            component.Visible = true;
        }
        private string getScreenResilution()
        {
            Screen primaryScreen = Screen.PrimaryScreen;
            Rectangle resolution = primaryScreen.Bounds;
            int screenWidth = resolution.Width;
            int screenHeight = resolution.Height;
            if(screenWidth >= 1920 && screenHeight >= 1080)
            {
                return "HD";
            }
            else if (screenWidth >= 1366 && screenHeight >= 768)
            {
                return "SD";
            }
            else
            {
                return "LOW";
            }
        }
        private void setSize()
        {
            string screenSize = getScreenResilution();
            if (screenSize == "HD")
            {
                this.Size = new Size(1920, 880);
            }
            else if (screenSize == "SD")
            {
                this.Size = new Size(1366, 768);
            }
            else
            {
                this.Size = new Size(1024, 600);
            }
    }
        public void initForm(bool isBacked = false)
        {
            try
            {
                setSize();
                initInvoice();
                this.isBacked = isBacked;
                currentInvoice.IsBacked = isBacked;
                if (isBacked)
                {
                    this.BackColor = Color.Magenta;
                }
                //Task.Run(async () => General.LoadItems(0));
                //Task.Run(async () => General.loadItemGroupsAsync());
                //await General.LoadItems();
                //General.loadItemGroupsAsync();
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void removeInvoice()
        {
            currentInvoice.clearScreen();
        }
        protected void OnInvoiceCancelClick(object sender, EventArgs e)
        {
            removeInvoice();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (General.itemList != null)
            {
                timer1.Enabled = false;
                draw();
            }
        }

        private void subCategoryComponent_OnCategoryClick(object sender, EventArgs e)
        {
            Item_GroupModel model = (Item_GroupModel)sender;
            categoryProductComponent1.drawCategoryProducts(General.retItemGroupItemList(model.Item_Group_ID));
        }

        private void categoryProductComponent1_OnProductClick(object sender, EventArgs e)
        {
            bool resetItemUnitPrice = false;
            ProductUserControl product = (ProductUserControl)sender;
            if (product.Product.Item_Unit_Price == 0)
            {
                ManualProductUnitPriceDialog frm = new ManualProductUnitPriceDialog();
                frm.ShowDialog();
                if (frm.Accepted)
                {
                    product.Product.Item_Unit_Price = Convert.ToDecimal(frm.lblItemUnitPrice.Text);
                    product.Product.Item_Unit_Cost = (product.Product.Item_Unit_Price / 2);
                    resetItemUnitPrice = true;
                }
            }
            if (product.Product.Item_Unit_Price > 0)
            {
                SoldItemViewModel soldItem = new SoldItemViewModel
                {
                    Item_Desc = product.Product.Item_Desc,
                    Item_ID = product.Product.Item_ID,
                    Item_Unit_Cost = product.Product.Item_Unit_Cost,
                    Item_Unit_ID = product.Product.Item_Unit_ID,
                    Item_Unit_Price = product.Product.Item_Unit_Price,
                    QNT = 1,
                    TotalAmount = 1 * product.Product.Item_Unit_Price,
                    Unit_Desc = product.Product.Unit_Desc,
                    Unit_ID = product.Product.Unit_ID
                };
                currentInvoice.AddItem(soldItem);
                if (resetItemUnitPrice)
                {
                    product.Product.Item_Unit_Price = 0;
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }



        private void tsbtnRemoveInvoice_Click(object sender, EventArgs e)
        {
            currentInvoice.clearScreen();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            currentInvoice.fireSaveInvoice();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currentInvoice.fireSaveInvoiceWithoutPrint();
        }
        private void showSoldItemComponent(CheckBox button)
        {
            SoldItemComponentViewModel itemControl = soldItems.Where(r => r.Id == button.Name).FirstOrDefault();
            if (itemControl != null)
            {
                currentInvoice = itemControl.Component;

                pnlInvoices.Controls.Clear();
                pnlInvoices.Controls.Add(currentInvoice);
                currentInvoice.Visible = true;
                //soldItems.Remove(itemControl);
                //flowLayoutPanel1.Controls.Remove(button);

            }

        }
        private void addInvoice(int salesTransactionId=0)
        {
            CheckBox btnInvoice0 = new System.Windows.Forms.CheckBox();
            btnInvoice0.Appearance = System.Windows.Forms.Appearance.Button;
            btnInvoice0.Checked = true;
            btnInvoice0.BackColor = Color.LightGreen;

            btnInvoice0.Visible = true;

            SoldItemListComponent component = new SoldItemListComponent();
            component.Branch_ID = General.branchId;
            soldItems.Add(new SoldItemComponentViewModel()
            {
                Component = component,
                Id = btnInvoice0.Name
            });
            component.OnInvoiceCancelClick += new EventHandler(OnInvoiceCancelClick);
            
            //component.OnInvoiceSaved += new EventHandler(OnInvoiceSaved);
            
            if(salesTransactionId>0)
                component.EditSalesTransaction(salesTransactionId);

            component.FirstInvoice = false;
            pnlInvoices.Controls.Add(component);
            currentInvoice = component;
            component.Dock = DockStyle.Fill;
            component.Visible = true;

            showSoldItemComponent(btnInvoice0);
        }

        private async void tsbtnPrevInvoices_Click(object sender, EventArgs e)
        {
            SaleTransactionRepository repository = new SaleTransactionRepository();
            SalesQueryCriteriaViewModel criteria = new SalesQueryCriteriaViewModel();
            criteria.From_Transaction_Date = $"{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}";
            //criteria.To_Transaction_Date = Convert.ToDateTime($"{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}");

            ResultModel result = await SaleTransactionRepository.getAll(criteria);
            if (result != null)
            {
                if (result.StatusCode == "200")
                {
                    DataTable dt = General.ConvertToDataTable(result.Data);
                    TodaySalesListForm frm = new TodaySalesListForm();
                    frm.initForm(dt);
                    frm.ShowDialog();
                    if (frm.Accepted)
                    {
                        addInvoice(frm.SelectedSalesTransactionId());
                    }
                }
            }

        }
    }
}
