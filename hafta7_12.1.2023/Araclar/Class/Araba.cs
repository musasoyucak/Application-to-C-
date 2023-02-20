using Araclar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Class
{
    internal class Araba:BaseClass,IAgirlik,IBinebilir,ICamAcma,IYuruyebilir
    {
        public string KoltukSayisi { get; set; }
        public string Agirlik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Binebilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CamAcma { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Yuruyebilir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
