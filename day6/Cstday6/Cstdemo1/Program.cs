﻿using System;
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
            Person p1 = new Person("Tom","Male",20);
            //p1.Name = "Tom";
            //p1.Gender = "Male";
            //p1.Age = 20;
            p1.Speak();
            p1.walk();


            Console.ReadKey();

            Person p2 = new Person("Alice","Tiger",-10);
            //p2.Name = "Alice";
            //p2.Gender = "Tiger";
            //p2.Age = -10;
            p2.Speak();
            p2.walk();




            Console.ReadKey();

            Person p3 = new Person("Bob","Hungry",200);
            //p3.Name = "Bob";
            //p3.Gender = "I am Hungry";
            //p3.Age = 200;
            p3.Speak();
            p3.walk();


            Console.ReadKey();

            Person p5 = new Person("Anderson", "Male", 600,2);
            
            p5.Speak();
            Person.MakeMoney();

            p5.walk();


            Console.ReadKey();







        }
    }
}
