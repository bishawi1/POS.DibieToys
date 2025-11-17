using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Sale_Transaction_Item_Model
    {
        [Key]
        public int Sale_Transaction_Item_ID { get; set; }
        [Required]
        public int Sale_Transaction_ID { get; set; }
        [Required]

        public int Item_Unit_ID { get; set; }
        [Required]
        public int QNT { get; set; }
        [Required]
        public decimal Item_Unit_Price { get; set; }
        [Required]
        public decimal Discount_Amount { get; set; }
        [Required]
        public decimal Item_Unit_Price_After_Discount { get; set; }
        public string? Notes { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime Time_Stamp { get; set; } = DateTime.Now;
        public decimal Item_Unit_Cost { get; set; }

    }
}
