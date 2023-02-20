using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanlar
{
    internal class Ayı:IOtcul
    {
        public string Pence { get; set; }
        public string SivriDis { get; set; }
        public string UzunBoy { get; set; }
        public string Ot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
