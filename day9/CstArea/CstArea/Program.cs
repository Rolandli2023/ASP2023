using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.CalcultateArea(15, 10);
            r1.CalculatePerimeter(15, 10);
            r1.GetColor();


            Console.ReadKey();
        }
    }
}
