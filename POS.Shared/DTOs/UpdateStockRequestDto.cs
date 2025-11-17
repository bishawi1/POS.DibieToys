using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateStockRequestDto
    {
        [Key]
        public int Stock_ID { get; set; }
        [Required]
        public int Item_Unit_ID { get; set; }
        [Required]
        public int In_QNT { get; set; }
        [Required]
        public int Out_QNT { get; set; }
        [Required]
        public int Transaction_ID { get; set; }
        public string? Stock_Notes { get; set; }
        [Required]
        public string User_Name { get; set; }

    }
}
