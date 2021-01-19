using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D4.RefOutKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref c'deki pointer gibi birsey sanirim. sayi1 0 iken gelenDegerin degerini aldi asagida
            int sayi1 = 0;

            Console.WriteLine(sayi1);

            degerAta(ref sayi1);

            Console.WriteLine(sayi1);

            int i = 0;
            int[] sayilarGiris = new int[20];
            bool durum = true;
            do
            {

                Console.Write("Lutfen {0}. sayiyi giriniz :",i+1);
                sayilarGiris[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                i++;

                Console.Write("Sayi girisine devam icin E, bitirmek icin H : ");
                string kontrol = Console.ReadLine().ToUpper();

                if (kontrol == "H") durum = false;
                
            } while (durum);
            int[] sayilarDuzeltme = new int[i];

            for (int j = 0; j < i; j++)
            {
                sayilarDuzeltme[j] = sayilarGiris[j];
            }

            topla(sayilarDuzeltme);
            carp(sayilarDuzeltme);

            Console.ReadLine();

        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }

        static void topla(params int[] sayilar)
        {

            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            Console.WriteLine("Toplam = {0}",toplam);

        }

        static void carp(params int[] sayilar)
        {

            int carpim = 1;

            for (int i = 0; i < sayilar.Length; i++)
            {
                carpim *= sayilar[i];
            }

            Console.WriteLine("Carpim = {0}", carpim);

        }

        

        

    }
}
