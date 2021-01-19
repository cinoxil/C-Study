using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D2.IfElseOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdiGirilen,kullaniciAdi = "Demo";
            int pwGirilen,pw = 1234;


            Console.Write("Lutfen Kullanici Adinizi Giriniz : ");
            kullaniciAdiGirilen = Console.ReadLine();

            Console.Write("Lutfen Parolanizi Giriniz : ");
            pwGirilen = Convert.ToInt32(Console.ReadLine());

            if (kullaniciAdiGirilen == kullaniciAdi && pwGirilen == pw) Console.WriteLine("Kullanici Adi ve Parola dogru. Giris Basarili");
            else Console.WriteLine("Kullanici Adi yada Parola Yanlis. Lutfen Tekrar Deneyiniz");

            Console.ReadLine();

        }
    }
}
