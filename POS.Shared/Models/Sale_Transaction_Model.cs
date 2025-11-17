using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Sale_Transaction_Model
    {
        [Key]
        public int Sale_Transaction_ID { get; set; }
        [Required]
        public int Sale_Transaction_No { get; set; }
        [Required]
        public short Teller_ID { get; set; }
        [Required]
        public byte Branch_ID { get; set; }
        [Required]
        public bool IsBacked { get; set; }


        [Required]
        public DateTime Transaction_Date { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        public string? Transaction_Notes { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime Time_Stamp { get; set; } = DateTime.Now;
        [Required]
        public short Customer_ID { get; set; }

        public decimal? Delevery_Fees { get; set; } = 0;
        public string? Delevery_Place { get; set; }
        public string? Delevery_Transaction_No { get; set; }
        public decimal? Discount_Amount { get; set; } = 0;

    }
}
