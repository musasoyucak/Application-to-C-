using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.Interfaces;

namespace ConsoleApp9
{
    internal class Ucak : Arac,HavaYoluArac
    {
        
        public void KalkisYap()
        {
            CalismaDurumu = "Ucak Şuan Havada";
        }

        public void InisYap()
        {
            CalismaDurumu = "Ucak Şuan Pistte";
        }

        public string CalismaDurumu { get; set; }

        public string AracAdi { get; set; }
        public string AracRengi { get; set; }
        public int Agirlik { get; set; }
        public int Hiz { get; set; }
    }
}
