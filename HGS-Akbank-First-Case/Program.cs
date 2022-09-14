using HGS_Akbank_First_Case.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS_Akbank_First_Case
{
    class Program
    {
        static void Main(string[] args)
        {

            ITasitEntity m1 = new ITasitEntity();
            m1.Bakiye = 105;
            m1.HGSNo = "om984";
            m1.Id = 1;
            m1.KullaniciAdi = "melisa";
            m1.TasitSinifi = TasitSinifi.Otomobil;
            m1.KullaniciSoyadi = "dağ";

            ITasitEntity m2 = new ITasitEntity();
            m2.Bakiye = 102;
            m2.HGSNo = "m624";
            m2.Id = 2;
            m2.KullaniciAdi = "mehmet";
            m2.TasitSinifi = TasitSinifi.Minibus;
            m2.KullaniciSoyadi = "gevrek";


            ITasitEntity m3 = new ITasitEntity();
            m3.Bakiye = 56;
            m3.HGSNo = "ob345";
            m3.Id = 3;
            m3.KullaniciAdi = "ahmet";
            m3.TasitSinifi = TasitSinifi.Otobus;
            m3.KullaniciSoyadi = "zal";
            Gise gise = new Gise();

            gise.Odeme(m3);
            gise.Odeme(m2);
            gise.Odeme(m1);
            Gise.GunlukGecenAraclar();
            Yonetim yonetim = new Yonetim();
            yonetim.GunlukBakiye();

            Console.ReadLine();
        }
    }
}
