using System;

namespace hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
             WHİLE döngüsü
            soru 
            (aracın hızını giriniz-kaç sn sonra hız)
            sabit hızla giden araç her seferinde 5 sn basılı tut yüzde 10 hızı düşsün
            5 altına inince otamatik dursun
            Console.WriteLine("Aracın hızını giriniz: ");
            double hız = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç saniye ferene basılı tuttunuz: ");
            double sure = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            for (int i = 1; i <= sure; i++)
            {
                sayac = sayac + 1;
                hız = hız - (hız * 10 / 100);
                if (hız <= 5)
                {
                    hız = 0;
                    Console.WriteLine("ARAÇ DURDU.");
                    break;
                }
                Console.WriteLine(sayac+". saniye hızımız : "+" "+hız);
                
            }
              Console.WriteLine("aracın hızını giriniz");
            Console.WriteLine("kaç saniye sonraki hızı");
            int hız=Convert.ToInt32(Console.ReadLine());            
            int zaman =Convert.ToInt32(Console.ReadLine());
            
            while (true)
            {
                 (100 % 10-2)
            -------------------------------------
            Soru
            kullanıcıdan isim girildiğinde bilginiz
            doğru tarihi yazdın yanlış girilince yanlış yazdın
            cevap1
            String isim = "";
            while (isim != "Muzaffer")
            {
               Console.WriteLine("İsminizi Giriniz");
               isim = Console.ReadLine();
            }

            Console.WriteLine("Muzaffer ATASOY Tarih= "+ DateTime.Now);
            cevap2
            while (true)
            {
                Console.WriteLine("isim giriniz");
                string isim = Console.ReadLine();
                isim = isim.ToLower();
                if (isim == "gizem")
                {
                    Console.WriteLine(" Tarih " + DateTime.Now);
                    break;
                }
            }
            ---------------------------------------------
            klavyeden girilen sayıdan önceki tek sayıları listeleyecek(while)
             Console.WriteLine("Sayı Giriniz");
            int  girilensayi=Convert.ToInt32(Console.ReadLine());
            int sayi = 0;
            while (sayi<girilensayi)
            {
                if (girilensayi%2==1)
                {
                    Console.WriteLine(girilensayi);
                }
                girilensayi--;
            }
            -----------------------------
            DO WHİLE ilkte kullanılıyor
            -------------------------------
            1 den 10 a kadar olan sayıları do while ile yazdır.
            int sayi=0;
            do
            {
                Console.WriteLine(sayi);
                sayi=sayi+1;
            } while (sayi<=10);
            -----------------
            Kullanıcıdan belirlediği adette  sayıyı toplayıp girilen program
             Console.WriteLine("Kullanıcıdan girilen");
            int adet= Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int i = 0;
            do
            {
                Console.WriteLine("sayıyı giriniz");
                int sayi=Convert.ToInt32(Console.ReadLine());
                i++;
                toplam= toplam+1;
            } while (i< adet);
            -------------------------------
            kullanıcının girdiği  sayının altındaki sayıların asal sayılarını bulan program
             Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac;
 
            for (int i = 2; i < sayi; i++)
            {
                sayac = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    Console.WriteLine("Asal Sayılar = " + i);
                }
            }
            Console.ReadLine();

            -------------------------------------------------------
             */
            


        }
    }
}
