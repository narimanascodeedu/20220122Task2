using System;

namespace ConsoleApp._20220122Task11
{
    internal class Program
    {
        /* 4 dene 5 reqemli eded verilib.
         * Her I ededin ustune III ededi gel .
         * II ededin usutune IV eeddi gel.
         * Sonra cavablari vur birbirine.
         * Alinan neticeden III ededin 3%-ni cix*/
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 12345;
            int c = 12345;
            int d = 12345;

            bool isSuccess = (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 &&
                c >= 10000 && c < 100000 && d >= 10000 && d < 100000);
            if (!isSuccess)
            {
                Console.WriteLine("daxil edilen eded veya ededler 5 reqemli deyil");
                return;
            }
            a = a + c;
            b = b + d;
            a = a * b;
            c = c / 100 * 3;
            a = a - c;
            Console.WriteLine(a);

        }
    }
}
