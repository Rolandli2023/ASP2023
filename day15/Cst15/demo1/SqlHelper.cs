using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace demo1
{
    public class SqlHelper
    {
        public static string GetSqlconnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        }
    }
}
