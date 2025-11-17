using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Currency_RateModel
    {
        [Key]
        public int Currency_Rate_ID { get; set; }

        public byte Currency_ID { get; set; }

        public byte Accounting_Group_ID { get; set; }

        public DateTime? Currency_Rate_Date { get; set; }

        public DateTime? Time_Stamp { get; set; }

        public float Currency_Rate { get; set; }

        public string? User_Name { get; set; }

    }
}
