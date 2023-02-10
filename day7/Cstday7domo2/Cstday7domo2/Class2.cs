using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstday7domo2
{
    class Staff:person
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public new void Speak() //rewrite speak
        {
            Console.WriteLine("I am taking on class of staff");
        }
    }
}
