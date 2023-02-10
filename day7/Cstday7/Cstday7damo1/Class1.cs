using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstday7damo1
{
    public class Animal
    {
        //construction
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("This is {0}\t, It is {1} years old",this.Name,this.Age);

        }
        public void Move()
        {
            Console.WriteLine("It is running!!");
        }
        private void Eat()
        {
            Console.WriteLine("This is my private food");
        }
        protected void Sleeping()
        {
            Console.WriteLine("I am sleeping by protected!!");
        }


    }
}
