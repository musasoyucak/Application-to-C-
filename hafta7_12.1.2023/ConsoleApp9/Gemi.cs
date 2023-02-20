using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.Interfaces;

namespace ConsoleApp9
{
    internal class Gemi : Arac,DenizYoluArac
    {
    
        public void DemirAt()
        {
            Hiz = 0;
        }

        public void LimanaParkEt()
        {
            Hiz = 0;
        }

        public string AracAdi { get; set; }
        public string AracRengi { get; set; }
        public int Agirlik { get; set; }
        public int Hiz { get; set; }
    }
}
