using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
     public class Person
     {
        public string _name;  //class person,one field(_name)
        public string _gender;
        public int _age;

        public void M1()
        {
            Console.WriteLine("this is not static method!");
        }
        public void M2()
        {
            Console.WriteLine("this staic method of person of the person");
        }



     }
}
