using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temArr = { "Tom", "Anderson", "Zoey", "Alice", "Bob" };
            List<string> strlist = new List<string>(temArr);
            strlist.Add("John");
            strlist.Remove("Tom");
            for (int i = 0; i < strlist.Count; i++)
            {
                Console.WriteLine("each item is {0}",strlist[i]);
                Console.ReadKey();
            }
            

        }
    }
}
