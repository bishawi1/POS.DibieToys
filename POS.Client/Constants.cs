using POS.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Client
{
    public class Constants
    {
        public static string ArchiveBaseUrl { get; set; } = "http://layancargo-001-site9.ltempurl.com/";// "http://data.layan-tekstil.com";
        
        // public static string ArchiveBaseUrl { get; set; } = "http://localhost:5085/";// "http://data.layan-tekstil.com";       
        
        
        public static string BaseUrl { get; set; } = "http://dbitoyspos-001-site1.ltempurl.com/Api/";

        
        //public static string BaseUrl { get; set; } = "http://localhost:5090/Api/";// "http://data.layan-tekstil.com";

        


        public static short CashCustomer_ID { get; set; } = 1;
        public static short OnlineCustomer_ID { get; set; } = 2;

    }
}
