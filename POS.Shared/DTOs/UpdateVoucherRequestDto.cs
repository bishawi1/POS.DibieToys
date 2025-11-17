using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateVoucherRequestDto
    {
        public int Voucher_ID { get; set; }

        public byte voucher_Type_ID { get; set; }

        public byte Pay_Way_Id { get; set; }

        public byte Voucher_Currency_ID { get; set; }

        public byte? Cheque_Bank_No { get; set; }

        public short Person_ID { get; set; }

        public int? Cheque_ID { get; set; }

        public DateTime Voucher_Date { get; set; }

        public DateTime? Cheque_Due_Date { get; set; }

        public decimal Debit_Amount { get; set; }
        public decimal Credit_Amount { get; set; }

        public decimal Voucher_Currency_Rate { get; set; }

        public string? Voucher_Details { get; set; }

        public string? Manual_Voucher_No { get; set; }

        public string? Cheque_No { get; set; }

        public string User_Name { get; set; }

    }
}
