using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateCityRequestDto
    {
        [Required]
        public string City_Name { get; set; }

        public string? City_Notes { get; set; }

        public string? User_Name { get; set; }
    }
}
