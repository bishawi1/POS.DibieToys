using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Item_Unit_Begin_Qnt_Model
    {
        [Key]
        public int Item_Unit_Begin_Qnt_ID { get; set; }
        [Required]
        public int Item_Unit_ID { get; set; }
        [Required]
        public int Stock_ID { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime Time_Stamp { get; set; } = DateTime.Now;
    }
}
