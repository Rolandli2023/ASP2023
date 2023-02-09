using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstday7damo1
{
    public class Cat:Animal
    {
        public Cat(string name, int age, string id) : base(name, age)
        {
            //this.Name = name;
            //this.Age = age;
            this.Id = id;
        }
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void speak()
        {
            Console.WriteLine("I am Miao Miao!,I am {0}",this.Id);
            Sleeping();
        }



    }
}
