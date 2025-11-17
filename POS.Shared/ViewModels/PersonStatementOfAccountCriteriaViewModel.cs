using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class PersonStatementOfAccountCriteriaViewModel
    {
        [Required]
        public int PersonId { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public bool WithPrevBalance { get; set; }=true;
    }
}
