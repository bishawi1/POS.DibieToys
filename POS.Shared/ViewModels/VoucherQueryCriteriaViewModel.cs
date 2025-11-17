using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class VoucherQueryCriteriaViewModel
    {
        public int? VoucherId { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public byte? VoucherTypeId { get; set; }
        public string? Details { get; set; }
        public short? PersonId { get; set; }
        public string? PersonNo { get; set; }
        public string? PersonName { get; set; }
        public string? PayWayId { get; set; } = string.Empty;
        public string? manualVoucherNo { get; set; }
        public bool DebitsOnly { get; set; } = false;


    }
}
