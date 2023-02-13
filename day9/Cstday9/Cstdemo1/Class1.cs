using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Bird:IFlyable, ITaxcau

    {
        public void Flying()
        {
            Console.WriteLine("I am a bird, I am flying!");
        }
        //public void add()
        //{
        //    Console.WriteLine("This is add.");
        //}
        public void Taxcalculter()
        {
            Console.WriteLine("This is Tax calculter of bird");

        }
    }
}
