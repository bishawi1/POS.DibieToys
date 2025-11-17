using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;
using POS.Shared.Models.Books;
using POS.WebApi.Data;

namespace POS.WebApi.Data
{
    public class DataContext:IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<UsersModel> Users { get; set; }
        public DbSet<CurrencyModel> Currency { get; set; }
        public DbSet<Currency_RateModel> Currency_Rate { get; set; }
        public DbSet<Item_BrandModel> Item_Brand { get; set; }
        public DbSet<Item_GroupModel> Item_Group { get; set; }
        public DbSet<ItemModel> Item { get; set; }
        public DbSet<Item_UnitModel> Item_Unit { get; set; }
        public DbSet<UnitModel> Unit { get; set; }
        public DbSet<PersonModel> Person { get; set; }
        public DbSet<vPersonModel> PersonQuery { get; set; }
        public DbSet<vItem_UnitModel> vItem_Unit { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        public DbSet<BankModel> Bank { get; set; }
        public DbSet<SourceModel> Sources { get; set; }
        public DbSet<BookSourceQueryModel> BookSourceQuery { get; set; }

        public DbSet<Stock_Model> Stock { get; set; }
        public DbSet<Transaction_Type_Model> Transaction_Type { get; set; }
        public DbSet<Sale_Transaction_Model> Sale_Transaction { get; set; }
        public DbSet<Sale_Transaction_Item_Model> Sale_Transaction_Item { get; set; }
        public DbSet<vSales_TransactonModel> SalesQuery { get; set; }
        public DbSet<Transaction_Model> Transaction { get; set; }
        public DbSet<Teller_UserModel> Teller_User { get; set; }
        public DbSet<TellerModel> Teller { get; set; }
        public DbSet<Item_Unit_Begin_Qnt_Model> ItemUnitBeginQNT { get; set; }
        public DbSet<vStockModel> vStock { get; set; }

        public DbSet<VoucherModel> Voucher { get; set; }
        public DbSet<vVoucherModel> VoucherQuery { get; set; }
        public DbSet<vInvoiceReportModel> vInvoiceReport { get; set; }
        public DbSet<vPurchase_Invoice_Model> vPurchase_Invoice { get; set; }
        public DbSet<Supply_TransactionModel> Supply_Transaction { get; set; }
        public DbSet<vSupply_TransactionModel> vSupply_Transaction { get; set; }

        public DbSet<BookModel> Book { get; set; }
        public DbSet<vBooksModel> vBooks { get; set; }
        public DbSet<PublisherModel> Publisher { get; set; }
        public DbSet<Book_SubjectModel> Book_Subject { get; set; }
        public DbSet<Book_AuthorModel> Book_Author { get; set; }

        public DbSet<Branch_Model> Branch { get; set; }
        public DbSet<vBranch_Item_UnitModel> vBranch_Item_Unit { get; set; }
        public DbSet<TicketModel> Ticket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer(@"Data Source=DESKTOP-JAEO25B\SQLEXPRESS;Initial Catalog=POS_ALKamal;User Id=sa;Password=allah;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CurrencyModel>().ToTable("Currency", "POS");
            builder.Entity<BankModel>().ToTable("Bank", "POS");

            builder.Entity<Item_BrandModel>().ToTable("Item_Brand", "POS");
            builder.Entity<Currency_RateModel>().ToTable("Currency_Rate", "POS");
            builder.Entity<ItemModel>().ToTable("Item", "POS");
            builder.Entity<Item_GroupModel>().ToTable("Item_Group", "POS");
            builder.Entity<Item_UnitModel>().ToTable("Item_Unit", "POS");
            builder.Entity<UnitModel>().ToTable("Unit", "POS");
            builder.Entity<vItem_UnitModel>().ToTable("vItem_Unit", "POS");

            builder.Entity<CityModel>().ToTable("City", "POS");
            builder.Entity<PersonModel>().ToTable("Person", "POS");
            builder.Entity<vPersonModel>().ToTable("vPerson", "POS");
            builder.Entity<SourceModel>().ToTable("Book_Source", "dbo");
            builder.Entity<BookSourceQueryModel>().ToTable("vBook_Source_Trans", "dbo").HasNoKey();
        
            builder.Entity<Stock_Model>().ToTable("Stock", "POS");
            builder.Entity<Transaction_Type_Model>().ToTable("Transaction_Type", "POS");
            builder.Entity<Sale_Transaction_Model>().ToTable("Sale_Transaction", "POS");
            builder.Entity<Sale_Transaction_Item_Model>().ToTable("Sale_Transaction_Item", "POS");
            builder.Entity<vSales_TransactonModel>().ToTable("vSales_Transacton", "POS");
            builder.Entity<Transaction_Model>().ToTable("Transaction", "POS");
        
            builder.Entity<Teller_UserModel>().ToTable("Teller_User", "POS");
            builder.Entity<TellerModel>().ToTable("Teller", "POS");

            builder.Entity<vVoucherModel>().ToTable("vVoucher", "POS");
            builder.Entity<VoucherModel>().ToTable("Voucher", "POS");


            builder.Entity<Item_Unit_Begin_Qnt_Model>().ToTable("Item_Unit_Begin_Qnt", "POS");
            builder.Entity<vStockModel>().ToTable("vStock", "POS");
            builder.Entity<vInvoiceReportModel>().ToTable("vInvoiceReport", "POS");
            builder.Entity<vPurchase_Invoice_Model>().ToTable("vPurchase_Invoice", "POS");

            builder.Entity<Supply_TransactionModel>().ToTable("Supply_Transaction", "POS");
            builder.Entity<vSupply_TransactionModel>().ToTable("vSupply_Transaction", "POS");

            builder.Entity<BookModel>().ToTable("Book", "dbo");
            builder.Entity<vBooksModel>().ToTable("vBooks", "dbo");
            builder.Entity<PublisherModel>().ToTable("Publisher", "dbo");
            builder.Entity<Book_SubjectModel>().ToTable("Book_Subject", "dbo");
            builder.Entity<Book_AuthorModel>().ToTable("Book_Author", "dbo");

            builder.Entity<Branch_Model>().ToTable("Branch", "POS");
            builder.Entity<vBranch_Item_UnitModel>().ToTable("vBranch_Item_Unit", "POS");
            builder.Entity<TicketModel>().ToTable("Ticket", "POS");
        }
    }
}
