using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Book_AuthorModel
    {
        [Key]
        public int Book_Author_ID { get; set; }

        public int? Book_Author_Status_ID { get; set; }

        public DateTime? Book_Author_Status_Date { get; set; }

        public DateTime? Time_Stamp { get; set; }

        public string Book_Author_Desc { get; set; }

        public string? Book_Author_Notes { get; set; }

        public string? User_Name { get; set; }

    }
}
