using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo2
{
    class Rectangle:IPolygon,IColor,IPerimeter
    {
         public void CalculateArea(int a, int b)
         {
            Console.WriteLine("the area of Rectangle is {0}", a * b);

         }
         public void CalculatePerimeter(int a, int b)
        {
            Console.WriteLine("The perimeter of Rectangle is {0}",2*(a+b);
        }
         public void GetColor()
         {
            Console.WriteLine("blue");
         }

    }
}
