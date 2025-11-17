using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class VoucherTotalViewModel
    {
        public byte voucher_Type_ID { get; set; }
        public string Voucher_Type_Desc { get; set; }
        public string Pay_Way_Desc { get; set; }

        public byte Pay_Way_Id { get; set; }
        public decimal Amount { get; set; }

    }
}
