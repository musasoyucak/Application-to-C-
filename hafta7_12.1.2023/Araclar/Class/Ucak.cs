using Araclar.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Class
{
    internal class Ucak : BaseClass, IAgirlik
    {
        public string Ucabilir { get; set; }
        public string Agirlik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
    }
}
