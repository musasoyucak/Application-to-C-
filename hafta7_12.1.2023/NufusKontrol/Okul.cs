using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NufusKontrol
{
    /*
      * Okul sınıfı kimlik sınıfından miras alacak kullanım metodu olacak Okul Kimliği Kullanıldı yazacak*/
    internal class Okul:IKimlikBilgileri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }

        public void Kullanim()
        {
            Console.WriteLine(" Okul cüzdanı Kullanıldı");
        }
    }
}
