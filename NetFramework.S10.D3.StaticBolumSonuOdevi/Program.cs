using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.StaticBolumSonuOdevi
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri M1 = new Musteri();

            M1.musteriId = 1;
            M1.Isim = "Cuneyt Ugur";
            M1.Soyisim = "Ongun";
            M1.EmailAdres = "ugurongun@hotmail.com";
            M1.KullaniciAdi = "ugur.ongun";
            M1.Sifre = "2131";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri();

            M2.musteriId = 1;
            M2.Isim = "Arzu";
            M2.Soyisim = "Ongun";
            M2.EmailAdres = "arzuongun@hotmail.com";
            M2.KullaniciAdi = "ugur.ongun";
            M2.Sifre = "1973";

            Musteri.MusteriEkle(M2);
            Console.ReadLine();
        }
    }
}
