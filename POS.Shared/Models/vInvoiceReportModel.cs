using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class vInvoiceReportModel
    {
        [Key]
        public int Sale_Transaction_Item_ID { get; set; }

        public int Sale_Transaction_ID { get; set; }

        public int Sale_Transaction_No { get; set; }

        public DateTime Transaction_Date { get; set; }
        public short Teller_ID { get; set; }
        public string Teller_Name { get; set; }
        public string? Transaction_Notes { get; set; }
        public decimal? Amount { get; set; }
        public short Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public decimal Discount_Amount { get; set; }
        public decimal? Delevery_Fees { get; set; } = 0;
        public string Delevery_Place { get; set; }
        public string Delevery_Transaction_No { get; set; }
        public decimal? Total_Amount { get; set; }
        public decimal? PaidAmountSum { get; set; } = 0;
        public decimal RemainAmount { get; set; } = 0;



        public int Item_Unit_ID { get; set; }

        public string Item_Desc { get; set; }

        public int QNT { get; set; }
        public byte Unit_ID { get; set; }

        public string Unit_Desc { get; set; }

       public decimal Item_Unit_Price { get; set; }
       public decimal Item_Unit_Cost { get; set; }
       public decimal Item_Total_Amount { get; set; }
       public DateTime Time_Stamp { get; set; }

       public bool IsBacked { get; set; }





    }
}
