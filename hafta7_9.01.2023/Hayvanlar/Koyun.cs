using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanlar
{
    internal class Koyun:IOtcul
    {
        public string Meleme { get; set; }
        public string KucukBoy { get; set; }
        public string UzunTuy { get; set; }
        public string Ot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
