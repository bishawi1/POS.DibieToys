using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.Models
{
    public class BookSourceQueryModel
    {
        public short? Source_ID { get; set; }
        public DateTime? Invoice_Date { get; set; }
        public string? Book_Source_Desc { get; set; }
        public int? Book_ID { get; set; }
        public int? CountOfBook_ID { get; set; }
        public int? Book_Count { get; set; }
        public float? Book_Price { get; set; }
        public float? Book_Sell_Price { get; set; }
        public float? Book_Total_Sell_Price { get; set; }
        public byte? Curr_No { get; set; }
        public string? User_Name { get; set; }


    }

}
