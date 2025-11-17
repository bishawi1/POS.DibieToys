using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateTransactionTypeRequestDto
    {
        [Key]
        public int Transaction_Type_ID { get; set; }

        [Required]
        public string Transaction_Type_Desc { get; set; }

    }
}
