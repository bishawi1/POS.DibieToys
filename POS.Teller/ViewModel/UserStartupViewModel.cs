using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Teller.ViewModel
{
    public class UserStartupViewModel
    {
        public string? UserName { get; set; }
        public bool RememberMe { get; set; }=false;
        public string? Password { get; set; }
        public int? BranchId { get; set; }
        public int? TellerId { get; set; }


    }
}
