using System;

namespace Зад3
{
    class Program
    {

        static void Main()
        {
            SByte a = 0;
            Byte b = 1;
            Int16 c = 3;
            Int32 d = 4;
            Int64 e = 5;
            String f = "Строка";
            Exception ex = new Exception();
            Object[] types = { a, b, c, d, e, f, ex };
            foreach (object a1 in types)
                Console.WriteLine($"{a1.GetType().IsValueType}");
            foreach (object a1 in types)
                if(a1.GetType().IsValueType.ToString() == "True") Console.WriteLine($"{a1.GetType()} - значимый тип");
                else Console.WriteLine($"{a1.GetType()} - ссылочный тип");
        }
    }
}
