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
            SqlConnection conn = new SqlConnection(connStr);
            // new sql command object
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "insert into [dbo].[customers]([customerContact],[customerCity],[customerBirthday]) values ('Tom','Milton','1980-01-01 00:00:00.000')";
                int nums = cmd.ExecuteNonQuery();
                if (nums != 0)
                {
                    Console.WriteLine("insert {0}\t records succesfully", nums);
                }

            }
            catch
            {
                Console.WriteLine("something is wrong! open database failure, please check!");
            }
            finally
            {
                conn.Close();
            }


        }
    }
}
