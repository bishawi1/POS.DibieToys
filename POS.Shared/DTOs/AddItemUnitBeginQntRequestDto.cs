using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class AddItemUnitBeginQntRequestDto
    {
        [Required]
        public int Item_Unit_ID { get; set; }
        [Required]
        public int Stock_ID { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public int Qnt { get; set; }
    }
}
