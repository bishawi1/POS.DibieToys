using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class UpdateItemRequestModel
    {
        public int Item_ID { get; set; }
        public short Item_Unit_Id { get; set; }
        public string Item_Desc { get; set; }
        public short ItemGroupID { get; set; }
        public int Item_Brand_ID { get; set; }
        public string ItemNotes { get; set; }
        public string User_Name { get; set; }
        public byte UnitID { get; set; }
        public decimal Item_Unit_Price { get; set; }
        public decimal Item_Unit_Cost { get; set; }
        //public bool Is_Main_Unit { get; set; }
        //public bool Has_Expiry_Date { get; set; }
        //public bool Default_Unit { get; set; }
        public string Barcode { get; set; }
        public float Qnt_In_Basic_Unit { get; set; }
        public Int16 Source_ID { get; set; }
        public bool QuickAccess { get; set; } = false;

    }
}
