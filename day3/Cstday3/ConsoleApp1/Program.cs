using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          

            //bool AreYouReady;
            //AreYouReady = false;
            //Console.WriteLine(AreYouReady); 

            //int i = 1990;
            //if (i > 2000)
            //{
            //    Console.WriteLine("i > 2000");


            //}
            //else
            //{
            //    Console.WriteLine( "i < 2000");


            //}

           

            /*
             * print out student mark
             * score
             */
           
            Console.WriteLine("please put student's score (integer between 0~100)");

            int points = Convert.ToInt32(Console.ReadLine());
            switch (points / 10)
            {
                case 10:
                    Console.WriteLine("great");
                    break;
                case 9:
                    Console.WriteLine("perfect");
                    break;
                case 8:
                    Console.WriteLine("good");
                    break;
                case 7:
                    Console.WriteLine("pass");
                    break;
                case 6:
                    Console.WriteLine("pass");
                    break;
                default:
                    Console.WriteLine("failed");
                    break;

            }
            //end switch

            Console.ReadKey();

        }
    }
}
