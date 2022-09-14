using HGS_Akbank_First_Case.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS_Akbank_First_Case
{
    class Yonetim
    {
        double GiseGunlukBakiye = 0;

        public void GunlukBakiye()
        {
            foreach (var item in Gise.GunlukGecenAraclar())
            {
                GiseGunlukBakiye += Gise.tasitUcretleri[item.TasitSinifi];
            }
            Console.WriteLine("Gunlük Bakiye {0}",GiseGunlukBakiye);
        }
    }
}
