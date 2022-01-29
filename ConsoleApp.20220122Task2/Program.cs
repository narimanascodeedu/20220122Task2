using System;

namespace ConsoleApp._20220122Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 reqemli eded verilib. Bu ededin
             * axirina hemin ededdin ozunu yapishdir.
             * example: 333= 333333*/

            int a = 5552;

            if (a > 100 && a < 1000)

            {
                a = a * 1000 + a;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine($"{a} ededi 3 reqemli deyil");
            }
        }
    }
}
