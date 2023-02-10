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
            //Shape shape = new Circle(11);
            //double area = shape.Getarea();
            //double perimeter = shape.Getperimeter();

            //Console.WriteLine(" the shape of area is {0:0.00},\t Perimeter is {1:0.00}", area, perimeter);

             Shape shape = new Rectangle(22,16);
            
             double area = shape.Getarea();
             double perimeter = shape.Getperimeter();

            Console.WriteLine(" the shape of area is {0},\t Perimeter is {1}", area, perimeter);
        }
    }
}
