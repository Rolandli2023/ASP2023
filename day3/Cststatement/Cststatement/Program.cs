using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cststatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter one integer number");
            int nums = Convert.ToInt32(Console.ReadLine()) ;

            if (nums % 2 == 0)
            {
                Console.WriteLine("{} is even",nums);
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("the number is odd",nums);
                Console.ReadLine();


            }

        }
    }
}
