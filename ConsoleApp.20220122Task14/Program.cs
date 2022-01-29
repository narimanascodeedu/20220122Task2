using System;

namespace ConsoleApp._20220122Task14
{
    internal class Program
    {
        /* 6 dene 6 reqemli eded verilib. Evvel hamisini topla .
         * Sonra I ve III ededi bir birine yapishdir ve bir eded al.
         * I neticeden II neticeni cix. Alinan cavabin 10% tap. 
         * Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap */
        static void Main(string[] args)
        {
            double a = 123456;
            double b = 123456;
            double c = 123456;
            double d = 123456;
            double e = 123456;
            double f = 123526;
            double x;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 &&
                c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 &&
                e >= 100000 && e < 1000000 && f >= 100000 && f < 1000000)
            {    
                x = a + b + c + d + e + f;
                a = a * 1000000 + c;
                x = x - a;
                x = x / 100 * 10;
                x = x + e + f;
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
