using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs.Books
{
    public class UpdatePublisherRequestDto
    {
        public short Publisher_ID { get; set; }

        public string Publisher_Desc { get; set; }

        public string? Publisher_Notes { get; set; }

        public string? User_Name { get; set; }

    }
}
