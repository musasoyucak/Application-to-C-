using System;

namespace Hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
             hesaplanmak istediğmiz şekli seç üçgen kare dikdörtgen işlem seç veri
            iste  işlem seç neyi hesaplamak istiyorsun alanı hesapla
            
             Console.WriteLine("Hesaplamak istediğiniz sekli seçin \ndikdörtgen için 1 \nüçgen 2\nkare 3");
            int a = 0, b = 0;
            int t=0,h=0;
            int kare = a * a;
            int ucgen = t * h/2;
            int dikdortgen = a * b;
            Console.ReadLine(Convert.ToInt32("ucgen", t * h / 2));

            if (true)
            {

            }


            if ()
            {
                Convert.ToInt32(ucgen);
            }
            else if () 
             {
                        Convert.ToInt32(kare);
             }
            else
            {
                Convert.ToInt32(kare);
            }
            ---
            Console.WriteLine("Alan hesabı yapacağınız geometrik şekli belirleyiniz.Kare=k üçgen=u dikdörtgen=d");
             string s = Console.ReadLine();
             Console.WriteLine(s);
             if (s == "k") { 
                 Console.WriteLine("karenin kenar uzunluğunu giriniz=");
             int a = 0;
             a= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Karenin alanı= " + (a * a));
             }
             else if(s=="d") { 

             Console.WriteLine("dikdörtgenin birinci kenar uzunluğunu giriniz=");
             int d1 = 0;
             d1= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("dikdörtgenin ikinci kenar uzunluğunu giriniz=");
             int d2 = 0;
             d2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Dikdörtgenin alanı= " + d1 * d2);
             }
             else if(s=="u")
             {
             Console.WriteLine("üçgenin taban kenarı uzunluğunu giriniz=");
             int u1 = 0;
             u1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("üçgenin yüksekliğini giriniz=");
             int u2 = 0;
             u2 = Convert.ToInt32(Console.ReadLine()); ;
             Console.WriteLine("üçgenin alanı alanı= "+ (u1*u2)/2);
             FOR 
              for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("\nGizem");
            }
              for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i+1+"\tGizem\n");
            }
            kullanıcıdan adet iste onlar döngüye girsin
                        int adet = 0; string yazi;

            Console.WriteLine("Ne yazmak istiyorsunuz?");
            yazi = Console.ReadLine();
            Console.WriteLine("Kaç adet yazmasını istiyorsunuz?");
            adet = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(yazi);
            }
            1 den 10a kadar olan sayıların toplamı
             int toplam = 0;
            for (int i = 1; i < 11; i++)
            {
                toplam = toplam + i;
                
            }

            Console.WriteLine(toplam);
            ------------
            sonsuz yazdırma
             Console.WriteLine("Ne yazıdırmak istiyorsunuz");
            string cevap= Console.ReadLine();
            for ( ; ; )
            {
                Console.WriteLine(cevap);

            }
            Console.ReadLine();
            ------------
            1den 100 kadar çift sayıları yazdırma
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            --------------
            Kullanıcının girdiği tek sayıları toplayan algoritma(2 sayi tek olnarı bul .çift olnarın karesi al)
            
            ----------------------------
            İstenilen aralıkta girilen sayıların tek olanların karesi toplamı,
            çift olanların küpünü toplamı  ve ortalamaları alacak ve toplayacak program.
            Console.WriteLine("birinci");
            int birinci = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci");
            int ikinci = Convert.ToInt32(Console.ReadLine());
         
    
            int toplama = 0;
            int toplam2 = 0;

            int adet = 0;
            int adet2 = 2;

          
     
            for (int i = birinci; i <= ikinci; i++)
            {

                if (i % 2 == 1)
                {
                    toplama += (int)Math.Pow(birinci, 3);
                    adet++;
                }
                else if (i % 2 == 0)
                {
                    toplam2 += (int)Math.Pow(birinci, 2);
                    adet2++;
                }

            }
            Console.WriteLine(toplama / adet);
            Console.WriteLine(toplam2 + adet2);
            ---
            Kullanıcı 10 sayı giricek en büyük en küçük sayi giricek
            Console.WriteLine("1  sayı giriniz");
            int sayi= Convert.ToInt32(Console.ReadLine());  
            int enk = sayi;
            int enb = sayi;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0}. sayiyi girin", i + 1);
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi> enb)
                {
                    enb = sayi;
                }
                if (sayi < enk)
                {
                   enk = sayi;
                }

            }
            Console.WriteLine("Girilen en küçük sayi="+enk);
            Console.WriteLine("Girilen en büyük sayi=" + enb);
            -----------------------------------------
            A'dan Z'ye olan harfleri ekrana yazdır
             for (char i = 'a'; i <='z'; i++)
            {
                Console.WriteLine(i);
            }
            -----------------------------------------
            Soru:  İstenilen aralıkta girilen sayıların
            son rakamı 5 ve 5 ten büyük olanlarında çift 
            olanlarının ortalamasını alan program.
            ----------------------------------------
            Faktoriyel bulma
             Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(sayi + "! = " + faktoriyel);
 
            Console.ReadLine();

              Console.WriteLine("sayi1");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi2");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; 10 < length; i++)
            {

            }
             */









        }
    }
}
