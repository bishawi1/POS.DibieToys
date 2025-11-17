using Microsoft.EntityFrameworkCore;
using POS.Shared.Models;

namespace POS.DAL.Data
{
    public class DataContext:DbContext
    {
        public DataContext():base()
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
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<vPersonModel> PersonQuery { get; set; }
        public DbSet<vItem_UnitModel> vItem_Unit { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=DESKTOP-JAEO25B\SQLEXPRESS;Initial Catalog=POS_ALKamal;User Id=sa;Password=allah;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CurrencyModel>().ToTable("Currency", "POS");
            builder.Entity<Item_BrandModel>().ToTable("Item_Brand", "POS");
            builder.Entity<Currency_RateModel>().ToTable("Currency_Rate", "POS");
            builder.Entity<ItemModel>().ToTable("Item", "POS");
            builder.Entity<Item_GroupModel>().ToTable("Item_Group", "POS");
            builder.Entity<Item_UnitModel>().ToTable("Item_Unit", "POS");
            builder.Entity<UnitModel>().ToTable("Unit", "POS");
            builder.Entity<vItem_UnitModel>().ToTable("vItem_Unit", "POS");

            builder.Entity<CityModel>().ToTable("City", "POS");
            builder.Entity<PersonModel>().ToTable("Person", "POS");
            builder.Entity<vPersonModel>().ToTable("vPerson", "CRM");
        }
    }
}
