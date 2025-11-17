using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs.Books
{
    public class CreateBookRequestDto
    {
        public byte? Book_Subject_ID { get; set; }

        public short? Book_Cat_ID { get; set; }
        public string ISBN { get; set; }

        public short? Book_Publisher_ID { get; set; }

        public int? Book_Author_ID { get; set; }

        public string Book_Title { get; set; }

        public string? Book_Notes { get; set; }
        public decimal ItemUnitPrice { get; set; }
        public decimal ItemUnitCost { get; set; }
        public int Qnt { get; set; }
        public string User_Name { get; set; }

    }
}
