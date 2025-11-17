using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class CreateSourceRequestDto
    {
        public string Book_Source_Desc { get; set; }
        public string? Book_Source_Notes { get; set; }
        public string? User_Name { get; set; }
        public Int16? Person_ID { get; set; }

    }
}
