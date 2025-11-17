using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Supply_TransactionModel
    {
        [Key]
        public int Supply_Transaction_ID { get; set; }

        public short Source_ID { get; set; }
        [Required]
        public byte Branch_ID { get; set; }

        public int Item_Unit_ID { get; set; }

        public int QNT { get; set; }

        public DateTime Transaction_Date { get; set; }

        public DateTime Time_Stamp { get; set; }

        public bool IsActive { get; set; }

        public string? Transaction_Notes { get; set; }

        public string User_Name { get; set; }

    }
}
