using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS_Akbank_First_Case.Entities
{
     class ITasitEntity
    {
        public int Id { get; set; }
        public string HGSNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public  TasitSinifi TasitSinifi { get; set; }
        public DateTime GecisYapilanGun { get; set; }
        public DateTime GecisYapilanSaat { get; set; }
        public double Bakiye { get; set; }
        public  double Ucret { get; set; } 
    }
}
