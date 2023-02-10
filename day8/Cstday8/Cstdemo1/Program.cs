using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Staff sf1 = new Staff();
            //person p1 = sf1;
            Staff st1 = new Staff();
            st1.StaffSpeak();
            st1.Speak();
            Console.ReadKey();

            person p1 = new person();
            p1.Speak();
            Console.ReadKey();

            Staff st2 = (Staff)p1; //base to child

            st2.StaffSpeak();


            //st9.StaffSpeak();

            //person p1 = new Staff();
            //string str = string.Join("=",new string[] { "Tom", "Joey", "Alice", "Bob" });
            //Console.WriteLine(str);
            //Console.ReadLine();
        }
    }
}
