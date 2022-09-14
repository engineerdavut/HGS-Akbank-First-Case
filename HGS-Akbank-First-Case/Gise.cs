using HGS_Akbank_First_Case.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS_Akbank_First_Case
{
    class Gise
    {
        static List<ITasitEntity> tasitEntities;
        public static Dictionary<TasitSinifi, double> tasitUcretleri;
        public Gise()
        {

            tasitEntities = new List<ITasitEntity>();
            tasitUcretleri = new Dictionary<TasitSinifi, double>();
            tasitUcretleri.Add(TasitSinifi.Otomobil, 5.25);
            tasitUcretleri.Add(TasitSinifi.Minibus, 10.25);
            tasitUcretleri.Add(TasitSinifi.Otobus, 20.25);
        }
        public void Odeme(ITasitEntity tasitEntity)
        {
            tasitEntity.GecisYapilanGun = DateTime.Parse(DateTime.Now.ToString("d"));
            tasitEntity.GecisYapilanSaat = DateTime.Parse(DateTime.Now.ToString("T"));
            if (tasitEntity.Bakiye >= tasitUcretleri[tasitEntity.TasitSinifi])
            {
                tasitEntity.Bakiye -= tasitEntity.Ucret;
                // Gunler icin sorgu yapilabilir. Ayni gun olmasi icin
                tasitEntities.Add(tasitEntity);
            }
            else { /* "Bakiye yetersiz."; */ }
        }
        public  static List<ITasitEntity> GunlukGecenAraclar()
        {
            Console.WriteLine("Bugün gecen arac sayisi {0}", tasitEntities.Count);
            foreach (ITasitEntity item in tasitEntities)
            {
                Console.WriteLine("Aracların Hgs Nosu {0}", item.HGSNo);
            }
            return tasitEntities;
        }

        public static void GunlukGecenAraclar1()
        {
            Console.WriteLine("Bugün gecen arac sayisi {0}", tasitEntities.Count);
            foreach (ITasitEntity item in tasitEntities)
            {
                Console.WriteLine("Aracların Hgs Nosu {0}", item.HGSNo);
            }
        }
    }
}
