using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[10];   //int array
            ////nums[0] = 1;
            ////nums[1] = 5;
            ////nums[8] = 22;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //    Console.WriteLine(nums[i]);

            //}


            //Console.ReadKey();

            int[] nums = { 10, 20, 30, 50, 40, 33, 88, 66 };
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)//internal loop
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;



                    }
                }
                //bubble sort
            }
            for (int i = 0; i < nums.Length; i++)//external loop
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
    }
}
