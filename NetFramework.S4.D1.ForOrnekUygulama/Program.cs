using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D1.ForOrnekUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lutfen faktoriyel hesaplamak istediginzi sayiyi giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

            for(int i = sayi;i>=1; i--)
            {
                faktoriyel *= i;
            }

            Console.WriteLine("{0}'in faktoriyeli = {1}", sayi, faktoriyel);

            Console.ReadLine();
        }
    }
}
