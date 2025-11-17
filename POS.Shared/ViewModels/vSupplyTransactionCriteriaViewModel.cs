using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class vSupplyTransactionCriteriaViewModel
    {
        public int? Supply_Transaction_ID { get; set; }
        public short? Source_ID { get; set; }
        public string? FromTransaction_Date { get; set; }
        public string? ToTransaction_Date { get; set; }
        public int? Item_Unit_ID { get; set; }
        public int? QNT { get; set; }
        public string? Transaction_Notes { get; set; }

    }
}
