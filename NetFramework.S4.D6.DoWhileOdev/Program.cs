using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D6.DoWhileOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Degisken tanimlama ve Deger atama

            int tahminSayi, kullaniciMaxValue, randomSayi,sayac=0 ;

            Console.Write("1 ile X arasi bir sayi tahmin edilecek lutfen X degerini girin : ");
            kullaniciMaxValue = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            randomSayi = rand.Next(1, kullaniciMaxValue);

            #endregion


            do
            {

                Console.Write("Lutfen 1 ile {0} arasindaki tahmininizi girin : ", kullaniciMaxValue);
                tahminSayi = Convert.ToInt32(Console.ReadLine());
                if (tahminSayi < 1 || tahminSayi > kullaniciMaxValue)
                {
                    Console.WriteLine("Tahmin aralik disi.Lutfen 1 ve {0} arasinda deger giriniz : ",kullaniciMaxValue);
                    tahminSayi = Convert.ToInt32(Console.ReadLine());
                }
                
                if (tahminSayi == randomSayi)
                {
                    Console.WriteLine("Tebrikler {0} dogru cevap.{1}. denemede buldunuz",tahminSayi,sayac);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} yanlis cevap lutfen tekrar deneyin ", tahminSayi);
                    sayac++;
                }
            } while (true);

            Console.ReadLine();

        }
    }
}
