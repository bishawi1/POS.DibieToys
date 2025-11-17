using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class ErrorException : Exception
    {
        public int ErrorCode { get; set; }

        public string ErrorDesc { get; set; }
    }
}
