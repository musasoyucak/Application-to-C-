using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class AracListele
    {
        public void OtomobilListele(Otomobil oto)
        {
            Console.WriteLine($"Otomobil Adi = {oto.AracAdi}\n" +
                              $"Otomobil Hızı {oto.Hiz}\n" +
                              $"Otomobil Rengi {oto.AracRengi}\n" +
                              $" Otomobil Rengi {oto.Agirlik}\n" +
                              $"************************************");
        }
        public void GemiListele(Gemi gemi)
        {
            Console.WriteLine($"Gemi Adi = {gemi.AracAdi}\n" +
                              $"Gemi Hızı {gemi.Hiz}\n" +
                              $"Gemi Rengi {gemi.AracRengi}\n" +
                              $" Gemi Rengi {gemi.Agirlik}\n" +
                              $"************************************");
        }
        public void UcakListele(Ucak ucak)
        {
            Console.WriteLine($"Uçak Adi = {ucak.AracAdi}\n" +
                              $"Uçak Hızı {ucak.Hiz}\n" +
                              $"Uçak Rengi {ucak.AracRengi}\n" +
                              $" Uçak Rengi {ucak.Agirlik}\n" +
                              $"Uçak Durumu {ucak.CalismaDurumu}\n" +
                              $"************************************");
        }
    }
}
