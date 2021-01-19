using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S7.D3.MethodOdev1
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();

            

            Console.Write("Lutfen ogrencinin adini soyadini giriniz : ");
            string ad = Console.ReadLine();

            ogr.NotAl();

            ogr.SonucuEkranaYazdir(ad, ogr.sinav1, ogr.sinav2, ogr.sinav3, ogr.ortalama);

        }

       

        }
    }


