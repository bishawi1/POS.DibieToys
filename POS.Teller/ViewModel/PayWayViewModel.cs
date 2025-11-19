using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Teller.ViewModel
{
    public class PayWayViewModel
    {
        public int PayWayID { get; set; }
        public string PayWayDesc { get; set; }
        public decimal Amount { get; set; }
    }
}
