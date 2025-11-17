using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateTellerRequestDto
    {
        [Required]
        public int Teller_ID { get; set; }

        [Required]
        public string Teller_Name { get; set; }
        public string? Notes { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
    }
}
