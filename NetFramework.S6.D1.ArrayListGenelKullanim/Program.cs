using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D1.ArrayListGenelKullanim
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList a1 = new ArrayList();

            #region tek deger ekleme

            a1.Add("Cuneyt Ugur Ongun");
            //a1.Add(100);

            #endregion

            #region a1e birden fazla deger ekleme
            ArrayList a2 = new ArrayList();

            a2.Add("Arzu Ongun");
            a2.Add("Muhammed Sait Ongun");

            a1.AddRange(a2); //a1 icine a2yi coklu ekleme yapiyoruz
            #endregion

            #region koleksiyon icindeki degere ulasma

            string ad = a1[0].ToString();
            //int sayi = Convert.ToInt32(a1[1]);

            #endregion

            #region ArrayList siralama

            a1.Reverse(); //reverse diziyi oldugu gibi ters haliyle siralar
            
            a1.Sort(); // sort ise diziyi a'dan z'ye siralar
            #endregion

            #region ArrayList icindeki bir degeri silme

            a1.RemoveAt(1); //RemoveAt girilen indexdeki degeri siler
            a1.Remove("Cuneyt Ugur Ongun"); //direk silmek istedigimiz degeri yazariz, kendisi lsiteden bulup siler
            a1.RemoveRange(2,2);

            #endregion

            #region koleksiyonlar yardimci komutlari

            int indexDegeri = a1.IndexOf("Arzu Ongun"); //Dizi icindeki Arzu Ongun'un index degerini getirir

            bool kontrol1 = a1.Contains("Muhammed Sait Ongun");  //Dizi icinde Muhammed Sait Ongun var mi diye kontrol eder. True yada false donus yapar. If icin kullanilabilir
            bool kontrol2 = a1.Contains(900);

            a1.Clear(); // Listeyi komple temizler
            a1.TrimToSize(); // Liste temzilendikten sonra capacity ayni kalir buda onu normal haline cevirir

            #endregion

        }
    }
}
