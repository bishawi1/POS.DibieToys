using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Stock_Model
    {
        [Key]
        public int Stock_ID { get; set; }
        [Required]
        public int Item_Unit_ID { get; set; }
        [Required]
        public byte Branch_ID { get; set; }
        [Required]
        public int In_QNT { get; set; }
        [Required]
        public int Out_QNT { get; set; }
        [Required]
        public int Transaction_ID { get; set; }
        [Required]
        public int Transaction_Type_ID { get; set; }

        public string? Stock_Notes { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime Time_Stamp { get; set; } = DateTime.Now;
    }
}
