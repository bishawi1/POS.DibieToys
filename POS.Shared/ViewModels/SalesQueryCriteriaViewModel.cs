using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class SalesQueryCriteriaViewModel
    {
        public int? Sale_Transaction_ID { get; set; }
        public short? Teller_ID { get; set; }
        public int? Sale_Transaction_No { get; set; }

        public string? From_Transaction_Date { get; set; }
        public string? To_Transaction_Date { get; set; } 

        public bool? IsActive { get; set; }

        public decimal? From_Amount { get; set; }
        public decimal? To_Amount { get; set; }

        public string? Teller_Name { get; set; }

        public string? Transaction_Notes { get; set; }
        public short? Sales_Person_ID { get; set; }
        public byte PayStatusId { get; set; } = 0;
        public bool DebitSalesOnly { get; set; } = false;


    }
}
