using OkulKayitSistemi.Kisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKayitSistemi.Odeme
{
    internal class Kontrol
    {
        public IKisi Odeme { get; set; }
     

        public void Ekle()
        {
            Odeme.Kullanim();
        }
    }
}
