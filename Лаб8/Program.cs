using System;

namespace Лаб8
{
    class Program
    {   
        public struct Train
        {
            public string nomer, mes;
            public int kolv;
            public enum typeTraine: byte { skTrain , pasTrain, tTrain};
            public typeTraine a;
            public Train(string a, string b, int c, int d)
            {
                this.nomer = a;
                this.mes = b;
                this.kolv = c;
                this.a = (typeTraine)d;
        }
            public override string ToString()
            {   
                return "Поезд с номером " + nomer + " прибыл на третий путь с сообщением : " + mes + ", в количестве " + kolv + " вагонов " + a;
            }
        }
        static void Main()
        {
            Train a = new Train("666","Пора в универ",666, 0);
            Console.WriteLine(a.ToString());
        }

    }
}
