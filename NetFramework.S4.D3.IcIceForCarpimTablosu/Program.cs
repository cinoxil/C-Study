using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D3.IcIceForCarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 1; i <= 10; i++)
            {
                for(int y = 1; y <= 10; y++)
                {
                    int carpim = i * y;
                    Console.Write("{0}*{1}={2}\t",i,y,carpim);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
