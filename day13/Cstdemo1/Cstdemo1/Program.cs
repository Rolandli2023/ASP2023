using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cstdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "uid=sa;pwd=Allen2013;server=192.168.2.253;database=market";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "";
                    int nums=cmd.ExecuteNonQuery();
                    if (nums != 0)
                    {
                        Console.WriteLine("{0} records insert successfully!!",nums);
                    }
                }
            }
        }
    }
}
