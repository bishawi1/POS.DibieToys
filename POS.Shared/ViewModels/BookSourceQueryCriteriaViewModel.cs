using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class BookSourceQueryCriteriaViewModel
    {
        public byte? Source_ID { get; set; }
        public string? FromInvoiceDate { get; set; }
        public string? ToInvoiceDate { get; set; }
        public string? Book_Source_Desc { get; set; }
        public int? Book_ID { get; set; }
        public string? User_Name { get; set; }

    }
}
