using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta7
{
    internal class Mudur:Kisi,IDenetleme
    {
        

        public string Mesai { get; set; }
        public string Yönetim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
