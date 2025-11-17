using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.DTOs
{
    public class UpdateItemGroupRequestDto
    {
        public short Item_Group_ID { get; set; }

        public string Item_Group_Desc { get; set; }
        public string Item_Group_No { get; set; }
        public short Parent_Item_Group_ID { get; set; }
        public string Item_Group_Notes { get; set; }
        public bool Leaf_Item_Group { get; set; } = false;
    }
}
