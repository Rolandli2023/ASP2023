using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Plane: IFlyable
    {
        public void Flying()
        {
            Console.WriteLine("I am a plane and flying!");
        }

    }
}
