using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D5.AsiriYuklenmek
{
    class Program
    {
        static void Main(string[] args)
        {
            int intToplam = topla(5, 9);
            double doubleToplam = topla(4.2, 5.6);
            string stringToplam = topla("ugur", "ongun");

            //asagidaki gibi 2 turlude kullanilabilir. 2.ekrana yazdir direk ic ice yazildi
            ekranaYazdir(stringToplam);
            ekranaYazdir(topla(5,9));
            
            
            
            
            Console.ReadLine();


        }

        static void ekranaYazdir(object o)
        {
            Console.WriteLine(o.ToString());
        }

        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static double topla(double sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            return toplam;
        }

        static string topla(string kelime1, string kelime2)
        {
            string cumle = kelime1 + " " + kelime2;
            return cumle;
        }
    }
}
