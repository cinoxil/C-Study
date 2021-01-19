using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetFramework.S7.D2.MatematikselIslemler
{

    
    class Program
    {

        

        static void Main(string[] args)
        {
            Matematik islem = new Matematik();
            
            
            

            bool kontrol = true;
            
            while(kontrol)
            {

                Console.Write("Lutfen 1.sayiyi giriniz :");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lutfen 2.sayiyi giriniz :");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("1 - Toplama" + Environment.NewLine + "2 - Cikarma" + Environment.NewLine + "3 - Bolme" + Environment.NewLine + "4 - Carpma" + Environment.NewLine + "5 - Cikis" + Environment.NewLine);

                Console.Write("Lutfen yapmak istediginiz islemi tuslayiniz : ");
                int secim = Convert.ToInt32(Console.ReadLine());

                int kontrolSecim;
                switch (secim)
                {

                    case 1:

                        Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, islem.toplamaIslemi(sayi1, sayi2));
                        Console.Write("Tekrar hesap yapmak icin 1'e yoksa 2'basin : ");
                        
                        kontrolSecim = Convert.ToInt32(Console.ReadLine());
                        if (kontrolSecim == 2) kontrol = false;

                        break;
                    case 2:

                        Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, islem.cikarmaIslemi(sayi1, sayi2));
                        Console.Write("Tekrar hesap yapmak icin 1'e yoksa 2'basin : ");

                        kontrolSecim = Convert.ToInt32(Console.ReadLine());
                        if (kontrolSecim == 2) kontrol = false;

                        break;

                    case 3:

                        Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, islem.bolmeIslemi(sayi1, sayi2));
                        Console.Write("Tekrar hesap yapmak icin 1'e yoksa 2'basin : ");

                        kontrolSecim = Convert.ToInt32(Console.ReadLine());
                        if (kontrolSecim == 2) kontrol = false;

                        break;

                    case 4:

                        Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, islem.carpmaIslemi(sayi1, sayi2));
                        Console.Write("Tekrar hesap yapmak icin 1'e yoksa 2'basin : ");

                        kontrolSecim = Convert.ToInt32(Console.ReadLine());
                        if (kontrolSecim == 2) kontrol = false;

                        break;

                    case 5:
                        kontrol = false;
                        break;

                }

            }

        }
        
    }
}
