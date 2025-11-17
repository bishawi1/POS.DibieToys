using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class SourceModel
    {
        [Key]
        public Int16 Book_Source_ID { get; set; }
        [Required]
        public string Book_Source_Desc { get; set; }
        public string? Book_Source_Notes { get; set; }
        public byte? Book_Source_Status_ID { get; set; }
        public DateTime? Book_Source_Status_Date { get; set; }
        public string? User_Name { get; set; }
        public DateTime? Time_Stamp { get; set; }
        public int? Person_ID { get; set; }

    }
}
