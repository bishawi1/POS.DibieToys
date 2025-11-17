using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class CreateTicketRequestDto
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal Discount { get; set; }
        [Required]
        public byte Kids_Count { get; set; }
        [Required]
        public string User_Name { get; set; }

    }
}
