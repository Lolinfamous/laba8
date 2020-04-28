using System;

namespace Лаб8
{
    class Program
    {
        class Train
        {
            public string nomer, mes;
            public int kolv;
            public enum typeTraine : byte { skTrain, pasTrain, tTrain };
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

        class FirmTrain : Train
        {
            public string nameFirm;
            public double kPrice;
            public FirmTrain(string nomer, string mes, int kolv, int a, string b, double e) : base(nomer, mes, kolv, a)
            {
                this.nomer = nomer;
                this.mes = mes;
                this.kolv = kolv;
                this.a = (typeTraine)a;
                this.nameFirm = b;
                this.kPrice = e;
            }
            public override string ToString()
            {
                return "Поезд с номером " + nomer + " прибыл на третий путь с сообщением : " + mes + ", в количестве " + kolv + " вагонов " + a + " название фирменного поезда " + nameFirm + " коэффициент удорожания " + kPrice;
            }
        }
        static void Main()
        {
            FirmTrain a = new FirmTrain("666", "Пора в универ", 666, 0, "ДГТУ", 2.2);
            Console.WriteLine(a.ToString());
        }

    }
}
