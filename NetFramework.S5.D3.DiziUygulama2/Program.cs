using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D3.DiziUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] randDizi = new int[20];

            Random rand = new Random();

            #region for ile diziye ekleme
            for (int i = 0; i < 20; i++)
            {
                randDizi[i] = rand.Next(1, 10); //Burasi 1 ve 10 arasi random deger uretio randDiziye ekleyecek
            }
            #endregion

            #region foreach ile dizi okuyup listeleme
            int dortSayac = 0, elemanSayisi = 1;
            foreach(int item in randDizi) //Burada item yerine istedigimizi yazariz
            {
                Console.WriteLine("{0}. Eleman : {1}", elemanSayisi, item);
                elemanSayisi++;
                if (item == 4) dortSayac++;

            }
            #endregion

            Console.WriteLine("Dizide toplam {0} adet 4 bulunmaktadir", dortSayac);
            Console.ReadLine();
        }
    }
}
