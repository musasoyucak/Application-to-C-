using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
    internal class kitap
    {
        public string Adı{ get; set; }
        public  string Yazarı{ get; set; }
        public string Turu { get; set; }
        public int Sayfa { get; set; }

        public int Ciltno { get; set; }

        public kitap()
        {
            Console.WriteLine("{0} ait ogrenci {1} kitabını aldı ");
        }
    }
}
