using POS.Client;
using POS.DAL.Contracts;
using POS.Shared.DTOs;
using POS.Shared.Models;
using POS.Shared.ViewModels;
using POS.Teller.Components;
using POS.Teller.Components.ViewModels;
using POS.Teller.Forms;
using POS.Windows.Components;
using POS.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Windows
{

    public partial class MainForm1 : Form
    {
        private SoldItemListComponent currentInvoice;
        private int invoiceSerial = 0;


        private bool _loading = true;
        private DataTable dtMainItemCategories;
        List<SoldItemComponentViewModel> soldItems = new List<SoldItemComponentViewModel>();

        private CheckBox selectedCheckBox = null;
        private void initTab()
        {
            //Button btnInvoice0 = new Button();
            CheckBox btnInvoice0 = new System.Windows.Forms.CheckBox();
            btnInvoice0.Appearance = System.Windows.Forms.Appearance.Button;
            btnInvoice0.Checked = true;

            btnInvoice0.Name = $"btnInvoice{invoiceSerial}";
            btnInvoice0.Height = btnAddInvoice.Height;
            btnInvoice0.Text = $"ÝÇÊæÑÉ {soldItems.Count.ToString()}";
            //btnInvoice0.Tag = component.Name;
            btnInvoice0.Click += new EventHandler(OnInvoiceClick);

            flowLayoutPanel1.Controls.Add(btnInvoice0);
            btnInvoice0.BackColor=Color.LightGreen;

            btnInvoice0.Visible = true;
            selectedCheckBox = btnInvoice0;
            invoiceSerial++;

            SoldItemListComponent component = new SoldItemListComponent();
            component.Branch_ID = General.branchId;
            soldItems.Add(new SoldItemComponentViewModel()
            {
                Component = component,
                Id = btnInvoice0.Name
            });
            component.OnInvoiceCancelClick += new EventHandler(OnInvoiceCancelClick);
            pnlInvoices.Controls.Add(component);
            currentInvoice = component;
            component.Dock = DockStyle.Fill;
            component.Visible = true;
        }
        private void addInvoice(int salesTransactionId=0)
        {
            foreach (CheckBox butt in flowLayoutPanel1.Controls)
            {
                butt.Checked = false;
                butt.BackColor = SystemColors.Window;
           }
            CheckBox btnInvoice0 = new System.Windows.Forms.CheckBox();
            btnInvoice0.Appearance = System.Windows.Forms.Appearance.Button;
            btnInvoice0.Checked = true;
            btnInvoice0.BackColor = Color.LightGreen;

            //Button btnInvoice0 = new Button();
            btnInvoice0.Name = $"btnInvoice{invoiceSerial}";
            btnInvoice0.Height = btnAddInvoice.Height;
            btnInvoice0.Text = $"ÝÇÊæÑÉ {soldItems.Count.ToString()}";
            //btnInvoice0.Tag = component.Name;
            btnInvoice0.Click += new EventHandler(OnInvoiceClick);
            selectedCheckBox = btnInvoice0;
            selectedCheckBox.Checked = true;

            flowLayoutPanel1.Controls.Add(btnInvoice0);
            btnInvoice0.Visible = true;
            invoiceSerial++;

            SoldItemListComponent component = new SoldItemListComponent();
            component.Branch_ID = General.branchId;
            soldItems.Add(new SoldItemComponentViewModel()
            {
                Component = component,
                Id = btnInvoice0.Name
            });
            component.OnInvoiceCancelClick += new EventHandler(OnInvoiceCancelClick);
            
            component.OnInvoiceSaved += new EventHandler(OnInvoiceSaved);
            
            if(salesTransactionId>0)
                component.EditSalesTransaction(salesTransactionId);

            component.FirstInvoice = false;
            pnlInvoices.Controls.Add(component);
            currentInvoice = component;
            component.Dock = DockStyle.Fill;
            component.Visible = true;

            showSoldItemComponent(btnInvoice0);
        }
        public MainForm1()
        {
            InitializeComponent();
            initTab();
        }
        private void removeInvoice()
        {
            if (selectedCheckBox != null)
            {
                if (flowLayoutPanel1.Controls.Count == 1)
                {
                    currentInvoice.clearScreen();
                }
                else
                {
                    SoldItemComponentViewModel itemControl = soldItems.Where(r => r.Id == selectedCheckBox.Name).FirstOrDefault();
                    if (itemControl != null)
                    {
                        pnlInvoices.Controls.Clear();
                        soldItems.Remove(itemControl);
                        flowLayoutPanel1.Controls.Remove(selectedCheckBox);
                    }
                    currentInvoice = (SoldItemListComponent)soldItems[soldItems.Count - 1].Component;
                    selectedCheckBox = (CheckBox)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];
                    selectedCheckBox.Checked = true;
                    showSoldItemComponent(selectedCheckBox);
                }
            }
        }
        protected void OnInvoiceCancelClick(object sender, EventArgs e)
        {
            removeInvoice();
        }
        protected void OnInvoiceSaved(object sender, EventArgs e)
        {
            if(!currentInvoice.FirstInvoice)
                removeInvoice();
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
        protected void OnInvoiceClick(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            foreach (CheckBox butt in flowLayoutPanel1.Controls)
            {
                butt.Checked = false;
                butt.BackColor = SystemColors.Window;
           }

            CheckBox button = (CheckBox)sender;
            button.BackColor = Color.LightGreen;

            showSoldItemComponent(button);
            selectedCheckBox = button;

            //SoldItemComponentViewModel itemControl = soldItems.Where(r => r.Id == button.Name).FirstOrDefault();
            //if (itemControl != null)
            //{
            //    currentInvoice = itemControl.Component;

            //    pnlInvoices.Controls.Clear();
            //    pnlInvoices.Controls.Add(currentInvoice);
            //    currentInvoice.Visible = true;
            //    //soldItems.Remove(itemControl);
            //    //flowLayoutPanel1.Controls.Remove(button);

            //}
        }
        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void draw()
        {

            //dtMainItemCategories = General.ConvertToDataTable(General.ItemGroupsList);
            dtMainItemCategories = General.ConvertToDataTable(General.retSubItemGroupList(0));

            mainCategoryComponent.drawCategories(General.retSubItemGroupList(0), new Components.ViewModels.RoundedButtonStyleViewModel
            {
                ButtonHeight = 50,
                TextColor = Color.Black,
                BackColor = Color.LightSalmon,
                ButtonFont = new Font(this.Font.FontFamily, 14, FontStyle.Bold),
                BorderSize = 1,
                ButtonSize = new Size(200, 50)
            });


            cmbMainItemCategory.ValueMember = "Item_Group_ID";
            cmbMainItemCategory.DisplayMember = "Item_Group_Desc";
            cmbMainItemCategory.DataSource = dtMainItemCategories;
        }

        public void initForm()
        {
            try
            {
                Task.Run(async () => General.LoadItems(0));
                Task.Run(async () => General.loadItemGroupsAsync());
                //await General.LoadItems();
                //General.loadItemGroupsAsync();
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void loadCommonData()
        {
            General.LoadBanks();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            mainCategoryComponent.pnlContentBase.BackColor = Color.White;
            initForm();
            pnlQuickAccessButtons.Width = this.Width / 60;
            loadCommonData();
        }

        private async void mainCategoryComponent_OnCategoryClick(object sender, EventArgs e)
        {
            Item_GroupModel model = (Item_GroupModel)sender;
            //ResultModel result = await ItemGroupRepository.getItemSubGroupList(model.Item_Group_ID);
            //dtMainItemCategories = General.ConvertToDataTable(General.RetSub_ItemGroupList(0));
            List<Item_GroupModel> list = General.retSubItemGroupList(model.Item_Group_ID);

            //if (result != null)
            //{
            //    if (result.StatusCode == "200")
            //    {
            //        List<Item_GroupModel> list = (List<Item_GroupModel>)result.Data;
            subCategoryComponent.clearContent();
            subCategoryComponent.drawCategories(list, new Components.ViewModels.RoundedButtonStyleViewModel
            {
                ButtonHeight = 50,
                TextColor = Color.Black,
                BackColor = Color.LightYellow,
                ButtonFont = new Font(this.Font.FontFamily, 14, FontStyle.Bold),
                BorderSize = 1,
                ButtonSize = new Size(200, 50)
            });
            //    }
            //}


        }

        private void mainCategoryComponent_Load(object sender, EventArgs e)
        {

        }

        private async void subCategoryComponent_OnCategoryClick(object sender, EventArgs e)
        {

            //List<vItem_UnitModel> list;
            Item_GroupModel model = (Item_GroupModel)sender;
            //ResultModel result = await ItemQueryRepository.getAll(new ItemListCriteriaViewModel
            //{
            //    Item_Group_ID = model.Item_Group_ID,
            //});
            //if (result != null)
            //{
            //    if (result.Data != null)
            //    {
            //list = (List<vItem_UnitModel>)result.Data;
            //categoryProductComponent1.drawCategoryProducts(list);
            categoryProductComponent1.drawCategoryProducts(General.retItemGroupItemList(model.Item_Group_ID));
            //    }
            //}





        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //if (_loading)
            //{
            //    General.Show_Wait_Form(this, Constants.mstrWaitingMessage);
            //    initForm();

            //}
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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                draw();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (General.itemList != null)
            {
                timer1.Enabled = false;
                draw();
            }
        }

        private void soldItemListComponent1_Load(object sender, EventArgs e)
        {

        }



        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            addInvoice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void btnInvoiceList_Click(object sender, EventArgs e)
        {
            SaleTransactionRepository repository = new SaleTransactionRepository();
            SalesQueryCriteriaViewModel criteria = new SalesQueryCriteriaViewModel();
            criteria.From_Transaction_Date =$"{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}"; 
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
