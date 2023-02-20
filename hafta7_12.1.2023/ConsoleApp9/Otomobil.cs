using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.Interfaces;

namespace ConsoleApp9
{
    internal class Otomobil:Arac,KaraYoluArac
    {
        public void GazaBas()
        {
            Hiz += 10;
        }

        public void FrenYap()
        {
            if (Hiz==0 && Hiz<=10)
            {
                Console.WriteLine("Arac Park Halindeyken Fren Yapamazsınız");
            }
            else { Hiz -= 10; }
           
        }

        public string AracAdi { get; set; }
        public string AracRengi { get; set; }
        public int Agirlik { get; set; }
        public int Hiz { get; set; }
    }
}
