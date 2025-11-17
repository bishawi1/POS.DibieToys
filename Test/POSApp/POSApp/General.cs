using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp
{

    public class General
    {
        public static SqlConnection? Connection { get; set; }
    }
}
