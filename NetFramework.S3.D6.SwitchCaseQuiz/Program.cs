using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D6.SwitchCaseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            int secim;
            //Goto kullanim iicn bir etiket yerlestirelim

            YenidenSecim:

            Console.Write("Lutfen bir ay numarasi girin : ");
            secim = Convert.ToInt32(Console.ReadLine());

            switch(secim)
            {
                case 1 : Console.WriteLine("Numarasini girdinigiz ay ocak"); break;
                case 2 : Console.WriteLine("Numarasini girdinigiz ay subat"); break;
                case 3 : Console.WriteLine("Numarasini girdinigiz ay mart"); break;
                case 4 : Console.WriteLine("Numarasini girdinigiz ay nisan"); break;
                case 5 : Console.WriteLine("Numarasini girdinigiz ay mayis"); break;
                case 6 : Console.WriteLine("Numarasini girdinigiz ay haziran"); break;
                case 7 : Console.WriteLine("Numarasini girdinigiz ay temmuz"); break;
                case 8 : Console.WriteLine("Numarasini girdinigiz ay agustos"); break;
                case 9 : Console.WriteLine("Numarasini girdinigiz ay eylul"); break;
                case 10 : Console.WriteLine("Numarasini girdinigiz ay ekim"); break;
                case 11 : Console.WriteLine("Numarasini girdinigiz ay kasim"); break;
                case 12 : Console.WriteLine("Numarasini girdinigiz ay aralik"); break;
                default: Console.WriteLine("Toplam 12 ay var. Lutfen 1 ve 12 arasinda bir sayi girin" 
                    + Environment.NewLine + "Devam etmek icin enter'a basin");
                    Console.ReadLine();

                    goto YenidenSecim;
                    

             }

            Console.ReadLine();

        }
    }
}
