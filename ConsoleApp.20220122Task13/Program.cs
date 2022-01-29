using System;

namespace ConsoleApp._20220122Task13
{
    internal class Program
    {
        /* 5 dene eded verilib. Bunlardan 3 denesi
         * 5 reqemli. 2 denesi ise 3 reqemlidir.
         * 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
         * Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla.
        Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla */
        static void Main(string[] args)
        {
            double a = 12345;
            double b = 12345;
            double c = 12345;
            double d = 123;
            double e = 123;

            a = a / 100 * 5;
            b = b / 100 * 5;
            c = c / 100 * 5;

            a = a * b * c;
            d = d + e;
            d = d / 100 * 3;
            a = a / 100 * 10;
            d = d / 100 * 10;
            a = a + d;
            Console.WriteLine(a);



        }
    }
}
