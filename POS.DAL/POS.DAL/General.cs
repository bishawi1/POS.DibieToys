using POS.DAL.Contracts;
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

namespace POS.DAL
{
    public class General
    {



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



    }
}
