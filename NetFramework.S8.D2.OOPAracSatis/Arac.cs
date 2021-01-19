using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D2.OOPAracSatisOdev
{
    class Arac
    {

        public string marka;
        public string model;
        public int modelYil;
        public int km;
        public string yakitTipi;
        public string vitesTipi;
        public double alisFiyati;
        public double satisFiyati;
        public double maxIndirimTutari = 5000;
        public double fiyat;

        public Arac()
        {
            marka = "Belirtilmemis";
            model = "Belirtilmemis";
            modelYil = 0;
            km = 0;
            yakitTipi = "Belirtilmemis";
            vitesTipi = "Belirtilmemis";
            alisFiyati = 0;
            satisFiyati = 0;
            fiyat = 0;

        }

        public Arac(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
            modelYil = 0;
            km = 0;
            yakitTipi = "Belirtilmemis";
            vitesTipi = "Belirtilmemis";
            alisFiyati = 0;
            satisFiyati = 0;
            fiyat = 0;
        }

        public Arac(string _marka, string _model, int _modelYil)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
            km = 0;
            yakitTipi = "Belirtilmemis";
            vitesTipi = "Belirtilmemis";
            alisFiyati = 0;
            satisFiyati = 0;
            fiyat = 0;
        }

        public Arac(string _marka, string _model, int _modelYil, int _km)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
            km = _km;
            yakitTipi = "Belirtilmemis";
            vitesTipi = "Belirtilmemis";
            alisFiyati = 0;
            satisFiyati = 0;
            fiyat = 0;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine
            (

                "Marka : {0}" + Environment.NewLine +
                "Model : {1}" + Environment.NewLine +
                "Model Yil : {2}" + Environment.NewLine +
                "Km : {3}" + Environment.NewLine +
                "Yakit Tipi : {4}" + Environment.NewLine +
                "Vites Tipi : {5}" + Environment.NewLine +
                "Fiyat : {6}" + Environment.NewLine
                , marka, model, modelYil, km, yakitTipi, vitesTipi, satisFiyati
            );
        }

        public void FiyatAta(double _yeniFiyat)
        {
            YeniFiyat(_yeniFiyat);
        }

        private double YeniFiyat(double _fiyat)
        {
            return satisFiyati = _fiyat;
        }

        public double indirimYap(double _fiyat)
        {
            return satisFiyati = satisFiyati - maxIndirimTutari;
        }

        //public void bilgiGir(
        //string _marka, 
        //string _model, 
        //int _modelYil, 
        //int _km, 
        //string _yakitTipi,
        //string _vitesTipi,
        //double _alisFiyati,
        //double _satisFiyati,
        //double _fiyat)
        //{

        //    marka = _marka;
        //    model = _model;
        //    modelYil = _modelYil;
        //    km = _km;
        //    yakitTipi = _yakitTipi;
        //    vitesTipi = _vitesTipi;
        //    alisFiyati = _alisFiyati;
        //    satisFiyati = _satisFiyati;
        //    fiyat = _fiyat;

        //}

        public void bilgiGir()
        {
            Console.WriteLine("Lutfen eklemek istediginiz arac bilgilerini girin");
            Console.Write("Marka : ");
            marka = Console.ReadLine();

            Console.Write("Model : ");
            model = Console.ReadLine();

            Console.Write("ModelYil : ");
            modelYil = int.Parse(Console.ReadLine());

            Console.Write("Km : ");
            km = int.Parse(Console.ReadLine());

            Console.Write("Yakit Tipi : ");
            yakitTipi = Console.ReadLine();

            Console.Write("Vites Tipi : ");
            vitesTipi = Console.ReadLine();

            Console.Write("Alis Fiyati : ");
            alisFiyati = double.Parse(Console.ReadLine());

            Console.Write("Satis Fiyati : ");
            satisFiyati = double.Parse(Console.ReadLine());

            //Console.Write("Fiyat : ");
            //fiyat = double.Parse(Console.ReadLine());

            Console.WriteLine("Kayit alinmistir");
        }

    }
}
