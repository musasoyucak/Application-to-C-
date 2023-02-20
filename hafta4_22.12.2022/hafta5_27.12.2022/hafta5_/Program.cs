using System;

namespace hafta5_
{
    internal class Program
    {
        /*
         *         static void Main(string[] args)
        {
         
            Console.WriteLine(veriisteme());
            //int deger= veriisteme(); (Böyle de kullanılıyor.)
        }
        static int Toplam(int s1=0,int s2=0)
        {
            
            int sonuc = s1+s2;
            return sonuc;
        }
        static int veriisteme()
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi3 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayi giriniz");
            int sayi4 = int.Parse(Console.ReadLine());
            int top = Toplam(sayi3, sayi4);
            Console.WriteLine(Toplam(sayi3 + sayi4));
            return top;
        }
         * -----------------------------------------------------------------------------------
         object methodu tanımlmadan a diye cağıra bilirsin
        değişkeni convert etmeye gerek yok
        object b= 123;
        object c=15.6
        Console.WriteLine(a);
        Console.WriteLine(b);

        bilinçsiz tür kendinden büyük deger atar dogal sayi ve
        int i double cevirmek gibi
        params default deger alır 
        static intr ParametreleriTopla(int a=8,int b=7)
        {
        int sonuc 2 *a+2*b;
        return sonuc;
        }
        Kendinden öncekine parametre veriyoran,
        bi sonrakine parametre koyulmalıdır.
         bunlar main içinde
        /ParemetreleriTopla();
       /ParemetreleriTopla(7);
        /Console.Read();
        ---------------------------------------------------------------------
        kullanıcı  ekmek %1 kdv alsın diğer ürünler isterse % 18 alsın
        cevap1
         static void Main(string[] args)
        {
            Console.WriteLine("Ürünü giriniz");
            string ürün = Console.ReadLine().ToLower();
        Console.WriteLine("Ürünün fiyatını giriniz");
            double fiyat = Convert.ToInt32(Console.ReadLine());
            if (ürün.ToLower() == "ekmek")
            {
                Console.WriteLine(urunkdv(fiyat, 0.01));  //ekmeğin kdv'sini yollabilirim. 0.18 i değiştirip ekmek olunca 0.01 alır.
            }
            else
            { Console.WriteLine(urunkdv(fiyat)); }
        }

            static double urunkdv(double fiyat, double kdvv = 0.18)
                 {
                     double hesap = 0;
                 
                     hesap = hesap + (fiyat * kdvv);
                 
                 
                     return hesap;
                 }
        cevap2
         static void Main(string[] args)
        {
            Console.WriteLine("ne isteriniz ekmek ise 1 seker ise 2  ");
            int ekmek = int.Parse(Console.ReadLine());
            int seker = int.Parse(Console.ReadLine());

            Kdv(ekmek, seker);
        }
        static double Kdv(int s1, int s2)
        {

            double c = 0;
            if (s1 == 1)
            {
                c = s2 * 0.01;
                Console.WriteLine("KDV dahil " + (c));
                return c;
            }
            else
            {
                c = s2 * 1.18;
                Console.WriteLine("KDV dahil " + (c));
                return c;

            }

        }
        -----------------------------------------------------------------------
        Kitap alalım 2. itapta  % 20 indirim uygulansın ref methodu ile 
        static void Main(string[] args)
        {
            string indirimKuponu = " ";
            Console.WriteLine("Kitap adeti gir");
            int adet = int.Parse(Console.ReadLine());
            Console.WriteLine(indirim(adet,ref indirimKuponu));
        }
        static string indirim(double adet,ref string indirimKuponu)
        {
            if (adet > 2)
            {
                indirimKuponu = " 20 TL indirim kuponu tanımlandı";
            }
            return indirimKuponu;
        }
        ---------------------------------------------------------------------
          static void Main(string[] args)
        {
            Musteri m = new Musteri();
            m.ekle();
            m.guncelle();
            m.musteriAdi = "gizem";
            m.musteriYasi = 23;
            Console.WriteLine(m.musteriAdi);
            Console.WriteLine(m.musteriYasi);
        }
      
       
    }
    class Musteri
    {
        public string musteriAdi;
        public int musteriYasi;
        public void ekle()
        {
            Console.WriteLine("Musteri ekle");
        }
        public void guncelle()
        {
            Console.WriteLine("Musteri guncelle");
        }
    }
        -----------------------------------------------
        ilaç müsteri 
        ------------------------------------------------------------------
         */
        static void Main(string[] args)
        {
            Musteri m = new Musteri();
            m.ekle();
            m.guncelle();
            m.musteriAdi = "gizem";
            m.musteriYasi = 23;
            Console.WriteLine(m.musteriAdi);
            Console.WriteLine(m.musteriYasi);

            Urun urun = new Urun();
            urun.ekle();
            urun.guncelle();
            urun.urunId= 1;
            urun.urunAdi = "Global";
            Console.WriteLine(urun.urunId);
            Console.WriteLine(urun.urunAdi);
             
            Kısı k = new Kısı();
            k.ekle();
            k.guncelle();
            k.KısıId = 1;
            k.KısıAdi = "gizem";
            Console.WriteLine(k.KısıId);
            Console.WriteLine(k.KısıAdi);
        }
      
       
    }
    class Musteri
    {
        public string musteriAdi;
        public int musteriYasi;
        public void ekle()
        {
            Console.WriteLine("Musteri ekle");
        }
        public void guncelle()
        {
            Console.WriteLine("Musteri guncelle");
        }
    }
    class Urun
    {
        public string urunAdi;
        public int urunId;
        public void ekle()
        {
            Console.WriteLine("Urun ekle");
        }
        public void guncelle()
        {
            Console.WriteLine("Urun guncelle");
        }
    }
}
