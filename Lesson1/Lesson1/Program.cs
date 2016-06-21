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
                string[] competence = new[] { "Entry", "Junior", "Mid-level", "Professional", "Senior" };

                double experience;
                if (double.TryParse(input, out experience) == false)
                {
                    Console.WriteLine("Klaida: Ivestas blogas argumentas. Ivesti galima tik skaiciu.");
                   
                    continue;

                }


                if (experience == 0)
                {
                    Console.WriteLine(competence[0]);
                }
                else if (experience > 0 && experience < 2)
                {
                    Console.WriteLine(competence[1]);
                }
                else if (experience >= 2 && experience < 4)
                {
                    Console.WriteLine(competence[2]);

                }
                else if (experience >= 4 && experience < 6.5)
                {
                    Console.WriteLine(competence[3]);

                }

                else if (experience < 0 || experience > 100)
                {
                    Console.WriteLine("Klaida: Darbo patirtis metais negali buti mazesne nei 0 arba didesne nei 100.");
                }
                else if (experience > 6.5)
                {
                    Console.WriteLine(competence[4]);

                }
            }
            Console.ReadLine();
        }
        

    }
}
