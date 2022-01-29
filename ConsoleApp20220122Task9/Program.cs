using System;

namespace ConsoleApp20220122Task9
{
    internal class Program
    {
        /* 3 dene 6 reqemli eded verilib.
         * Her birinin 10 faizini tapib 
         * neticeleri topla. Alinan cavabin 10% tap*/
        static void Main(string[] args)
        {
            int a = 123456;
            int b = 123456;
            int c = 123456;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 &&
                 c < 1000000)
            {
                a = a + b + c;
                a = a / 100 * 10;
                a = a / 100 * 10;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("daxil edilen eded veya ededler 6 reqemli deyil");
            }


        }
    }
}
