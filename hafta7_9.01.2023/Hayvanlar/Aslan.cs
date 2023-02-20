using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanlar
{
    internal class Aslan:IEtcil
    {
        public string Pence { get; set; }
        public string SivriDis { get; set; }
        public string KısaTuy { get; set; }
        public string EtYedi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
