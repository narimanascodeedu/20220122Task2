using System;

namespace ConsoleApp._20220122Task5
{
    internal class Program
    {
        /* 4 reqemli eded verilib. Bu ededin 
         * evvelin 4 reqemi , axirina ise 44 
         * ededini artir. Alinan cavabin 44 % tap*/
        static void Main(string[] args)
        {
            int a = 1500;

            if (a >= 1000 && a < 10000)
            {

                a = a + 40000;
                a = a * 100 + 44;
                a = a / 100 * 44;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine($"{a} ededi 4 reqemli deyil");
            }
        }
    }
}
