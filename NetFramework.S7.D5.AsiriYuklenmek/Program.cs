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
            //Console.WriteLine(); yazip parantez icine impleci getirersen 1 of 19 yazar tool tipde bu Console.WriteLine'in 19 farkli kullanip tipi oldugunu gosteriyor yani
            //mesela string ifade alabilir bool ifade alabilir gibi gibi
            //bizde burada kendi yarattigimiz methodu asiri yukleyebiliriz 

            Console.WriteLine("Merhaba Dunya");
            Console.WriteLine(true);

            topla(5,9);
            topla(4.2,5.6);
            topla("ugur","ongun");

            Console.ReadLine();


        }

        
        static void topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void topla(double sayi1,double sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void topla(string kelime1, string kelime2)
        {
            Console.WriteLine(kelime1 + " " + kelime2);
        }
    }
}
