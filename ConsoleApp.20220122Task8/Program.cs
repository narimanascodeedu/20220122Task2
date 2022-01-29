using System;

namespace ConsoleApp._20220122Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
                I ededin 4%-ni tap.
                Sonra II ededin 9% ni tap.
                Sonra Cavalari toplayib 10 %ni tap*/

            int a = 1111;
            int b = 1111111;


            if (a >= 1000 && a < 10000 && b >= 1000000 && b < 10000000)
            {
                a = a / 100 * 4;
                b = b / 100 * 9;
                a = a + b;
                a = a / 100 * 10;

                Console.WriteLine(a);
            }
            else if (a < 1000 && a >=10000)
            {
                Console.WriteLine($"{a} ededi 4 reqemli deyil");
            }
            else
            {
                Console.WriteLine($"{b} eded 7 reqemli deyil");
            }
        }
    }
}
