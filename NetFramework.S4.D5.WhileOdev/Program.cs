using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D5.WhileOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            int rastgeleSayi = 0, sayac = 0, sayi1 = 0;

            Random rnd = new Random();

            rastgeleSayi = rnd.Next(1, 10);

            //Console.Write("Lutfen 1 ile 10 arasi sayiyi tahmin edin : ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 < 0 || sayi1 > 10)
            //{
            //    Console.WriteLine("Lutfen 1 ile 10 arasi bir sayi girin");
            //    sayi1 = Convert.ToInt32(Console.ReadLine());
            //}

            while (sayi1 != rastgeleSayi)
            {
                Console.Write("Lutfen 1 ile 10 arasindaki sayiyi tahmin edin : ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                if (sayi1 < 0 || sayi1 > 10)
                {
                    Console.Write("Deger Disi. Lutfen 1 ile 10 arasi bir sayi girin : ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                }
                sayac++;
            }

            Console.WriteLine("Tebrikler dogru cevap {0}. {1} denemede buldunuz",rastgeleSayi,sayac);
            Console.ReadLine();
        }
    }
}
