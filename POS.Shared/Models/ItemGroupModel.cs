using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Item_GroupModel
    {
        [Key]
        public short Item_Group_ID { get; set; }

        public short Parent_Item_Group_ID { get; set; }

        public bool Leaf_Item_Group { get; set; }

        public string? Item_Group_Desc { get; set; }

        public string Item_Group_No { get; set; }

        public string? Item_Group_Notes { get; set; }

    }
}
