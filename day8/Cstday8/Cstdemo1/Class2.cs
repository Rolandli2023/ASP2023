using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    class Staff:person
    {
        public void StaffSpeak()
        {
            Console.WriteLine("This is child of staff.");
        }
    }
}
