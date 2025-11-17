using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class vStockModel
    {
        [Key]
        public int Stock_ID { get; set; }
        public int Transaction_Type_ID { get; set; }

        public int Transaction_ID { get; set; }

        public short Item_Group_ID { get; set; }

        public byte Branch_ID { get; set; }
        public string Branch_Name { get; set; }
        public string Barcode { get; set; }

        public int Item_Unit_ID { get; set; }

        public int In_QNT { get; set; }

        public int Out_QNT { get; set; }

        public DateTime Time_Stamp { get; set; }

        public string Item_Desc { get; set; }

        public string? Item_Group_Desc { get; set; }

        public string Transaction_Type_Desc { get; set; }

        public string? Stock_Notes { get; set; }

        public string User_Name { get; set; }

    }
}
