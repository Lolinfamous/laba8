using System;
using System.Threading;

namespace Часть3
{
    class Program
    {
        public static double calculate(string s)
        {
            int cont = 0;

        }
        public static int whatsstring(string a)
        {
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {
                switch (a[i])
                {
                    case '0':
                        b += 0 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '1':
                        b += 1 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '2':
                        b += 2 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '3':
                        b += 3 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '4':
                        b += 4 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '5':
                        b += 5 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '6':
                        b += 6 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '7':
                        b += 7 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '8':
                        b += 8 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                    case '9':
                        b += 9 * (int)Math.Pow(10, (a.Length - i - 1));
                        break;
                }
            }
            return b;
        }
        static void Main()
        {
            string b = "223232", c = "12";
            Console.WriteLine(whatsstring(b));
        }
    }
}
