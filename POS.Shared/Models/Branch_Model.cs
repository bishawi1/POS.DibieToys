using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Branch_Model
    {
        [Key]
        public byte Branch_ID { get; set; }
        [Required]
        public string Branch_Name { get; set; }
        public string? Notes { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime Time_Stamp { get; set; }
    }
}
