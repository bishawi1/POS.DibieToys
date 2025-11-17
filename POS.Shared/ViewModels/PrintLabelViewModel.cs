using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class PrintLabelViewModel
    {
        public int Item_Unit_ID { get; set; }
        public string Item_Desc { get; set; }
        public Decimal Item_Unit_Price { get; set; }
        public string Barcode { get; set; }
       // public string Location { get; set; }
        public int BookCount { get; set; }
        public string? Barcode_Image_Path { get; set; }

    }
}
