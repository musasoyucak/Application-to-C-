using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
    internal class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Calıstigibolum { get; set; }
        public string Bolum { get; set; }
        public string Kurum { get; set; }
        public int maas { get; set; }
        public int mesaisaat { get; set; }
        public string Isegiris { get; set; }

        public void mesai() 
            
        {
            Console.WriteLine("Kac saaat mesai kalınmıstır ?"); 
            
            int mesaisaat = int.Parse(Console.ReadLine());
            int mesai = (maas*176)*mesaisaat;
            Console.WriteLine("Mesai ucretiniz ="+mesai);
            
        }
        public Personel()
        {
            Kurum = "Gizemm";
        }

        public Personel(string ad)
        {
            Ad = ad;
        }
        public Personel(DateTime Now)
        {
            Isegiris = Now.ToString();
        }
    }
}
