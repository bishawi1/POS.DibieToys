using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models.Books
{
    public class Book_SubjectModel
    {
        [Key]
        public int Book_Subject_ID { get; set; }

        public int? Book_Subject_Status_ID { get; set; }

        public DateTime Book_Subject_Status_Date { get; set; }

        public DateTime Time_Stamp { get; set; }

        public string Book_Subject_Desc { get; set; }

        public string? Book_Subject_Notes { get; set; }

        public string? User_Name { get; set; }

    }
}
