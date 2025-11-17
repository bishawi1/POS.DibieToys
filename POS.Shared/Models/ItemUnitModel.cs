using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Item_UnitModel
    {
        [Key]
        public short Item_Unit_ID { get; set; }

        public byte Unit_ID { get; set; }

        public int Item_ID { get; set; }

        public DateTime? Time_Stamp { get; set; }

        public double? Qnt_In_Basic_Unit { get; set; }

        public bool Default_Unit { get; set; }

        public bool Is_Main_Unit { get; set; }

        public decimal Item_Unit_Price { get; set; }

        public decimal? Item_Unit_Cost { get; set; }


        public string? Barcode { get; set; }

        public string? User_Name { get; set; }

    }
}
