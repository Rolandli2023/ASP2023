using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstday7damo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat ct1 = new Cat("Jackey",18,"001");
            ct1.SayHello();
            ct1.speak();
            ct1.Move();
            //ct1.Sleeping();
            Cat ct2 = new Cat("Tom", 12, "007");
            ct2.SayHello();
            ct2.Move();
            ct2.speak();

        }
    }
}
