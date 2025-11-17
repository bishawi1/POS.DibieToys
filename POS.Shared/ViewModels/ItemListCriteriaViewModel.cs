using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class ItemListCriteriaViewModel
    {
        public int? Item_ID { get; set; }
        public string? Barcode { get; set; }
        public string? Item_Desc { get; set; }
        public long? Item_Group_ID { get; set; }
        public bool IncludeQuickAccess { get; set; } = false;

        public bool QuickAccess { get; set; } = false;

    }
}
