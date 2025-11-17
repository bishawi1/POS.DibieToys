using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class ResultModel
    {
        public Object Data { get; set; }
        public string StatusCode { get; set; }
        public string ErrorText { get; set; }

    }
}
