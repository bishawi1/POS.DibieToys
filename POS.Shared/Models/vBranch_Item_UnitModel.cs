using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class vBranch_Item_UnitModel
    {
        [Key]
        public short Item_Unit_ID { get; set; }

        public byte? Item_Status_ID { get; set; }

        public byte Unit_ID { get; set; }

        public short Item_Group_ID { get; set; }

        public int Item_ID { get; set; }

        public int Item_Brand_ID { get; set; }

        public DateTime? Time_Stamp { get; set; }

        public double? Qnt_In_Basic_Unit { get; set; }

        public bool Is_Main_Unit { get; set; }

        public bool Default_Unit { get; set; }

        public decimal Item_Unit_Price { get; set; }

        public decimal? Item_Unit_Cost { get; set; }

        public string? Item_No { get; set; }

        public string Item_Desc { get; set; }

        public string? Item_Group_Desc { get; set; }

        public string Item_Group_No { get; set; }

        public string Unit_Desc { get; set; }

        public string? Barcode { get; set; }

        public string? User_Name { get; set; }

        public string? Notes { get; set; }
        public bool QuickAccess { get; set; }
        public string Item_Brand_Name { get; set; }
        public Int16? Source_ID { get; set; }
        public string? Book_Source_Desc { get; set; }
        public string? FileUrl { get; set; }
        public int? In_QNT { get; set; }
        public int? Out_QNT { get; set; }
        public int? RemainQNT { get; set; }
        public byte? Branch_ID { get; set; }

    }
}
