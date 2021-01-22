using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D2.PersonelUygulamasi
{
    public static class Helper
    {

        //static classlar orneklenemez
        //Helper H1 = new Helper();
        //static class icinde static olmayan method, field vs yazilamaz
        public static void emailGonder(string aliciEmailAdres , string konu, string icerik)
        {
            //Email gonderme islemleri devam edecek...
            Console.WriteLine("Mail gonderildi");
        }

        //public Helper()
        //{
        // standart yapici method her nesne ornegi alindiginda calisir
        //}

        static Helper()
        {
            Console.WriteLine("Helper static class => static CTOR ");
            //static yapici method sadece ilgili static class ilk cagirildiginda calisir
        }
    }
}
