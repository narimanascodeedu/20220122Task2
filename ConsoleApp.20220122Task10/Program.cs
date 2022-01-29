using System;

namespace ConsoleApp._20220122Task10
{
    internal class Program
    {
        /* 3 dene 4 reqemli eded verilib.
         * I ededin 1%-ni, II ededin 2% ,
         * III ededin 3 % tap.Neticeleri
         * bir birinden cix. Alinan cavabin
         * ustune III ededin 7% faizini gel*/
        static void Main(string[] args)
        {
            int a = 2222;
            int b = 2222;
            int c = 2222;
            int f = c / 100 * 7;
            if (a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000)
            {
                a = a / 100 * 1;
                b = b / 100 * 2;
                c = c / 100 * 3;
                a = a - b - c;
                a = a + f;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("daxil edilen eded veya ededler 4 reqemli deyil");
            }



        }
    }
}
