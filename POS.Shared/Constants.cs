using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared
{
    public enum VoucherTypeEnum
    {
        All=0,
        Qabd=1,
        Sarf = 2,
        SalesInvoice=3,
        PurchaseInvoice=4,
        BackSalesTransaction=5,
        BackPurcahseTransaction=6
    }
    public enum PayWayEnum
    {
        Cash=1,
        Debits=2,
        Cheque=3,
        Transfere=4,
        Visa=5
    }
    public class Constants
    {
    }
}
