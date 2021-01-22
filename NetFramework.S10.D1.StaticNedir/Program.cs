using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D1.StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            // Static : nesne ornegi alinmadan ulasabildigimiz metot,field yada sinif...
            // nesne ornegi : ornek olarak tip dite class var tip t1 = new tip(); nesne ornegi almaktir


            Ogrenci.Test2(); // burada hic ornekleme yapmadan static methoduma ulasabiliyorum

            //stack bolgede pointer olusturalim
            Ogrenci O1;
            // stack bolgede pointer olustugu zaman static olan bir yapici method calisti ve yine class icinde tanimli olan static field, static method vsyi static bolgede olusturdu


            O1 = new Ogrenci();
            //stack bolgede pointer => kendisini heap bolgede tamamladi, static olmayan tanimlarini tamamladi yani normal field ve methodlari
            O1.Test1(); // nesne ornegi alindiktan sonra test1 adindaki methoduma ulasabildim

            /* Static Kavrami gercek hayatta nerelerde kullanilir
             
            1 - Helper.cs => Kontroller - yani mesela tckimlik no kontrol methodu olusturdun orneklemeden direk istedigin yerde cagirip kullanabilirsin.
            2 - Olusturmus oldugumuz nesnemizin => bagimliligi farkli classlara oldugu icin (proje icerisinde ozel oldugu icin) nesne icerisinde static method tanimlari yapilir
            3 - Class icerisinde bir field (static) tanimi yapar ilfili field icerisine bir deger atamasi yapariz. daha sonra uygulama icerisinde N farkli yerde olusturmus oldugumuz static
            fielda ulasir degerimizi okuluruz
            4 - [Uygulama] => [Ozel Helper] => [DLL - API]
             
             
             */
        }
    }
}
