using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D3.ArrayListOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList degerListesi = new ArrayList();

            baslangic:

            Console.WriteLine("Menu");
            Console.WriteLine("1 - Deger Ekle");
            Console.WriteLine("2 - Deger Listele");
            Console.WriteLine("3 - Deger Ara");
            Console.WriteLine("4 - Deger Duzenle");
            Console.WriteLine("5 - Deger Sil");
            Console.WriteLine("6 - Cikis");
            Console.Write("Seciminiz : ");

            string kullaniciSecim = Console.ReadLine().ToString();

            

            switch (kullaniciSecim)
            {
                case "1":

                    Console.Write("Degeri Giriniz : ");
                    degerListesi.Add(Console.ReadLine());
                    Console.Clear();

                    goto baslangic;
                    
                case "2":

                    foreach (var degerler in degerListesi)
                    {
                        Console.WriteLine(degerler);
                    }
                    Console.ReadKey();
                    
                    Console.Clear();

                    goto baslangic;

                case "3":

                    Console.Write("Aramak istediginiz degeri yazin : ");
                    string arananaDeger = Console.ReadLine();
                    bool degerAra = degerListesi.Contains(arananaDeger);
                    if (degerAra == true)
                    {
                        Console.WriteLine("Aradiginiz {0} degeri liste icinde bulunuyor", arananaDeger);
                    }
                    else
                    {
                        Console.WriteLine("Aradiginiz {0} degeri liste icinde bulunmamaktadir", arananaDeger);
                    }
                    Console.ReadKey();

                    Console.Clear();
                    

                    goto baslangic;


                case "4":

                    Console.Write("Guncellemek istediginiz degeri yazin : ");
                    string updateEdilecekDeger = Console.ReadLine();
                    int updateDegerIndex = degerListesi.IndexOf(updateEdilecekDeger);

                    Console.WriteLine("");
                    Console.Write("Yeni degeri yazin : ");
                    degerListesi[updateDegerIndex] = Console.ReadLine();

                    Console.ReadKey();
                    Console.Clear();
                    

                    goto baslangic;


                case "5":

                    Console.Write("Silmek istediginiz degeri yazin : ");
                    string silinecekDeger = Console.ReadLine();

                    if (degerListesi.Contains(silinecekDeger))
                    {
                        degerListesi.Remove(silinecekDeger);
                        Console.Write("{0} degeri basari ile silindi", silinecekDeger);

                        Console.ReadKey();

                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("listede {0} adinda bir kayit yok", silinecekDeger);
                        Console.ReadKey();

                        Console.Clear();
                    }
                    

                    goto baslangic;

                case "6":

                    break;
                    
            }

        }
    }
}
