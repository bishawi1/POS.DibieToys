using POS.Shared;
using POS.Windows.Forms;
using POS.Windows.Forms.Books;
using RealEstateRentalApp;

namespace POS.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuItemLIst_Click(object sender, EventArgs e)
        {
            General.navigateLocation();
            //ItemListForm frm = new ItemListForm();
            //frm.MdiParent = this;
            //frm.InitForm();
            //frm.Show();
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {
            POSBookshopForm frm = new POSBookshopForm();
            // frm.MdiParent = this;
            frm.InitForm();
            frm.Show();
        }
        private void loadCommonData()
        {
            //General.loadAuthors();
            //General.loadBookCats();
            //General.loadSubjects();
            //General.loadPublishers();
            //General.loadSerieses();
            //General.loadBookCovers();
            //General.loadBookSizes();
            //General.LoadStores();
            //General.LoadStoreRooms();
            General.LoadSources();
            General.LoadBranches();
            General.LoadPublishers();
            General.LoadCities();
            General.LoadCurrencies();
            General.LoadBanks();
            General.LoadItemGroups();
            General.LoadUnits();
            General.LoadItemBrands();
            General.LoadBookAuthors();
            General.LoadBookSubjects();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            int intIndex = 0;
            //frm.initForm();
            frm.ShowDialog();
            if (General.mboolLogedin)
            {
                General.getComputerName();
                General.getComputerIP();
                loadCommonData();

                foreach (Control ctl in this.Controls)
                {
                    MdiClient client = ctl as MdiClient;
                    if (client != null)
                    {
                        ////ctl.BackgroundImageLayout = ImageLayout.Center;
                        //if (mboolIsDevelopment)
                        //    ctl.BackColor = Color.LightGray;
                        //else
                        ctl.BackColor = Color.LightBlue;
                        ////ctl.BackgroundImage = Resources.LibPanel; //' Me.BackgroundImage
                    }
                }
                //General.dataContext = new POS.DAL.Data.DataContext();
                frm.Close();
                frm.Dispose();
            }
            else
            {
                frm.Dispose();
                this.Close();
            }

        }

        private void tsbtnItemList_Click(object sender, EventArgs e)
        {
            ItemListForm frm = new ItemListForm();
            frm.MdiParent = this;
            frm.InitForm();
            frm.Show();
        }

        private void tsbtnCustomerIndex_Click(object sender, EventArgs e)
        {
            PersonListForm frm = new PersonListForm();
            frm.MdiParent = this;
            frm.initForm(PersonCatEnum.Customer);
            frm.Show();
        }

        private void tsbtnVoucherListForm_Click(object sender, EventArgs e)
        {
            VoucherListForm frm = new VoucherListForm();
            frm.MdiParent = this;
            frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.Qabd);
            frm.Show();
        }

        private void tsbtnSalesTransactionList_Click(object sender, EventArgs e)
        {
            SaleTransactionListForm frm = new SaleTransactionListForm();
            frm.MdiParent = this;
            frm.initForm();
            frm.Show();
        }

        private void mnuItemBeginQnt_Click(object sender, EventArgs e)
        {
            ItemUnitBeginQntDialog frm = new ItemUnitBeginQntDialog();
            frm.MdiParent = this;
            frm.initForm();
            frm.Show();
        }

        private void tsbtnExpenses_Click(object sender, EventArgs e)
        {
            VoucherListForm frm = new VoucherListForm();
            frm.MdiParent = this;
            //frm.initForm(DateTime.MinValue, DateTime.MinValue, ShowVoucherTypeEnum.Sarf);
            frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.Sarf);
            frm.Show();
        }

        private void tsbtnSalesInvoiceList_Click(object sender, EventArgs e)
        {
            VoucherListForm frm = new VoucherListForm();
            frm.MdiParent = this;
            frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.SalesInvoice);
            frm.Show();
        }

        private void tsbtnQabdVoucherList_Click(object sender, EventArgs e)
        {
            VoucherListForm frm = new VoucherListForm();
            frm.MdiParent = this;
            frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.Qabd);
            frm.Show();
        }

        private void tsbtnPurchaseList_Click(object sender, EventArgs e)
        {
            //VoucherListForm frm = new VoucherListForm();
            PurchaseInvoiceListForm frm = new PurchaseInvoiceListForm();
            frm.MdiParent = this;
            frm.initForm(DateTime.MinValue, DateTime.MinValue, VoucherTypeEnum.PurchaseInvoice, -1, "");
            frm.Show();
        }

        private void tsbtnStatementOfAccount_Click(object sender, EventArgs e)
        {
            StatementOfAccountForm frm = new StatementOfAccountForm();
            frm.MdiParent = this;
            frm.initForm();
            frm.Show();
        }

        private void tsbtnProviders_Click(object sender, EventArgs e)
        {
            PersonListForm frm = new PersonListForm();
            frm.MdiParent = this;
            frm.initForm(PersonCatEnum.Provider);
            frm.Show();
        }

        private void tsbtnOwnerList_Click(object sender, EventArgs e)
        {
            PersonListForm frm = new PersonListForm();
            frm.MdiParent = this;
            frm.initForm(PersonCatEnum.Partner);
            frm.Show();
        }

        private void tsbtnOnlineSalesList_Click(object sender, EventArgs e)
        {
            OnlineSalesTransactionListForm frm = new OnlineSalesTransactionListForm();
            frm.MdiParent = this;
            frm.initForm(DateTime.MinValue, DateTime.MinValue);
            frm.Show();
        }



        private void tsbtnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm frm = new DashboardForm();
            frm.MdiParent = this;
            frm.initForm();
            //frm.initForm(DateTime.MinValue, DateTime.MinValue, ShowVoucherTypeEnum.SalesInvoices);
            frm.Show();
        }

        private void tsbtnSupplyTransactionList_Click(object sender, EventArgs e)
        {
            SupplyItemListForm frm = new SupplyItemListForm();
            frm.MdiParent = this;
            frm.initForm(General.defaultSupplyBranchId);
            //frm.initForm(DateTime.MinValue, DateTime.MinValue, ShowVoucherTypeEnum.SalesInvoices);
            frm.Show();
        }

        private void tsbtnBookList_Click(object sender, EventArgs e)
        {
            BookListForm frm = new BookListForm();
            frm.MdiParent = this;
            frm.initForm();
            frm.Show();
        }

        private void tsbtnTicketList_Click(object sender, EventArgs e)
        {
            TicketListForm frm = new TicketListForm();
            frm.MdiParent = this;
            frm.initForm();
            frm.Show();
        }

        private void tsbtnShowToysRoomReservation_Click(object sender, EventArgs e)
        {
            ReservToysRoomListForm frm = new ReservToysRoomListForm();
            frm.MdiParent = this;
            frm.initForm();
            frm.Show();
        }
    }
}
