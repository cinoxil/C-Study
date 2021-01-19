using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S9.D2.KapsullemeOdev1
{
    class Musteri
    {
        //get ve set'in ne oldugunu kisaca ozetlersek get'in icine ilgili properties cagirilinca gosterilecek degeri yaziyoruz. set'in icine ise hangi degiskene deger atacayacaksak 
        //onun kurallarini vs yazip deger atamasi yapiyoruz



        //string tcIlkUcHane;
        private string _tcKimlikNumarasi;
        #region tckimlik properties
        public string tcKimlikNumarasi
        {

            get
            {

                //for (int i = 0; i < 3; i++)
                //{
                //    tcIlkUcHane += _tcKimlikNumarasi[i];
                //}
                //return tcIlkUcHane;
                //ilk uc haneyi ya boyle yada asagidaki yolla gosterebiliriz

                return _tcKimlikNumarasi.Substring(0, 3); //bu 0inci indexden baslayip 3 karakter gosterecek demek
            }
            set
            {
                bool bayrak = false;

                if (value.Length == 11)
                {
                    

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        
                        if (karakterKontrol != true)
                        {
                            Console.WriteLine("TC Kimlik numarasinin tum haneleri sayi olmalidir.");
                            bayrak = true;
                            break;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("TC Kimlik no 11 haneli olmalidir.");
                }

                if (bayrak == false) _tcKimlikNumarasi = value;
            }
        }
#endregion
        public Musteri()
        {
            _tcKimlikNumarasi = "11111111111";
        }

        public string emailadres;
        public string isim;
        private string _soyad;
        #region soyad properties
        public string Soyad
        {
            get
            {
                return this._soyad
            }
            set
            {
                this._soyad = value;
                this.emailadres = string.Format("{0}{1}@hotmail.com", isim, _soyad);

            }
        }
        #endregion
    }
}
