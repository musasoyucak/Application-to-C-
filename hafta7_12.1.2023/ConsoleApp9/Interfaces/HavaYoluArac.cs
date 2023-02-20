using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Interfaces
{
    internal interface HavaYoluArac
    {
        public void KalkisYap();
        public void InisYap();
        public string CalismaDurumu { get; set; }
    }
}
