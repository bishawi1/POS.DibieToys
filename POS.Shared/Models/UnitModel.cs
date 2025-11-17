using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class UnitModel
    {
        [Key]
        public byte Unit_ID { get; set; }

        public byte? Main_Unit_ID { get; set; }

        public byte? Unit_Status_ID { get; set; }

        public byte Accounting_Group_ID { get; set; }

        public Single Qnt_IN_Main_Unit { get; set; }

        public DateTime? Unit_Status_Date { get; set; }

        public DateTime? Time_Stamp { get; set; }

        public string Unit_Desc { get; set; }

        public string? Unit_Notes { get; set; }

        public string? User_Name { get; set; }

    }
}
