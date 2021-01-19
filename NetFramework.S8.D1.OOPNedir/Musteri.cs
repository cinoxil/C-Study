using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPNedir
{
    class Musteri
    {

        public string TcKimlikNo;
        public string ad;
        public string soyad;
        public int cinsiyet; //717770001 : Bay - 717770002 : Bayan
        public bool durum;
        public Musteri()
        {
            TcKimlikNo = "717770001";
        }

        public Musteri(string _tcKimlikNo)
        {
            TcKimlikNo = _tcKimlikNo;
        }

        public Musteri(string _tcKimlikNo, string _isim)
        {
            TcKimlikNo = _tcKimlikNo;
            ad = _isim;
        }

        public Musteri(string _tcKimlikNo, string _isim, string _soyad)
        {
            TcKimlikNo = _tcKimlikNo;
            ad = _isim;
            soyad = _soyad;
        }

        public bool MusteriKontrol()
        {
            bool durum = MusteriKontrolDatabase(TcKimlikNo);
            return durum;
        }

        private bool MusteriKontrolDatabase(string tcKimlikNumarasi)
        {
            //Buradan sanki database'de bi islem yapmisizda true donuyomus gibi yapalim
            return true;
        }

    }
}
