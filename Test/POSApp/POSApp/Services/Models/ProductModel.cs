using Accessibility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.Services.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Product_Name { get; set; }
        public int Category_ID { get; set; }
        public decimal Price { get; set; }
        public string? BarCode { get; set; }

    }
}
