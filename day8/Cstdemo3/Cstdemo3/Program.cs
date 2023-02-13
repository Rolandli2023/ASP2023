using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape C1 = new Circle(11);
            double area1 = C1.Getarea();
            double perimeter1 = C1.Getperimeter();

            Console.WriteLine(" the area of Circle is {0:0.00},\t Perimeter is {1:0.00}", area1, perimeter1);

             Shape r1= new Rectangle(22,16);
            
             double area2 = r1.Getarea();
             double perimeter2 = r1.Getperimeter();

            Console.WriteLine(" the area of Rectangle is {0},\t Perimeter is {1}", area2, perimeter2);
        }
    }
}
