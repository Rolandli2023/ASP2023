using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstArea
{
    public class Rectangle :IPolygon, IPerimeter, IColor
    {
        public void CalculateArea(int a, int b)
        {
            Console.WriteLine("The area of Rectangle is {0}", a * b);

        }
        public void CalculatePerimeter(int a, int b)
        {
            Console.WriteLine("The perimeter of Rectangle is {0}", 2 * (a + b));
        }
        public void GetColor()
        {
            Console.WriteLine("The color of Rectangle is blue!");
        }

    }
}
