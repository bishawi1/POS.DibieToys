using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class CityModel
    {
        [Key]
        public byte City_ID { get; set; }
        [Required]
        public string City_Name { get; set; }
        public string? City_Notes { get; set; }
        public string? User_Name { get; set; }
        public DateTime? Time_Stamp { get; set; }

    }
}
