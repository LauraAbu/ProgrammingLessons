using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_new
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] dayinmonth = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int year;
            int month;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Please enter the year:");

                string yearinput = Console.ReadLine();

                if (!int.TryParse(yearinput, out year))
                {
                    Console.WriteLine("Invalid input. Please enter year number.");
                    continue;
                }
                if (year < 1)
                {
                    Console.WriteLine("Invalid year. Please provide correct input.");
                    continue;
                }
            Month:
                Console.WriteLine("Please enter the month number (1:12)");
               
                string monthinput = Console.ReadLine();

                if (!int.TryParse(monthinput, out month))
                {
                    Console.WriteLine("Invalid input. Please enter month number.");
                    goto Month;
                }
                if (month > 12 || month < 1)
                {
                    Console.WriteLine("There is only 12 months in a year. Please provide correct input.");
                    goto Month;
                }
                int totalDays = 0;
                for (int z = 0; z < 12; z++)
                {
                    if (month == z + 1)
                    {
                        totalDays = dayinmonth[z];
                        if (month == 2 & year % 4 == 0)
                        {
                            totalDays = 29;
                        }
                        break;
                    }
                }
                Console.WriteLine("{0}-{1} has {2} days", year, month, totalDays);

                Console.WriteLine("Do you want to continue?");

                string input = Console.ReadLine();

                if (input != "y")
                {
                    return;
                }
            }
        }
    }
}

    

