using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NufusKontrol
{
    interface IKimlikBilgileri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public void Kullanim()
        {
            Console.WriteLine("Kimlik Kullanıldı");
        }
    }
}
