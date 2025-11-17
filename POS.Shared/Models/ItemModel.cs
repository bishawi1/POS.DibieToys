using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class ItemModel
    {
        [Key]
        public int Item_ID { get; set; }

        public byte? Item_Status_ID { get; set; }

        public short Item_Group_ID { get; set; }

        public int Item_Brand_ID { get; set; }

        public DateTime? Time_Stamp { get; set; }

        public bool Item_Has_Expiry_Date { get; set; }

        public string? Item_No { get; set; }

        public string Item_Desc { get; set; }

        public string? Item_Color { get; set; }

        public string? Item_Size { get; set; }
        public int? Book_ID { get; set; }


        public string? Notes { get; set; }
        public bool QuickAccess { get; set; } = false;
        public string? User_Name { get; set; }
        public Int16? Source_ID { get; set; }
        public string? FileUrl { get; set; }

    }
}
