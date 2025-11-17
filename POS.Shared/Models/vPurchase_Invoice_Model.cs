using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class vPurchase_Invoice_Model
    {
        [Key]
        public int Voucher_ID { get; set; }

        public byte voucher_Type_ID { get; set; }
        public string Voucher_Type_Desc { get; set; }

        public short Person_ID { get; set; }
        public string Person_Name { get; set; }
        public DateTime Voucher_Date { get; set; }
        public decimal Amount { get; set; }

        public byte Voucher_Currency_ID { get; set; }
        public string Currency_Name { get; set; }
        public decimal Voucher_Currency_Rate { get; set; }
        public string? Voucher_Details { get; set; }
        public decimal Paid_Amount { get; set; } = 0;
        public decimal Remain_Amount { get; set; } = 0;

        public string User_Name { get; set; }

        public DateTime Time_Stamp { get; set; }



    }
}
