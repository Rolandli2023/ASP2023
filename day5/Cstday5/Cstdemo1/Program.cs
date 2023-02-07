using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creat object from class Person
           Person P1 = new Person();
            P1._name = "Tom";
            P1._gender = "male" ;
            P1._age = 28;
            P1.M1();
            Console.WriteLine("this is {0},gender {1},I am {2}", P1._name, P1._gender, P1._age);

            Console.ReadKey();
            //Person.M2();
            Person P2 = new Person();
            P2._name = "Alice";
            P2._gender = "Female";
            P2._age = -100;
            Console.WriteLine(" this is {0},gender\t {1}\t, I am {2}",P2._name,P2._gender,P2._age);
            Console.ReadKey();

            Person P3 = new Person();
            P3._name = "Bob";
            P3._gender = "Lion";
            P3._age = 200;
            Console.WriteLine(" this is {0},gender\t {1}\t, I am {2}", P3._name, P3._gender, P3._age);
            Console.ReadKey();
        }
    }
}
