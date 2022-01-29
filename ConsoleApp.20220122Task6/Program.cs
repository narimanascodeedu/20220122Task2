using System;

namespace ConsoleApp._20220122Task6
{
    internal class Program
    {
        /* 4 reqemli eded verilib. Bu ededin
         * evvel 20%-ni , sonra ise cavabin 10% tap.
         * Alinan cavabin kvadratini tap*/
        static void Main(string[] args)
        {
            int a = 1111;

            if (a >= 1000 && a < 10000)
            {
                a = a / 100 * 20;
                a = a / 100 * 10;
                a = a * a;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine($"{a} ededi 4 reqemli deyil");
            }
        }
    }
}
