using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta6
{
    internal class ogrenci
    {
        private string Ad_;

        public string Ad
        {
            get
            {
                if (Cinsiyet == 'k')
                {
                    return "Kadın " + Ad_;
                }
                else
                {
                    return "Erkek " + Ad_;
                }
            }
            set { Ad_ = value; }

        }
        
        private string takim;

        public string Takim
        {
            get
            {
                if (takim.ToLower() == "fenerbahce")
                {
                    return takim.ToUpper();
                }
                else
                {
                    return takim.ToLower();
                }
                
            }
            set { takim = value; }
        }
        private string krediKart;

        public string KrediKart
        {
            get
            {
              return  krediKart.Substring(0, 4) + ("**********") + krediKart.Substring(14, 2);
               
                
            }
            set { krediKart = value; }
        }


        public string Sinif { get; set; }
        public string Okul { get; set; }
        private int DogumYeri_;
        //propfull
        public int DogumYeri
        {
            get { return DogumYeri_; }
            set { DogumYeri_ = value; }
        }
        
        public char Cinsiyet { get; set; }

        
        public ogrenci(string _sinif,string _okul)
        {
            Sinif = _sinif;
            Okul = _okul;
        }
        public ogrenci()
        {
            
        }
      
       
    }
}
