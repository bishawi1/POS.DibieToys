



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class AddItemBrandRequestDto
    {
        [Required]
        public string Item_Brand_Name { get; set; }

    }
}
