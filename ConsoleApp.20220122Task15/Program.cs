using System;

namespace ConsoleApp._20220122Task15
{
    internal class Program
    {
        /* 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir.
         * 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi
         * ise 6 reqemlidir.     3 reqemli ededleri topla , sonra bunlarin
         * ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan
         * cavabi.Sonra neticenin axirina 7 reqemini artir. Sonra cavabin
         * ustune gel 5 reqemli ededlerin cemini.Sonra neticeden cix 3 reqemli
         * ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish
         * variantini.Sonra alinan cavabin ustune gel 6 reqemli ededi.Sonra
         * alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.Sonra
         * alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
         * Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel */
        static void Main(string[] args)
        {
            int a = 123;
            int b = 123;
            int c = 1234;
            int d = 1234;
            int e = 12345;
            int f = 12345;
            int g = 123456;
            int x;
            int y;


            if (a >= 100 && a < 1000 && b >= 100 && b < 1000 && c >= 1000 && c < 10000 &&
                d >= 1000 && d < 10000 && e >= 10000 && e < 100000 && f >= 10000 && f < 100000
                && g >= 100000 && g < 1000000)
            {
                x = a + b;
                x = x + (c * d);
                x = (x * 10) + 7;
                x = x + e + f;
                y = a * b;
                y = (a * 10) + 1;
                x = x - y;
                x = x + g;
                a = a + b + c + d;
                x = x - a;
                x = x / 100 * 18;
                x = x / 100 * 3;
                x = x / 100 * 1;
                x = x + e + f;

                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("ededler duzgun daxil edilmeyib");
            }
        }
    }
}
