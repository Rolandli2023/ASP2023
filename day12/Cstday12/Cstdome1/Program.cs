using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cstdome1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server= 192.168.2.253; uid=sa;pwd=Allen2013;database=Cst_student";
            SqlConnection conn1 = new SqlConnection(connStr);
            conn1.Open();
            Console.WriteLine("database was opened");
            //Thread.Sleep(2000);
            Console.ReadKey();
            conn1.Close();
            Console.WriteLine("database was closed");

        }
    }
}
