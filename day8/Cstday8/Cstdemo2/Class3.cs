using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo2
{
    class Dog:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("this is Dog from Child class");
        }
        
    }
}
