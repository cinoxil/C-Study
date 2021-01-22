using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S11.D1.InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriId = 1;
            M1.tcKimlikNumarasi = "36581024852";
            M1.isim = "Cuneyt Ugur";
            M1.soyisim = "Ongun";
            M1.olusturmaTarihi = DateTime.Now;

            M1.musteriAdresleri[0] = new MusteriAdres() //bu hizli nesne tanimi
            {
                il = "Manisa",
                ilce = "Yunusemre",
                adres = "Adres...",
                adresTip = "Isyeri"
            };

            M1.musteriAdresleri[0].ekranaYaz(); // Bu sekilde M1 yani musteriler classindan musteriAdresleri classindan method cektim

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "458965"
            };

            M1.musteriSiparisBilgileri[0].urunBilgileri[0] = new Urun() //burasi ic ice inner type urunbulgileri siparisbilgilerine oda musteriye bagli
            {
                urunAdi = "Samsung Galaxy S20",
                urunTipi = "Telefon",
                fiyat = 5000
            };








    
        
        }
    }
}
