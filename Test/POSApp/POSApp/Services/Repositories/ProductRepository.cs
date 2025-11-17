using Microsoft.Data.SqlClient;
using POSApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.Services.Repositories
{
    public class ProductRepository
    {
        private readonly SqlConnection moConnection;

        public ProductRepository(SqlConnection oConnection)
        {
            this.moConnection = oConnection;
        }
        public List<CategoryModel> GetCategories()
        {
            POS_DAL.Category category = new POS_DAL.Category(moConnection);
            category.Filter();
            category.Apply_Filter();
            DataTable categories= category.Export_LOV();
            List<CategoryModel> categoryList = new List<CategoryModel>();
            foreach (DataRow row in categories.Rows)
            {
                categoryList.Add(new CategoryModel() {  Id = Convert.ToInt32(row["Category_ID"]), Category = Convert.ToString(row["Category_Name"])});
            }

            return categoryList;
        }
        public List<ProductModel> GetProduct()
        {
            POS_DAL.Product product = new POS_DAL.Product(moConnection);
            product.Filter();
            product.Apply_Filter();
            DataTable products = product.Export_LOV();
            List<ProductModel> list = new List<ProductModel>();
            foreach (DataRow row in products.Rows)
            {
                list.Add(new ProductModel()
                { Id = Convert.ToInt32(row["Product_ID"]),
                    Category_ID = Convert.ToInt32(row["Product_ID"]),
                    Product_Name= Convert.ToString(row["Product_Name"]),
                    BarCode = Convert.ToString(row["BarCode"]),
                    Price = Convert.ToDecimal(row["Price"]),
                });
            }
            return list;
        }
        public List<ProductModel> GetProduct(int Category_ID)
        {
            POS_DAL.Product product = new POS_DAL.Product(moConnection);
            product.Filter();
            product.set_Category_ID(Category_ID, POS_DAL.Filter_Type.Equal);
            product.Apply_Filter();
            DataTable products = product.Export_LOV();
            List<ProductModel> list = new List<ProductModel>();
            foreach (DataRow row in products.Rows)
            {
                list.Add(new ProductModel()
                {
                    Id = Convert.ToInt32(row["Product_ID"]),
                    Category_ID = Convert.ToInt32(row["Product_ID"]),
                    Product_Name = Convert.ToString(row["Product_Name"]),
                    BarCode = Convert.ToString(row["BarCode"]),
                    Price = Convert.ToDecimal(row["Price"]),
                });
            }
            return list;
        }

    }
}
