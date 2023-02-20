using System;

namespace hafta4
{
    internal class Program
    {/*
              Console.WriteLine("Hello World!");
            Parametre
            
              static void Main(string[] args)
        {
            yaz("maliye");

            string kalem = "silgi";
            yaz(kalem);
            Console.ReadLine();
        }
        static void yaz (string mesaj)
        {
            Console.WriteLine(mesaj);
        }
            ---------------------------------------------------------------------
            Soru
            Kullanıcının istediği istedği kadar ekrana yazdıran method
            
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bir mesaj giriniz");
            string mesaj = Console.ReadLine();
            Console.WriteLine("adet giriniz");
            int adet = Convert.ToInt32(Console.ReadLine());
            tekrareden(mesaj ,adet);
        }
        static void tekrareden( string m,int a)
        {
            
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(m);
            }
        }
        
            ---------------------------------------------------------------------
        soru
           static void Main(string[] args)
        {
            Console.WriteLine("kullanıcıdan 1sayi");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kullanıcıdan 2sayi");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            kareAlan(sayi1,sayi2);

        }
        static void kareAlan(int s1, int s2)
        {

            int toplam = s1 * s2;
                Console.WriteLine(toplam);
            
        }
            ---------------------------------------------------------------------
        
            ör
          static void Main(string[] args)
        {
            Console.WriteLine("kullanıcıdan 1sayi");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kullanıcıdan 2sayi");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            kareAlan(sayi1,sayi2);

        }
        static void kareAlan(int s1, int s2)
        {
            for (int i = 0; i < 10; i++)
            {
                int toplam = s1 * s2;
                Console.WriteLine(toplam);
            }
            
        }
            ---------------------------------------------------------------------
            Soru
            Tekmi çiftmi
        static void Main(string[] args)
        {
            Console.WriteLine("kullanıcıdan 1sayi");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            

            TekCift(sayi1);

        }
        static void TekCift(int s1)
        {
            if (s1 % 2==0)
            {
                Console.WriteLine("Girilen sayı çiftir.");
            }
            else
            {
                Console.WriteLine("Girilen sayi tektir.");
            }
            
        }
            ---------------------------------------------------------------------
            Soru
          static void Main(string[] args)
        {
           
            
            Console.WriteLine("birinci giriniz");
            int tabansayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci giriniz");
            int kuvet = Convert.ToInt32(Console.ReadLine());

            UsAlma(tabansayi,kuvet);

        }
        static void UsAlma(int s1,int s2)
        {
            int sonuc = 1;
            for (int i = 0; i < s2; i++)
            {
                sonuc = sonuc * s1;
               
            }
            Console.WriteLine(sonuc);



        }
     
            ---------------------------------------------------------------------
            Overload method
        ---------------------------------------------------------------------
        1. cevap

        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane sayı gireceksiniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayıları girin");
            if (sayi == 2)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                toplama(a, b);
            }
            else if (sayi == 3)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                toplama(a, b, c);
            }
            else if (sayi == 4)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int d = Convert.ToInt32(Console.ReadLine());
                toplama(a, b, c, d);
            }



        }
        static void toplama(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        static void toplama(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);

        }
        static void toplama(int a, int b, int c, int d)
        {
            Console.WriteLine(a + b + c + d);

        }
            ---------------------------------------------------------------------
            Soru
            Dönüşlülüler,ovorload
        ---------------------------------------------------------------------
         yol eşittir hız çarpı zaman
        ---------------------------------------------------------------------
        static void Main(string[] args)
        {


            Console.WriteLine("birinci sayi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ucuncu sayi giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dort sayi giriniz");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            Toplama(sayi1,sayi2);
            Toplama(sayi1, sayi2,sayi3);
            Toplama(sayi1, sayi2,sayi3,sayi4);

        }
        static void Toplama(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine(toplam);


        }
        static void Toplama(int s1, int s2,int s3)
        {

            int toplam = s1 + s2 + s3;
            Console.WriteLine(toplam);

        }
        static void Toplama(int s1, int s2, int s3, int s4)
        {
            int toplam = s1 + s2 + s3 +s4;
            Console.WriteLine(toplam);


        }
        ---------------------------------------------------------------------
        
        Console.WriteLine("Hız hesaplama için 1'e bas");
            Console.WriteLine("Zaman hesaplama için 2'e bas");
            Console.WriteLine("Yol hesaplama için 3'e bas");


            int yol1 = 0, zaman1 = 0, hız1 = 0;
            int menu=Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Yolu girin:");
                    yol1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Zamanı girin:");
                    zaman1 = Convert.ToInt32(Console.ReadLine());
                    hız(yol1,zaman1); break;
                case 2:
                    Console.WriteLine("Hızı girin:");
                    hız1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yolu girin:");
                    yol1 = Convert.ToInt32(Console.ReadLine());
                    zaman(hız1,yol1); break;
                case 3:
                    Console.WriteLine("Hızı girin:");
                    hız1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Zamanı girin:");
                    zaman1 = Convert.ToInt32(Console.ReadLine());
                    yol(hız1,zaman1); break;
            }
static void hız(int yol, int zaman)
        {
            Console.WriteLine(yol * zaman);
        }

        static void zaman(int yol, int hız)
        {
            Console.WriteLine(hız / yol);
        }

        static void yol(int zaman, int hız)
        {
            Console.WriteLine(hız / zaman);
        }
        ------------------------------------------------------------------------
        sipariş programı
        menü
        
        neli istiyosunuz 
        icecek varsa 4 parametre
        hesap alma  metdodu içeçeğe göre değişicek 
        static void menu()
        {

            Console.WriteLine("YİYECEKLER MENÜSÜ");
            string[] yemekler = new string[] { "HAMBURGER", "OSMANLI TOKATI", "ÇİĞKÖFTE", "KAYSERİ YAĞLAMASI", "SARMA" };
            for (int i = 0; i < yemekler.Length; i++)
            {
                Console.WriteLine(i + ". yemek= " + " " + yemekler[i]);
            }
            Console.WriteLine("İÇECEK MENÜSÜ");
            string[] icecekler = new string[] { "SU", "MEYVE SUYU", "KAHVE", "KOLA" };

            for (int i = 0; i < icecekler.Length; i++)
            {
                Console.WriteLine(i + ". icecek= " + " " + icecekler[i]);
            }


        }

        ---------------------------------------------------------------------
             */

        static void Main(string[] args)
        {


            Console.WriteLine("yol");
            int yol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hız");
            int hız = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zaman");
            int zaman = Convert.ToInt32(Console.ReadLine());

            yolproblem(yol,hız,zaman);
        
        }
        static void yolproblem(int y, int h,int z)
        {
            y = h * z;
            Console.WriteLine(y);


        }
        


    }
}
