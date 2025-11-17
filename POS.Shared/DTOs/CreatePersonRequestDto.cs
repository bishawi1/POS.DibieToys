using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class CreatePersonRequestDto
    {
        [Required]
        public string Person_Name { get; set; }

        public string? Commercial_Name { get; set; }

        public string? Address { get; set; }
        public byte? City_ID { get; set; }

        public short? Person_Account_ID { get; set; }

        public Single? Sell_Discount_Percent { get; set; }

        public decimal? Begining_Balance_Amount { get; set; }

        public string? Mobile { get; set; }

        public byte? Person_Cat_ID { get; set; } = 0;

        public string? Person_Notes { get; set; }
        [Required]
        public string User_Name { get; set; }
    }

}
