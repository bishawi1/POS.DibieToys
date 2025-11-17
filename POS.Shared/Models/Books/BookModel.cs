using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models.Books
{
    public class BookModel
    {
        [Key]
        public int Book_ID { get; set; }

        public byte? Book_Subject_ID { get; set; }

        public short? Book_Cat_ID { get; set; }

        public short? Book_Publisher_ID { get; set; }

        public int? Book_Author_ID { get; set; }

        public DateTime Time_Stamp { get; set; }

        public string Book_Title { get; set; }

        public string? Book_Title_Search { get; set; }

        public string? Book_Subjects { get; set; }

        public string? Book_Notes { get; set; }

        public string User_Name { get; set; }

    }
}
