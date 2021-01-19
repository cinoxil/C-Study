using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D6.ConvertveParseFarki
{
    class Program
    {
        static void Main(string[] args)
        {

            string text1 = "250";
            string text2 = null;

            int sayi1 = -1;
            int sayi2 = -1;

            sayi1 = int.Parse(text1);
            //sayi2 = int.Parse(text2);

            text1 = "250";
            text2 = null;

            sayi1 = -1;
            sayi2 = -1;

            sayi1 = Convert.ToInt32(text1);
            sayi2 = Convert.ToInt32(text2);

        }
    }
}
