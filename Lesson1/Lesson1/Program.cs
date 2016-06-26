using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Kokia darbuotojo darbo patirtis?");

                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                string[] competenceLevelArray = new[] { "Entry", "Junior", "Mid-level", "Professional", "Senior" };

                double workExperienceInYears;
                if (!double.TryParse(input, out workExperienceInYears))
                {
                    Console.WriteLine("Klaida: Ivestas blogas argumentas. Ivesti galima tik skaiciu.");
                   
                    continue;
                }
               
                if (workExperienceInYears == 0)
                {
                    Console.WriteLine(competenceLevelArray[0]);
                }
                else if (workExperienceInYears > 0 && workExperienceInYears < 2)
                {
                    Console.WriteLine(competenceLevelArray[1]);
                }
                else if (workExperienceInYears >= 2 && workExperienceInYears < 4)
                {
                    Console.WriteLine(competenceLevelArray[2]);
                }
                else if (workExperienceInYears >= 4 && workExperienceInYears < 6.5)
                {
                    Console.WriteLine(competenceLevelArray[3]);
                }
                else if (workExperienceInYears < 0 || workExperienceInYears > 100)
                {
                    Console.WriteLine("Klaida: Darbo patirtis metais negali buti mazesne nei 0 arba didesne nei 100.");
                }
                else if (workExperienceInYears > 6.5)
                {
                    Console.WriteLine(competenceLevelArray[4]);
                }
            }
        }
    }
}
