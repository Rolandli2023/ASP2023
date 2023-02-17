using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server= 192.168.2.253; uid=sa;pwd=Allen2013;database=Cstlabs01";
            SqlConnection conn2 = new SqlConnection(connStr);
            conn2.Open();
            Console.WriteLine("database was opened");
            //Thread.Sleep(2000);
            Console.ReadKey();
            conn2.Close();
            Console.WriteLine("database was closed");
        }
    }
}
