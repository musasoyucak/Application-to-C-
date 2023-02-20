using OkulKayitSistemi.Kisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKayitSistemi
{
    internal class Ogretmen : IKisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string DersVeme { get; set; }
        public string NotVerme { get; set; }

    }
}
