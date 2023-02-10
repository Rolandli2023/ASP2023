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
            Cat ct1 = new Cat("Tom",12,"009");
            ct1.SayHello();
            ct1.speak();
            ct1.Move();
            //ct1.Sleeping();
            Cat ct2 = new Cat("Bob", 20, "100");
            ct2.SayHello();
            ct2.Move();
            ct2.speak();

        }
    }
}
