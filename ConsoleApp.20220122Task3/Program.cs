using System;

namespace ConsoleApp._20220122Task3
{
    internal class Program
    {
        /* 5 reqemli eded verilib. Bu ededin
         * evvel 18 % sonra ise 3 % tap*/
        static void Main(string[] args)
        {
            int a = 11111;
            int b;
            int c;

            if (a > 10000 && a < 100000)
            {
                b = a / 100 * 18;
                c = a / 100 * 3;


                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine($"{a} ededi 5 reqemli deyil");
            }

        }
    }
}
