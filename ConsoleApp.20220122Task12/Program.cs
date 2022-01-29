using System;

namespace ConsoleApp._20220122Task12
{
    internal class Program
    {
        /* 4 dene 6 reqemli eded verilib. Ededlerin
         * hamisinin 10 faizini tap ve topla. Sonra 
         * hamisinin 15 faizini tap ve topla.Sonra 
         * yekunda alinanlar iki cavabi vur biri birine.
        Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap */
        static void Main(string[] args)
        {
            double a = 123456;
            double b = 123456;
            double c = 123456;
            double d = 123456;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 &&
                c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000)
            {
                double x = a + b + c + d;
                double y = a + b + c + d;
                x = x / 100 * 10;
                y = y / 100 * 15;
                x = x * y;
                x = x / 100 * 10;
                x = x / 100 * 11;
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("daxil edilen eded veya ededler 6 reqemli deyil");
            }
        }
    }
}
