
using System;

namespace hafta6
{
    internal class Program
    {
        /*
         *  ogrenci o1= new ogrenci();
            ogrenci o2= new ogrenci();
           
            o1.Ad = "mavi";
            o1.Soyad = "gm";
            o2.Ad = "asd";
            o2.Soyad = "awer";
            o1 = o2;
            Console.WriteLine(o1.Ad);
        ----------------------------------
           static void Main(string[] args)
        {

            ogrenci o1 = new ogrenci("5","adana");
            ogrenci o2 = new ogrenci("6","bursa");

            Console.WriteLine(o1.Sinif+" "+o1.Okul);
            Console.WriteLine(o2.Sinif + " " + o2.Okul);
            ogrenci o3 = new ogrenci { Ad = "mavi", Soyad = "lacivert", Sinif = "3", Okul = "fransa"};
          
        }
        ---------
          static void Main()
        {
            //Öğrenci Classları Burada Tanımlandı 
            Ogrenci ogrenci1 = new Ogrenci("Muzaffer","Atasoy","11B","Bakırköy AL","E");
            Ogrenci ogrenci2 = new Ogrenci("Berat", "Atasoy", "9A", "Yeşilköy AL", "E");
            Ogrenci ogrenci3 = new Ogrenci("Derya", "Yıldırım", "8B", "Denizli AL","K");
            Ogrenci ogrenci4 = new Ogrenci("Oğuzhan", "Yola", "12d", "Yakacık M", "E");
            Ogrenci ogrenci5 = new Ogrenci("Joseph", "Lincoln", "10A", "Galatasary AL", "");
            Ogrenci ogrenci6 = new Ogrenci {Ad = "Deniz", Okul = "İstanbul", Sınıf = "12F", Soyad = "Ferhat" ,Cinsiyet = "K"};
           
            //Listeleme Bölümü
            ogrenci1.Listele();
            ogrenci2.Listele();
            ogrenci3.Listele();
            ogrenci4.Listele();
            ogrenci5.Listele();
            ogrenci6.Listele();

        }
        ------
            internal class Ogrenci
    {
        public Ogrenci()
        {
                
        }
        public Ogrenci(string ad,string soyad,string sınıf,string okul,string cinsiyet)
        {
             Ad = ad;
           Soyad = soyad;
           Sınıf = sınıf;
            Okul = okul;
            Cinsiyet = cinsiyet;
        }
        private string _cinsiyet;

        public string Cinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }


        private string _ad;

        public string Ad
        {
            get
            {
                ;
                if (Cinsiyet.ToLower() == "e")
                {
                    return "Bay " +_ad;
                }
                else if (Cinsiyet.ToLower() == "k")
                {
                    return "Bayan " + _ad;
                }
                else
                {
                    return "Belirtilmemiş " + _ad;
                }
                
            }
            set { _ad = "Öğr."+value; }
        }

        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        private string _sınıf;

        public string Sınıf
        {
            get { return _sınıf; }
            set { _sınıf = value; }
        }
        private string _okul;

        public string Okul
        {
            get { return _okul; }
            set { _okul = value; }
        }


         public void Listele()
        {
            Console.WriteLine($"ADI ={Ad} {Soyad}\nOKULU ={Okul}\nSINIFI ={Sınıf}\n*********************");
        }
        ----
         static void Main(string[] args)
        {

            ogrenci o1 = new ogrenci();
            Console.WriteLine("Cinsiyet giriniz");
            o1.Cinsiyet=Convert.ToChar(Console.ReadLine().ToLower());

            Console.WriteLine("Ad giriniz");
            o1.Ad = Console.ReadLine();
            Console.WriteLine(o1.Ad);




            
            
        }
        
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
      
       
    }------------------------------------------------------------
        Kredi kartına yıldız koyma 
         static void Main(string[] args)
        {

            ogrenci o1 = new ogrenci();
            
            Console.WriteLine("kredi kartı giriniz");
            o1.KrediKart = "1234567891232224";
            Console.WriteLine(o1.KrediKart);

        }
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
        -----------------------------------------------------------------------
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
        ---------------------------------------------------------------------
        Kredi kartına yıldız koyma 
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
         */
        static void Main(string[] args)
        {

            ogrenci o1 = new ogrenci();
            
            Console.WriteLine("kredi kartı giriniz");
            o1.KrediKart = "1234567891232224";
            Console.WriteLine(o1.KrediKart);

        }

    }
}
