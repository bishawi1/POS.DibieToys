using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class BankModel
    {
        [Key]
        public byte Bank_No { get; set; }
        [Required]
        public string Bank_Name { get; set; }

        public string? Bank_Notes { get; set; }

    }
}
