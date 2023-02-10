using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal[] animal = {
            //    new Cat(),
            //    new Dog()


            //}
            //foreach (Animal aa in animal)
            //{
            //    aa.Speak();
            //}

            Animal a1 = new Cat();

            //Cat1 = new Cat();
            //Animal a1 = Cat1;

            Animal a2 = new Dog();

            a1.Speak();
            a2.Speak();


            Console.ReadKey();

        }
    }
}
