using Araclar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Class
{
    internal class Bisiklet:BaseClass,IAgirlik,IBinebilir,IYuruyebilir
    {
        public string Kactekerli { get; set; }
        public string Agirlik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Binebilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Yuruyebilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
