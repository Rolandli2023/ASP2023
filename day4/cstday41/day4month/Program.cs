using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4month
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("please input year__");

                int year = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("please input Month__");
                try
                {

                    int month = Convert.ToInt32(Console.ReadLine());

                    if (month >= 1 && month <= 12)
                    {




                        int day = 0;

                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;

                            default:

                                day = 30;
                                break;
                        }
                        Console.WriteLine("year{0},month{1},day{2}", year, month, day);
                    }
                    else
                        Console.WriteLine("the month {0} is invalid", month);

                }
                catch
                {
                    Console.WriteLine("the month you input is invalid,program exit");
                }
            }

            catch
            {

                Console.WriteLine("the year you input is invalid,program exit!!");
            }
        }
    }
}
   
    
