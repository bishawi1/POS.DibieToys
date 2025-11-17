using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Teller_UserModel
    {
        [Key]
        public int Teller_User_ID { get; set; }
        [Required]
        public int Teller_ID { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public DateTime From_Date { get; set; }
        public DateTime? To_Date { get; set; }
        public string? Notes { get; set; }
        public byte Branch_ID { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
