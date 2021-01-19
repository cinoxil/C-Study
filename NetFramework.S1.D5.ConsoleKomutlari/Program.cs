using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D5.ConsoleKomutlari
{
    class Program
    {
        static void Main(string[] args)
        {

            string kullanicidanGelenDeger = string.Empty;

            //Kullaniciya mesaj gostermek

            Console.Write("Mesaj1");        //Mesaj gosterir imlec yaninda bekler
            Console.WriteLine("Mesaj2");    //Mesaj gosterir imlec bi alt satira gecer

            Console.ReadLine();

            //Ekranda bulunan tum datayi silmek icin

            Console.Clear();

            //Temel 1 kullnicidan deger alma

            Console.Write("Lutfen adinizi giriniz : ");
            kullanicidanGelenDeger = Console.ReadLine();

           //1. Yontem 
            string mesaj = "Girmis oldugunuz deger " + kullanicidanGelenDeger + "'dir.";

            Console.WriteLine(mesaj);

            //2.Yontem

            mesaj = "";

            mesaj = string.Format("Girmis oldugunuz deger {0} ve sayi ise {1}", kullanicidanGelenDeger,4);
            //Yukarida 0 ve 1 yazan yerler virgulden sonrasini sirayla point ediyorlar. Yani 0 olan ilk siradaki kullanicidanGelenDeger'i,1 olan ise 4 rakamini

            Console.WriteLine(mesaj);

            //3.Yontem


            Console.WriteLine("Girmis oldugunuz isim {0} ve sayi ise {1}'dur", kullanicidanGelenDeger, 10);

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Lutfen 1 ve 10 arasinda bir sayi giriniz");
            string gelenDeger = Console.ReadLine();

            int sayi1 = int.Parse(gelenDeger);
            Console.WriteLine("Lutfen tekrar 1 ve 10 arasinda bir sayi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + 15;
            int toplam2 = sayi1 + sayi2;

            Console.WriteLine("Parse sayi1 + 15 Toplam sonucu = {0}", toplam);
            Console.WriteLine("Convertli sayi1+sayi2 Toplam sonucu = {0}", toplam2);


            Console.ReadLine();
        }
    }
}
