using System;

namespace hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Console.WriteLine("Hello World!");
             --------------------------------------------------------------
            Soru-
            Her 2 saniyede 2 ye bölünen bakteri
            kolonisi var başlangıç durumunda 16 tane var 24. sn deki bakteri sayısı
            12. saniyedeki bakteri sayısının kaç katıdır.
            cvp benim yarım
             for (int i = 1
            Console.WriteLine("bakteri");
            int saniye = Convert.ToInt32(Console.ReadLine());
            int ilkbakteri = 16;
            int bakteri = 0;
            while (true)
                if (saniye %2 ==0)
                {
                    Console.WriteLine("bakteri sayısı=  " + bakteri);

                }
            cevap
             Console.WriteLine("Saniye Girin");
            int saniye = Convert.ToInt32(Console.ReadLine());
            int bakteri = 16;
            int bakteri1 = 16;
            int bakteri2 = 16;

            for (int i = 1; i <= saniye; i += 2)
            {
                bakteri = bakteri * 2;
                Console.WriteLine($"{i}.Saniyede Bakteri Sayısı={bakteri}");
                Console.WriteLine($"{i + 1}.Saniyede Bakteri Sayısı={bakteri}");
            }
            Console.WriteLine($"******************************************");


            for (int i = 1; i <= 12; i+=2)
            {
                bakteri1 = bakteri1 * 2;
            }

            for (int i = 1; i <= 24; i+=2)
            {
                bakteri2 = bakteri2 * 2;
            }

            int sonuc = bakteri2 / bakteri1;
            Console.WriteLine($"12.Saniyede Bakteri Sayısı = {bakteri1}"); 
            Console.WriteLine($"24.Saniyede Bakteri Sayısı = {bakteri2}");
             Console.WriteLine($"kat = {sonuc}");
            --------------------------------------------------------------
            Soru-
            Aynı firmada çalışan Ahmet ve Hasan 2 işçiden 1. sinin Ahmedin
            ücreti ilk ay %50 artmakta 2. ay %25 azalmaktadır. 
            Diğerinin(Hasanın) ise ücreti her ay %25 artmaktadır. 
            Her ikisinin de yılbaşındaki başlangıç ücretleri ve hesaplanacak
            ay bilgisi klavyeden girildikten sonra ay ay  ücretlerinin
            ne olacağını ve en sonunda hangi işçinin daha fazla (Veya eşit)
            ücret alacağını hesaplayan programı yazınız.
            int ahmet = 5000, hasan = 5000;
            Console.WriteLine("başlangıç ücret");
            Console.WriteLine("hesaplanacak ay bilgisi");
            
            int ucret=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 12; i++)
            {
                if (i%2==0)
                {
                    ahmet = ahmet * 150/100;
                    Console.WriteLine("Ahmet 1.ay =" + ahmet);
                }
                
                            
                else
                {
                    ahmet = ahmet * 125 / 100;
                    Console.WriteLine("ahmet 2.ay=" + ahmet);
                    ahmet--;
                }
            }
            for (int i = 1; i < 12; i++)
            {
                if (i%2==0)
                {
                    hasan=hasan* 125 / 100;
                    Console.WriteLine("Hasan1.ay = " + hasan);
                }
                else    
                {
                    hasan = hasan * 150 / 100;
                    Console.WriteLine("hasan2.ay = " + hasan);
                    
                }
            }
            --------------------------------------------------------------
            Soru- 
            40  *  50=2000  
            20     100
            10     200
            5     -400-
            2      800
            1      1600
                   2000
            iki sayiyi çarp, ilk sayıyı yarıya böl, bu mantiği yapan soru bölen tekse topla 
            cevap1
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("1. Sayıyı girin");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı girin");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
            Console.WriteLine("");
           
            for (int i = sayi1; i >= 1; i--)
            {
                if (sayi1 % 2 == 1)
                {
                    sonuc = sonuc + sayi2;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(sayi1 + "             " + sayi2);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(sayi1 + "             " + sayi2);
                }

                if (sayi1 == 1)
                {
                    break;
                }
                sayi2 = sayi2 * 2;
                sayi1 = sayi1 / 2;

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ÇARPIM=" + sonuc);
            cevap2
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Birinci Sayı giriniz");
            int Birincisayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci Sayı giriniz");
            int Ikincisayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            if (Birincisayi%2==1)
            {
                toplam = toplam + Ikincisayi;
            }
            while (Birincisayi>=1)
            {
                Birincisayi = Birincisayi / 2;
                Ikincisayi = Ikincisayi * 2;
                if (Birincisayi%2==1)
                {
                    toplam = toplam + Ikincisayi;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }
              Console.WriteLine(toplam);

            --------------------------------------------------------------
            
            TRIM
            string bosluklu = "   Gizem   ";
            bosluklu=bosluklu.Trim();
            Console.WriteLine(bosluklu); 
            IndexOF methodu
            ---
            string kelime = "Gizem";
            Console.WriteLine(kelime.IndexOf('h'));
            string kelime2 = "Mahide Gizem Topaloglu";
            Console.WriteLine(kelime2.IndexOf("Mahide"));
            ---
            LastIndexOf
             string kelime = "Gizem";
            Console.WriteLine(kelime.LastIndexOf('i'));
            string kelime2 = ("Mahide Gizem Topaloglu");
            Console.WriteLine(kelime2.IndexOf("id"));
            string str3 = "Mahide Gizem Topaloglu";
            Console.WriteLine(str3.LastIndexOf('i', 8, 5));
            Console.WriteLine(str3.LastIndexOf('i', 9, 7));
            Console.WriteLine(str3.LastIndexOf('i', 10, 8));
            Console.WriteLine(str3.LastIndexOf('i', 11, 9));
            ---
            Insert
            string str5 = "C# ile Nesne tabanlı Programlama";
            str5 = str5.Insert(str5.Length, "dan gizem");
            Console.WriteLine(str5);
            ---
            Remove
            ---
            Replace
             string str5 = "C# ile Nesne tabanlı Programlama";
             str5 = str5.Remove(5);
             Console.WriteLine(str5);
            //Metnin istenilen yerden sonraki raklamlarını istenilen kadar sile;
            str5 = "C# ile Nesne tabanlı Programlama";
            Console.WriteLine(str5);
            Soru-
            --------------------------------------------------------------
           

            Console.WriteLine("Gizem");
            string isim=Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim.Substring(i, 1));
            }
             Soru-
           int a = 0;
            int e = 0;
            int ı = 0;
            int i = 0;
            int o = 0;
            int ö = 0;
            int u = 0;
            int ü = 0;

            Console.WriteLine("ifade giriniz");
            string ifade = Console.ReadLine().ToLower();
            
            int ad2 = ifade.Length;
            int j = 0;  
            while (j < ad2)
            {


                switch (ifade.Substring(j,1))
                {
                    case "a":
                        a++;
                        break;
                    case "e":
                        e++;
                        break;
                    case "ı":
                        ı++;
                        break;
                    case "i":
                        i++;
                        break;
                    case "o":
                        o++;
                        break;
                    case "ö":
                        ö++;
                        break;
                    case "u":
                        u++;
                        break;
                    case "ü":
                        ü++;
                        break;

                }
                j++;
            }

            Console.WriteLine("A="+a+" E="+e+" I="+ı+" İ="+i+" O="+o+" Ö="+ö+" U="+u+" Ü="+ü);
            --------------------------------------------------------------
            Soru-
            string metin = "Mahide gizem Çakan Topaloglu";
            string sesli = "aeıioöuü";

            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                
                if (sesli.Contains(metin))
                {
                    sayac++;
                }
            }
            Console.WriteLine(metin);
            Console.WriteLine("  sesli harf vardır.", sayac);
            Console.ReadLine();
            --------------------------------------------------------------
            Soru-
            
             Console.WriteLine("Adını yaz");
            string ad = Console.ReadLine();


            for (int i = ad.Length; i > 0; i--)
            {



                Console.WriteLine(ad.Substring(i));
            }

            for (int j = 0; j < ad.Length; j++)
            {

                Console.WriteLine(ad.Substring(j));
            }
            --------------------------------------------------------------
           */





        }
    }
}
