using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D4.TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;

            //Bilincli tur donusumu

            int sayi2 = 125;

            sayi1 = (byte)sayi2;

            Console.WriteLine(sayi1);

            //Bilincsiz tur donusumu

            double sayi3 = 10;

            sayi3 = sayi2;//sayi2 int sayi3 double. double daha genis aralik yani int'i kapsar 

            Console.WriteLine(sayi3);

            //checked - unchecked

            sayi2 = 512;

            sayi1 = (byte)sayi2; //byte max 255 olabilir. sayi2 512 oldugundan sayi1'e esitlemeye calisinca deger kaybi yasiyoruz ve sayi1 direk 0 oluyor

            unchecked
            {
                sayi2 = 512;

                sayi1 = (byte)sayi2;
            }

            //checked
            //{
            //    sayi2 = 512;

            //    sayi1 = (byte)sayi2;
            //}

            

            Console.Write("");

            //Object veri tipidir. Tum .net veri tiplerinin atasidir

            object temelTip;

            temelTip = sayi2;
            temelTip = sayi3;
            temelTip = new 
            {

                marka = "Opel",
                model = "Corsa",
                modelYili = 2001,
            };

            temelTip = sayi2;
            sayi2 = (int)temelTip;

            //Goruldugu uzere object icine istedigimiz turde degiskeni atayabiliriz ve herhangi bir veri kaybi olmaz

        }
    }
}
