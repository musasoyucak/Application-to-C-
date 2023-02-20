using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargo
{
    internal class Kontrol
    {
        // prop oluşturduk
        public IPerson Ode { get; set; }
        
        public void Ekle()
        {
            Ode.Kullanim();
        }
       
        //public void KontrolEt(IPerson _person)
        // {
        //     _person.Kullanim();
        // }
    }
}
