using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D1.DiziNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] ogrenciIsimListesi = new string[5];

            //Nasil deger ekleyebiliriz

            ogrenciIsimListesi[0] = "Cengiz Atilla";
            ogrenciIsimListesi[1] = "Ahmet Yavuz";
            ogrenciIsimListesi[2] = "Muhammed Sait Ongun";
            ogrenciIsimListesi[3] = "Cuneyt Ugur Ongun";
            ogrenciIsimListesi[4] = "Arzu Ongun";

            #region foreach ile listeleme
            foreach (string kayit in ogrenciIsimListesi)
            {
                Console.WriteLine(kayit);
            }
            Console.WriteLine("Devam etmek icin bir tusa basin...");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region for ile dizi icinde donme

            for(int i = 0; i<ogrenciIsimListesi.Length; i++)
            {
                Console.WriteLine(ogrenciIsimListesi[i]);
            }
            Console.ReadLine();

            #endregion
        }
    }
}
