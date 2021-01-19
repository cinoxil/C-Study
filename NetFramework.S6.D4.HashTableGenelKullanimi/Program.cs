using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D4.HashTableGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable h1 = new Hashtable();

            #region HashTable deger ekleme

            h1.Add("Car", "Araba"); //soldaki Car key'dir yani dizinin belirteci gibi. Sagdaki araba ise ilgili satirdaki girdi
            h1.Add("House", "Ev");

            h1.Add("Cars", "Araba");
            //h1.Add("Cars", "Arabalar"); key degero uniq olmalidir yoksa hata verir

            #endregion

            #region yardimci methodlar

            bool kontrol1 = h1.Contains("Car"); //contain ole sadece key'ler kontrol edilebilir
            bool kontrol2 = h1.Contains("Door");
            bool kontrol3 = h1.ContainsKey("Cars"); // contains iel containskey ayni ise yarar

            bool kontrol4 = h1.ContainsValue("Araba"); //containsvalue ise key'i degil value yano sag kismi kontrol eder


            //geri kalan cler() , remove() vs gibi methodlar ArrayList ile ayni
            #endregion

        }
    }
}
