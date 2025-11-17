using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class InvoiceReportCriteriaViewModel
    {
        public int Sale_Transaction_ID { get; set; }
        public int? Sale_Transaction_No { get; set; }
        public string? Teller_Name { get; set; }

    }
}
