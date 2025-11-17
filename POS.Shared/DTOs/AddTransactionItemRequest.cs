using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class ModifyTransactionItemRequest
    {        
        public int? Sale_Transaction_Item_ID { get; set; }
        public int? Sale_Transaction_ID { get; set; }
        [Required]
        public short Item_Unit_ID { get; set; }
        [Required]
        public int QNT { get; set; }
        [Required]
        public decimal Item_Unit_Price { get; set; }
        [Required]
        public decimal Item_Unit_Cost { get; set; }
        [Required]
        public decimal Discount_Amount { get; set; }
        [Required]
        public bool IsBacked { get; set; } = false;

        [Required]
        public decimal Item_Unit_Price_After_Discount { get; set; }
        public string? Notes { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string User_Name { get; set; }

    }
}
