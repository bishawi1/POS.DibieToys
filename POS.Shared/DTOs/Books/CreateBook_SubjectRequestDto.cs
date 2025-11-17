using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs.Books
{
    public class CreateBook_SubjectRequestDto
    {
        public string Book_Subject_Desc { get; set; }

        public string? Book_Subject_Notes { get; set; }

        public string? User_Name { get; set; }
    }
}
