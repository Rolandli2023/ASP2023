using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstArea
{
    class Rectangle: IArea, IPerimeter, IColor
    {
        
        public void CalculatePerimeter(int a, int b)
        {
            Console.WriteLine("The perimeter of Rectangle is {0}", 2 * (a + b));
        }
        public void GetColor()
        {
            Console.WriteLine("The color of Rectangle is blue!");
        }
        public void CalcultateArea(int a, int b)
        {
            Console.WriteLine("The area of Rectangle is {0}",a*b);
        }


    }
}
