using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D1.IfElseKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Genel Kullanim

            
            if (true)
            {
                //bu islemleri yap
            }
            else
            {
                //bu islemleri yap
            }

            #endregion

            #region If Else Merhaba

            int sayi1 = 10;
            int sayi2 = 15;

            //1.Yontem

            bool kontrol = sayi1 < sayi2; //burada sayi1 sayi2den kucuk oldugu icin 1 yani true donecek

            if (kontrol) // Yukaridaki degerlere gore true gelecegi icin if blogunun icindeki kodu calistirir else'i atlar
            {
                Console.WriteLine("Sayi1 - Sayi2'den kucuktur");
            }
            else
            {
                Console.WriteLine("Sayi1 - Sayi2'den buyuktur");
            }

            Console.ReadLine();
            Console.Clear();


            int sayi3 = 30;
            int sayi4 = 40;

            //2.Yontem
            if (sayi3 > sayi4)
            {
                Console.WriteLine("sayi3 sayi4'den buyuktur");
            }
            else
            {
                Console.WriteLine("sayi4 sayi3'den buyuktur");
            }

            Console.ReadLine();
            Console.Clear();

            int sayi5 = 25;
            int sayi6 = 45;

            //3.Yontem

            if (sayi5 < sayi6) Console.WriteLine("sayi5 sayi6'dan kucuktur");
            else Console.WriteLine("sayi5 sayi6'dan buyuktur");

            Console.ReadLine();
            Console.Clear();

            if (true) Console.WriteLine("Deneme"); //Ornegin else olmazsa if ici true gelirse if'in icindeki kod calisir. False olursa derleyici if'i atlayio devam eder
            Console.ReadLine();


            #endregion

        }
    }
}
