using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class AddSaleTransactionDto
    {
        public int? Sale_Transaction_ID { get; set; }

        [Required]
        public short Teller_ID { get; set; }
        [Required]
        public short Customer_ID { get; set; }
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

        public List<ModifyTransactionItemRequest> items { get; set; }
        public byte PayWayId { get; set; } =Convert.ToByte(PayWayEnum.Cash);
        public byte? Bank_NO { get; set; }
        public string? Cheque_No { get; set; }
        public DateTime? Cheque_Due_Date { get; set; }
        public string? PaymentNotes { get; set; } = string.Empty;
        public decimal DiscountAmount { get; set; } = 0;
        public decimal PaidAmount { get; set; } = 0;
        public decimal? Delevery_Fees { get; set; } = 0;
        public string? Delevery_Place { get; set; }
        public string? Delevery_Transaction_No { get; set; }
        public List<SaleTransactionPaidAmountDto>? PaidAmountList { get; set; }

    }
}
