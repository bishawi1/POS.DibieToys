using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using POS.WebApi.Contracts;
using POS.WebApi.Contracts.Books;
using POS.WebApi.Data;
using POS.WebApi.Repositories;
using POS.WebApi.Repositories.Books;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.WebHost.UseWebRoot("wwwroot");

//DB Context
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AuthDbConnection")));

//Repositories
builder.Services.AddScoped<ICityRepository, SQLCityRepository>();
builder.Services.AddScoped<ICurrency_RateRepository, SQLCurrency_RateRepository>();
builder.Services.AddScoped<IItemRepository, SQLItemRepository>();
builder.Services.AddScoped<ICurrencyRepository, SQLCurrencyRepository>();
builder.Services.AddScoped<IItem_BrandRepository, SQLItem_BrandRepository>();
builder.Services.AddScoped<IItem_GroupRepository, SQLItem_GroupRepository>();
builder.Services.AddScoped<IItem_UnitRepository, SQLItem_UnitRepository>();
builder.Services.AddScoped<IPersonRepository, SQLPersonRepository>();
builder.Services.AddScoped<IUnitRepository, SQLUnitRepository>();
builder.Services.AddScoped<ISourceRepository, SQLSourceRepository>();
builder.Services.AddScoped<IBankRepository, SQLBankRepository>();

builder.Services.AddScoped<IUsersRepository, SQLUsersRepository>();
builder.Services.AddScoped<IvItem_UnitRepository, SQLvItem_UnitRepository>();

builder.Services.AddScoped<IStockRepository, SQLStockRepository>();
builder.Services.AddScoped<ITransaction_Type, SQLTransactionTypeRepository>();
builder.Services.AddScoped<ISaleTransaction, SQLSaleTransactionRepository>();
builder.Services.AddScoped<ISaleTransactionItem, SQLSaleTransactionItemRepository>();
builder.Services.AddScoped<ITransaction, SQLTransactionRepository>();

builder.Services.AddScoped<ITellerUserRepository, SQLTeller_UserRepository>();
builder.Services.AddScoped<ITellerRepository, SQLTellerRepository>();

builder.Services.AddScoped<IVoucherRepository, SQLVoucherRepository>();
builder.Services.AddScoped<ISupply_TransactionRepository, SQLSupply_TransactionRepository>();


builder.Services.AddScoped<IBookRepository, SQLBookRepository>();
builder.Services.AddScoped<IPublisherRepository, SQLPublisherRepository>();
builder.Services.AddScoped<IBook_SubjectRepository, SQLBook_SubjectRepository>();
builder.Services.AddScoped<IBook_AuthorRepository, SQLBook_AuthorRepository>();

builder.Services.AddScoped<IBranchRepository, SQLBranchRepository>();
builder.Services.AddScoped<ITicketRepository, SQLTicketRepository>();

// Security
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
}).AddEntityFrameworkStores<DataContext>()
                    .AddDefaultTokenProviders();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = builder.Configuration["jwt:ValidIssuer"],
        ValidAudience = builder.Configuration["jwt:ValidAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["jwt:SecretKey"]))
    };
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyAllowSpecificOrigins",
                      builder =>
                      {
                          builder
                              .WithOrigins("*")
                              .AllowAnyHeader()
                              .AllowAnyMethod()
                              //.AllowCredentials()
                              ;
                      });
});


//builder.Services.AddOpenApi();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.MapOpenApi();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

//app.UseSwaggerUI(o=>o.SwaggerEndpoint("/openapi/v1.json", "Swagger Demo"));

app.UseAuthorization();

app.MapControllers();

app.Run();
