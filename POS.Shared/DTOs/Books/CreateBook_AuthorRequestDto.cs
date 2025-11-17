using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs.Books
{
    public class CreateBook_AuthorRequestDto
    {
        public string Book_Author_Desc { get; set; }

        public string? Book_Author_Notes { get; set; }

        public string? User_Name { get; set; }

    }
}
