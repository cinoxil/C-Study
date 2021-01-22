using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personel P1 = new Personel();
            P1.Isim = "Cuneyt Ugur";
            P1.Soyisim = "Ongun";
            P1.EmailAdres = "ugur.ongun";
            P1.Cinsiyet = 717770001; // Bay . 717770000 Bayan
            Helper.emailGonder("ik@firmam.com", "Ise alim", P1.Isim + P1.Soyisim);

            Helper.emailGonder("ik@firmam.com", "Ise alim", P1.Isim + P1.Soyisim);

            Personel P2 = new Personel();
            Console.ReadLine();
        }
    }
}
