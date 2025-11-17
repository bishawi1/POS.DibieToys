using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateBranchRequestDto
    {
        public byte Branch_ID { get; set; }
        public string Branch_Name { get; set; }
        public string? Notes { get; set; }
        public string User_Name { get; set; }

    }
}
