using System;

namespace ConsoleApp._20220122Task1
{
    internal class Program
    {
        /* 4 reqemli eded verilib. Bu ededin eveline
         * 7 reqemini , axirinada 8 reqemini artir.
         * Example1: 3333= 73338*/
        static void Main(string[] args)
        {
            int a = 3333;


            if (a >= 1000 && a < 10000)

            {
                a = a + 70000;
                a = a * 10 + 8;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine($"{a} ededi 4 reqemli deyil");
            }

        }
    }
}
