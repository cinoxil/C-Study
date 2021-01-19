using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D2.DiziUygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Lutfen dizinin kac elemanli olacagini girin : ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            int[] intDizi = new int[elemanSayisi];
            
            #region for ile elemanlara diziye ekleme

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.Write("Lutfen {0}. elemani giriniz : ",i+1);
                intDizi[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            #endregion

            #region foreach ile toplama

            int toplam = 0, ortalama = 0;
            foreach(int item in intDizi)
            {
                toplam += item;
            }

            #endregion

            ortalama = toplam / elemanSayisi;

            Console.WriteLine("Toplam = {0} Ortalama = {1}",toplam,ortalama);
            Console.ReadLine();
        }
    }
}
