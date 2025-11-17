using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateCurrencyRequestDto
    {
        [Key]
        public byte Currency_ID { get; set; }

        public byte Curr_Status_ID { get; set; }

        public byte Accounting_Group_ID { get; set; }

        public DateTime Currency_Status_Date { get; set; }

        public bool Base_Currency { get; set; }

        public string Currency_Symbol { get; set; }

        public string Currency_Name { get; set; }

        public string? Currency_Notes { get; set; }

        public string User_Name { get; set; }

    }
}
