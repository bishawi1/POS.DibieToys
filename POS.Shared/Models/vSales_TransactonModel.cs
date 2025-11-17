using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class vSales_TransactonModel
    {
        [Key]
        public int Sale_Transaction_ID { get; set; }
        public short Teller_ID { get; set; }

        public short Customer_ID { get; set; }
        public string Customer_NO { get; set; }
        public string Customer_Name { get; set; }

        public int Sale_Transaction_No { get; set; }

        public DateTime Transaction_Date { get; set; }

        public bool IsActive { get; set; }

        public decimal? Amount { get; set; }

        public string Teller_Name { get; set; }

        public string? Transaction_Notes { get; set; }
        public decimal? Delevery_Fees { get; set; } = 0;
        public string? Delevery_Place { get; set; }
        public string? Delevery_Transaction_No { get; set; }
        public decimal? Total_Amount { get; set; }
        public decimal? PaidAmountSum { get; set; } = 0;
        public decimal RemainAmount { get; set; } = 0;

    }
}
