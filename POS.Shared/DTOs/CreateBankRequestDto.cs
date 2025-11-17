using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class CreateBankRequestDto
    {
        [Required]
        public string Bank_Name { get; set; }

        public string? Bank_Notes { get; set; }
    }
}
