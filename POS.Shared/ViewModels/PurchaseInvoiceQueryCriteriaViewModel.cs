using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class PurchaseInvoiceQueryCriteriaViewModel
    {
        public int? VoucherId { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public string? Details { get; set; }
        public short? PersonId { get; set; }
        public string? PersonNo { get; set; }
        public string? PersonName { get; set; }
        public decimal? Paid_Amount { get; set; }
        public decimal? Remain_Amount { get; set; }
        public bool NotPaidOnly { get; set; }=false;

    }
}
