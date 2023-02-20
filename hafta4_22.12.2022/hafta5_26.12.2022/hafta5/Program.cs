using System;

namespace hafta5
{
    internal class Program
    {
        /*
         * Console.WriteLine("Hello World!");
         * ----------------------------------------------------------------------------
         * Parse methodu 
         * buradaki değişken int, double vs olabilir sonucta istenenle methodtaki aynı olacak iç içe method ör
         *  static void Main(string[] args)
        {
            Console.WriteLine(Toplam());
        }
        static int Toplam()
        {
            Console.WriteLine("Bir sayi griniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayi griniz");
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc= sayi + sayi2;    
            return sonuc;
        }
        ----------------------------------------------------------------------------
        deger döndüren büyükmü küçükmü  method yapılacak
        static void Main(string[] args)
        {
            Console.WriteLine(BuyukKucuk());
        }
        static int BuyukKucuk()
        {
            Console.WriteLine( "Bir sayi  giriniz");
            int sayi1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ikıncı sayi  giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            if (sayi1>sayi2)
            {
                Console.WriteLine(sayi1 + " > " + sayi2+"Büyüktür");
                return sayi1;
            }
            else
            {
                Console.WriteLine(sayi2 + " > " + sayi1+ "Büyüktür");
                return sayi2;
            }
           
        }
        2. cevap------------
        Console.Write("bir sayı giriniz:");
            int sayi1=int .Parse(Console.ReadLine());
            Console.Write("bir sayı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            int buyuk = sayi1;
            if (buyuk < sayi2) { buyuk = sayi2; }
            return buyuk;
        3. cevap----------------
        Console.WriteLine(sayi % 2 == 1 ? "Tek" : "Çift" );
        if yerine
        Tek satırda if  aynı örnek
        ---------------------------------------------------------------------------
        3 lü toplama  parametreli
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi  giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikıncı sayi  giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ucuncu sayi  giriniz");
            int sayi3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Toplam(sayi1,sayi2,sayi3));
        }
        static int Toplam(int s1,int s2,int s3)
        {
            int toplama = s1 + s2 + s3;
            return toplama;
        }
       -----------------------------------------------------------------------------
        Bir sayi ver tekmi çiftmi bul bool'a 
         static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi  giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            
          
           
            Console.WriteLine( TekCift(sayi1));
        }
        static bool TekCift(int s1)
        {
            if (s1  % 2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        ------------------------------------------------------------------------------------
        Asal sayi
         static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi  giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine(asal(sayi1));
        }
        static bool asal(int s1)
        {
            for (int i = 2; i < s1; i++)
            {
                if (s1 % i ==0)
                {
                    return true;
                }
            }
            return false;
        }
        ------------------------------------------------------------------
        tür değişkeni eşkenar ikiz kenar çeşit kenar 
         static void Main(string[] args)
        {
            Console.WriteLine("birinci kenar  giriniz");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikıncı kenar   giriniz");
            int kenar2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ucuncu kenar   giriniz");
            int kenar3 = int.Parse(Console.ReadLine());
            Console.WriteLine(ucgen( kenar1,kenar2,kenar3));
        }
        static string ucgen(int k1,int k2, int k3 )
        {
            if (k1== k2 & k1==k3 & k2== k3)
            {
                return " eskenar";
            }
            else if (k1 != k2 && k1 !=k3 && k2!=k3)
            {
                return " ceşitkener";
            }
            else
            {
                return " ikizkenar";
            } 
        }
        -----------------------------------------------------------
        Soru
         static void Main(string[] args)
        {
            for (int i = 0; i < Dizi().Length; i++)
            {
                Console.WriteLine("Dizimizin { 0} Elemanı ={ 1}" + Dizi()[i]);
            }
        }
        static int[] Dizi()
        {
            int sayac = 0;
            int[]dizi= new int[5];
            for (int i = 0; i < 5; i++)
            {
                dizi[i] = sayac;
                sayac++;
            }
            return dizi;
        }
        ---------------------------------------------------------------------------------
         static void Main(string[] args)
        {
            Console.WriteLine("Baslangıc  giriniz");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitis giriniz");
            int son = int.Parse(Console.ReadLine());
            Console.WriteLine("Adet  giriniz");
            int adet = int.Parse(Console.ReadLine());
            for (int i = 0; i < rasgele(bas, son,adet).Length -1; i++)
            {
                Console.WriteLine("Dizinin {0} Elemanı {1}", i + 1, rasgele(bas, son, adet)[i]);
            }
            
            Console.ReadKey();
        }
        static int[] rasgele(int s1, int s2, int s3)
        {
            int[] dizi = new int[s3];
                for (int i = 0; i < s3; i++)
            {
                Random random = new Random();
                dizi[i] = random.Next(s1, (s2 + 1));
            }
            return dizi;
        }
        ---------------------------------------------------------------------------------
         Girilen ürünün% 20 indirim hespa methodu  bu ürün 500 360 tl düştü % 20 indirim  uygulandı
        static void Main(string[] args)
        {
            Console.WriteLine("Urun giriniz");
            int urun1 = int.Parse(Console.ReadLine());
            Console.WriteLine(indirim (urun1));
        }
        static int indirim(int urun)
        {

            urun = (urun * 80) / 100;
                return urun;
        }
        ----------------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("Urun giriniz");
            int urun1 = int.Parse(Console.ReadLine());
            Console.WriteLine(indirim (urun1));
        }
        static double indirim(double urun)
        {
            if (urun >= 500)
            {
                urun = urun * 0.5;
                return urun;
            }
            else
            {
                urun = urun * 0.8;
            }
                return urun;
        }
        -----------------
        object türümdeki soyası unboxing yapıyorruz
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Urun giriniz");
            int urun1 = int.Parse(Console.ReadLine());
            Console.WriteLine(indirim(urun1));
        }
        static double indirim(double urun)
        {
            if (urun >= 500)
            {
                urun = urun * 0.5;
                return urun;
            }
            else
            {
                urun = urun * 0.8;
            }
            return urun;
        }
    }
}
