using System;

namespace ConsoleApp._20220122Task4
{
    /* 3 reqemli eded verilib. Bu ededin
     * axirina 7 artir. Sonra cavabin 7% tap*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 332;

            if (a >= 100 && a < 1000)
            {

                a = a * 10 + 7;
                a = a / 100 * 7;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine($"{a} ededi 3 reqemli deyil");
            }

        }

    }
}
