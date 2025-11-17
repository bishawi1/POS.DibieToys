using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class vStockQueryCriteriaViewModel
    {
        public byte? Branch_ID { get; set; }
        public string? Branch_Name { get; set; }
        public string? Barcode { get; set; }
        public string? Item_Desc { get; set; }
        public int? Stock_ID { get; set; }
        public int? Item_Unit_ID { get; set; }
    }
}
