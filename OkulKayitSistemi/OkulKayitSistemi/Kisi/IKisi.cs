using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKayitSistemi.Kisi
{
    internal interface IKisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }

        public void Kullanim()
        {
            Console.WriteLine("Kisi Bilgileri");
        }

    }
}
