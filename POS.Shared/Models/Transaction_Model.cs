using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Transaction_Model

    {
        [Key]
        public int Transaction_ID { get; set; }
        [Required]
        public DateTime Transaction_Date { get; set; } = DateTime.Now;
        [Required]
        public byte Transaction_Type_ID { get; set; }
        [Required]
        public int Reference_ID { get; set; }
        public string? Notes { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime Time_Stamp { get; set; } = DateTime.Now;

    }
}
