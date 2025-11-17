using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models.Books
{
    public class PublisherModel
    {
        [Key]
        public short Publisher_ID { get; set; }

        public int? Publisher_Status_ID { get; set; }

        public DateTime? Publisher_Status_Date { get; set; }

        public DateTime? Time_Stamp { get; set; }

        public string Publisher_Desc { get; set; }

        public string? Publisher_Notes { get; set; }

        public string? User_Name { get; set; }

    }
}
