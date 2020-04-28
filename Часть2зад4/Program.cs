using System;

namespace Часть2зад4
{
    class Program
    {
        static void Main()
        {
            Int16 a = 6;
            Int32 b = 5;
            double c = 7;
            c = a;
            c = b;
            // a = c;
            // a = b;
            b = a;
            // b = c;
            a = (Int16)b;
             Console.WriteLine(a);
        }
    }
}
