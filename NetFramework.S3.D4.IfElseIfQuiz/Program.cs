using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D4.IfElseIfQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1, sayi2, secim;
            double sonuc=0;

            Console.Write("Lutfen 1.Sayiyi Giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Lutfen 2.Sayiyi Giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lutfen yapmak istediginiz islemi tuslayiniz."
                + Environment.NewLine + "Toplama icin 1"
                + Environment.NewLine + "Cikarma icin 2"
                + Environment.NewLine + "Bolme icin 3"
                + Environment.NewLine + "Carpma icin 4");

            Console.WriteLine("");
            secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(secim == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            else if(secim == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (secim == 3)
            {
                sonuc = sayi1 / sayi2;
            }
            else if (secim == 4)
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                Console.WriteLine("Hatali Secim Yaptiniz");
                
            }

            if(sonuc!=0) Console.WriteLine("Islem Sonucunuz = {0}", sonuc);
            Console.ReadLine();


        }
    }
}
