using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public class Personel
    {
        
        public static string domainAdres;

        public string Isim { get; set; }
        public string Soyisim { get; set; }

        private string _emailAdres;
        public string EmailAdres
        {
            get
            {
                return this._emailAdres;
            }

            set
            {
                this._emailAdres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }

        public int Cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her orneklemede calisan method");
        }

        static Personel()
        {
            domainAdres = "firmam.com";
        }
    }
}
