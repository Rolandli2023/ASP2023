using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //SayHello();


            //void SayHello()
            //{
            //    Console.WriteLine("Welcome to CST college.!!");

            //    Console.ReadKey(); }

            string mystr = "Tom";
            string resultstr;
            resultstr = Sayhello(mystr);
            Console.WriteLine(resultstr);
            Console.WriteLine(Sayhello());

            Console.ReadLine();

            string Sayhello(string str="Joy")
            {
                string mess1 = "Happy Chinese new year 2023";
                string mess2 = "Welcome!!";
                string message = "Welcome to CST college:" + str + mess1+ mess2;
                return message;
                


            }


           


        
        }
    }
}
