using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
    internal class Ulke
    {
        
        public int Nufusu { get; set; }
        public string adı { get; set; }
        public string Dili { get; set; }
        public string Baskent { get; set; }
        public string ParaBirimi { get; set; }
        public int Kurulus { get; set; }

        public Ulke()
        {
            Nufusu = 1434000;
            adı = "Rusya";
            Dili = "Rusca";
            Baskent = "Moskova";
            ParaBirimi = "Rus Rublesi";
        }

        public int ülkeyasihesapla()
        {
            return DateTime.Now.Year - Kurulus;

        }





    }
}
