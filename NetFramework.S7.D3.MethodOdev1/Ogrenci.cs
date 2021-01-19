using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S7.D3.MethodOdev1
{
    class Ogrenci
    {
        public int sinav1;
        public int sinav2;
        public int sinav3;
        public decimal ortalama;

        public void NotAl()
        {
            ArrayList sinav = new ArrayList();

            for (int i = 1; i <= 3; i++)
            {

                Console.Write("Lutfen {0}. sinav notunu giriniz : ", i);
                sinav.Add(Convert.ToInt32(Console.ReadLine()));

            }

            sinav1 = (int)sinav[0];
            sinav2 = (int)sinav[1];
            sinav3 = (int)sinav[2];

            NotHesapla(sinav1, sinav2, sinav3);


        }

        public void NotHesapla(int sinav1, int sinav2, int sinav3)
        {


            ortalama = (sinav1 + sinav2 + sinav3) / 3;


        }

        public bool GectiMi(decimal ortalama)
        {
            bool durum = true;

            if (ortalama < 50) durum = false;

            return durum;

        }

        public void SonucuEkranaYazdir(string ad, int sinav1, int sinav2, int sinav3, decimal ortalama)
        {
            string durum = "";

            if (GectiMi(ortalama) == false)
            {
                durum = "Kaldi";
            }
            else
            {
                durum = "Gecti";
            }

            Console.Write(
                "Ad : {0}" + Environment.NewLine +
                "Sinav1 : {1}" + Environment.NewLine +
                "Sinav2 : {2}" + Environment.NewLine +
                "Sinav3  : {3}" + Environment.NewLine +
                "Ortalama : {4}" + Environment.NewLine +
                "Durum : {5}" + Environment.NewLine
                , ad, sinav1, sinav2, sinav3, ortalama, durum);

            Console.ReadLine();
        }
    }
}
