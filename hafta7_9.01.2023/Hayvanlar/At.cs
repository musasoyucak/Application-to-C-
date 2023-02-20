using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanlar
{
    internal class At:IOtcul
    {
        public string Toynak { get; set; }
        public string Kuyruk { get; set; }
        public string Kişneme { get; set; }
        public string Ot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
