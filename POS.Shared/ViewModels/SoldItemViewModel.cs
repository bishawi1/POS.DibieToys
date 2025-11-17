using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class SoldItemViewModel
    {
        public int? Sale_Transaction_Item_ID { get; set; } = -1;
        public short Item_Unit_ID { get; set; }
        public int Item_ID { get; set; }
        public string Item_Desc { get; set; }
        public byte Unit_ID { get; set; }
        public string Unit_Desc { get; set; }
        public decimal Item_Unit_Price { get; set; }
        public decimal? Item_Unit_Cost { get; set; }
        public decimal QNT { get; set; }
        public decimal TotalAmount { get; set; }

        public string Increase { get; set; } = "+";
        public string Descrease { get; set; } = "-";
    }
}
