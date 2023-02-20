using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta7
{
    internal class Ogretmen:Mudur,IMaas,IYemek,IDenetleme
    {
        public string NotVerme { get; set; }
        public int OgretmenNo { get; set; }
        public string OdevVerme { get; set; }
        public string Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Yemek { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
