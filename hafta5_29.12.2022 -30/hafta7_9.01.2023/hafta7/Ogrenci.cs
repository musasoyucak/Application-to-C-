using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta7
{
    internal class Ogrenci:Kisi,IYemek,IOdev
    {
        public string DersNot { get; set; }
        public int OgrenciNo { get; set; }
        public string Ders { get; set; }
        
        public int Sinif { get; set; }
        public string Yemek { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Odev { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
