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
            Console.WriteLine("Kokia darbuotojo darbo patirtis?");

            string input = Console.ReadLine();

            double experience;
            if (double.TryParse(input, out experience)== false)
            {
                Console.WriteLine("Klaida: Ivestas blogas argumentas. Ivesti galima tik skaiciu.");
                Console.ReadLine();
                return;
            
            }
                

            if (experience == 0)
            {
                Console.WriteLine("Entry");
            }
            else if (experience > 0 && experience < 2)
            {
                Console.WriteLine("Junior");
            }
            else if (experience >= 2 && experience < 4)
            {
                Console.WriteLine("Mid-level");

            }
            else if (experience >= 4 && experience < 6.5)
            {
                Console.WriteLine("Professional");
                
            }
           
            else if (experience <0 || experience >100)
            {
                Console.WriteLine("Klaida: Darbo patirtis metais negali buti mazesne nei 0 arba didesne nei 100.");
            }
            else if (experience > 6.5)
            {
                Console.WriteLine("Senior");

            }
            Console.ReadLine();
        }

    }
}
