using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class Item_BrandModel
    {
        [Key]
        public int Item_Brand_ID { get; set; }

        public string Item_Brand_Name { get; set; }

    }
}
