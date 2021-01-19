using NetFramework.S8.D2.OOPAracSatisOdev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D2.OOPAracSatisOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            Arac A1 = new Arac("Opel", "Zafira", 2001);

            int secim;
            
            baslangic:

            Console.WriteLine("Lutfen yapmak istediginiz islemi secin");

            Console.WriteLine
            (

                "Yeni Giris : 1" + Environment.NewLine +
                "Indirim icin : 2" + Environment.NewLine +
                "Fiyat atamak icin : 3" + Environment.NewLine +
                "Listeleme icin : 4" + Environment.NewLine +
                "Cikis icin : 5" + Environment.NewLine
           );
            secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    A1.bilgiGir();
                    Console.WriteLine("Devam etmek icin bir tusa basin");
                    Console.ReadLine();
                    Console.Clear();
                    goto baslangic;

                case 2:

                    A1.indirimYap(A1.satisFiyati);
                    Console.WriteLine("Yeni fiyat : {0}",A1.satisFiyati);
                    Console.WriteLine("Devam etmek icin bir tusa basin");
                    Console.ReadLine();
                    Console.Clear();
                    goto baslangic;

                case 3:

                    Console.Write("Lutfen yeni fiyati girin : ");
                    A1.satisFiyati = double.Parse(Console.ReadLine());
                    Console.Clear();
                    goto baslangic;
                    

                case 4:
                    A1.BilgileriGoruntule();
                    Console.WriteLine("Devam etmek icin bir tusa basin");
                    Console.ReadLine();
                    Console.Clear();
                    goto baslangic;

                case 5:
                    
                    break;

            }

            
            

        }
    }
}
