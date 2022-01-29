using System;

namespace ConsoleApp._20220122Task7
{
    internal class Program
    {
        /* 2 dene 5 reqemli eded verilib. Bu ededleri
         * toplayib. Alinan cavabin evveline ve axirina
         * 5 artir. Neticenin 5 % tap*/
        static void Main(string[] args)
        {
            int a = 11111;
            int b = 11111;
            int c = a + b;

            if ((a >= 10000 && a < 100000 && b >= 10000 && b < 100000) && c < 100000)
            {
                c = c + 500000;
                c = c * 10 + 5;
                c = c / 100 * 5;
                Console.WriteLine(c);
            }
            else if ((a >= 10000 && a < 100000 && b >= 10000 && b < 100000) && c >= 100000)
            {
                c = c + 5000000;
                c = c * 10 + 5;
                c = c / 100 * 5;
                Console.WriteLine(c);
            }
            else if ((a < 10000 || a >= 100000) && (b < 10000 || b >= 100000))
            {
                Console.WriteLine($"{a} ve {b} ededleri 5 reqemli deyil");
            }
            else if (a < 10000 || a >= 100000)
            {
                Console.WriteLine($"{a} ededi 5 reqemli deyil");
            }
            else //if (b < 10000 || b >= 100000)
                Console.WriteLine($"{b} ededi 5 reqemli deyil");


        }
    }
}
