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
            double workExperienceInYears; // = 0, reikėtų parašyti, kad reikšė yra 0 lygi. Jeigu incenizuojame kintamaji jam reikia priskiti reiksme. 
            string[] competenceLevelArray = new[] { "Entry", "Junior", "Mid-level", "Professional", "Senior" };//jeigu reikia rasyti kintamaji tarp stringo bloko - apsirasome virsuje. Jeigu tai yra funkcijos kintamasis reikia apsirasyti IF bloke                                                                                                   // išsikelia virs FOR kad nebutu apkraunama PC atmintis. 
            for (int i = 0; i < 100; i++) //amžinas FOR ciklas yra FOR(;;) jis neturi jokios salygos. While (true) ciklas sukasi tol kol bus tiesa.
            {
                Console.WriteLine("Kokia darbuotojo darbo patirtis?");

                string input = Console.ReadLine();
                if (input == "q")
                {
                    break; //išėjimas tik iš FOR ciklo. return iseina is kodo logikos. 
                }
            
                if (!double.TryParse(input, out workExperienceInYears))//!atvirkštinė logika - jeigu nelygu true
                { //galima cia rasyti if (input == "q")
                    Console.WriteLine("Klaida: Ivestas blogas argumentas. Ivesti galima tik skaiciu.");
                    continue;//netikrina logikos return
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
                else if (workExperienceInYears < 0 || workExperienceInYears > 100) //turi būti pakelta iki pirmutinio IF
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
