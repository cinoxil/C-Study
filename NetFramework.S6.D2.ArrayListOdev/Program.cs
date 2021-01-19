using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S6.D2.ArrayListOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList odevListe = new ArrayList();

            odevListe.Add("Cuneyt");
            odevListe.Add("Arzu");
            odevListe.Add("Muhammed Sait");
            odevListe.Add("Ilker");
            odevListe.Add("Huseyin");
            odevListe.Add("Zeynep");
            odevListe.Add("Tahir");
            odevListe.Add("Hasan");
            odevListe.Add("Ayse");
            odevListe.Add("Sude");

            odevListe.Sort();
            odevListe.Reverse();


        }
    }
}
