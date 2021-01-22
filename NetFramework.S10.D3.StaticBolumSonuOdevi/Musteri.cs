using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S10.D3.StaticBolumSonuOdevi
{
    class Musteri
    {
        #region Sanal DataBase
        static ArrayList DataBase;
        #endregion

        #region Static Yapici Method
        static Musteri()
        {
            DataBase = new ArrayList();
        }

        #endregion

        #region Fieldlar
        public int musteriId { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        public string Sifre { get; set; }
        #endregion


        #region Kapsulleme
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get
            {
                return this._kullaniciAdi;
            }
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Boyle bir kullanici zaten var");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }

            }
        }

        #endregion



        static public void MusteriEkle(Musteri M)
        {

            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.EmailAdres)) //NullorEmpty kisminda basa unlem koyduk yani M.KullaniciAdi null yada empty degilse demek istiyor
            {
                bool emailKontrol = musteriEmailAdresKontrol(M.EmailAdres);
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(M.KullaniciAdi);

                if (emailKontrol)
                {
                    Console.WriteLine("Eklemek istediginiz Email sistemde mevcut");

                }
                else
                {
                    if (kullaniciAdiKontrol)
                    {
                        Console.WriteLine("Eklemek istediginiz kullanici adi sistemde mevcut");
                    }
                    else
                    {
                        DataBase.Add(M);
                    }
                }
            }
            else
            {
                Console.WriteLine("Gerekli alanlar bos birakilamaz");
            }
        }

        #region Kontroller
        static bool musteriKullaniciAdiKontrol(string kullaniciAdi)
        {
            bool kontrol = false;
            for (int i = 0; i < DataBase.Count; i++)
            {
                Musteri Temp = (Musteri)DataBase[i];
                if (Temp.KullaniciAdi == kullaniciAdi)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }


        static bool musteriEmailAdresKontrol(string emailAdres)
        {
            bool kontrol = false;
            for (int i = 0; i < DataBase.Count; i++)
            {
                Musteri Temp = (Musteri)DataBase[i];
                if (Temp.EmailAdres == emailAdres)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
        #endregion
    }
}
