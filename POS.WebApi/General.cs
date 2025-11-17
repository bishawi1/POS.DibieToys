using Newtonsoft.Json;
using POS.Shared.Models.Auth;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace POS.WebApi
{
    public class General
    {

        public static DataTable ConvertToDataTable(object oModel)
        {
            return JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(oModel));
        }


        public static string Recontruct(string Phrase)
        {
            string strPhrase = Phrase.Trim();
            int intIndex = 0;
            while (strPhrase.IndexOf("  ") > 0)
            {
                strPhrase = strPhrase.Replace("  ", " ");
                intIndex += 1;
                if (intIndex == 10)
                    break;
            }
            strPhrase = strPhrase.Replace("أ", "ا");
            strPhrase = strPhrase.Replace("إ", "ا");
            strPhrase = strPhrase.Replace("ة", "ه");
            return strPhrase;
        }

        public static DateTime convertToDate(string strDate)
        {
            string[] arr = strDate.Replace("/", "-").Replace(@"\", "-").Split("-");
            DateTime dtDate = new DateTime(Convert.ToInt32(arr[2]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[0]));
            return dtDate;
        }

        public static string retLocation(byte storeId, byte roomNo, byte columnNo, byte shelfNo)
        {
            string location;
            location = storeId.ToString("00") + "-" + roomNo.ToString("00");
            location = location + "-" + columnNo.ToString("00");
            location = location + "-" + shelfNo.ToString("00");
            return location;
        }

        public static DateTime GetCurrentTime()
        {
            DateTime serverTime = DateTime.Now;
            DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(serverTime, TimeZoneInfo.Local.Id, "Asia/Jerusalem");
            return _localTime;
        }
        public static DateTime GetCurrentDate()
        {
            DateTime serverTime = DateTime.Now;
            DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(serverTime, TimeZoneInfo.Local.Id, "Asia/Jerusalem");
            _localTime = new DateTime(_localTime.Year, _localTime.Month, _localTime.Day);
            return _localTime;
        }

    }
}
