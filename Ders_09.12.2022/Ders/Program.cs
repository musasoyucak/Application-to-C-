using System;

namespace Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Console.WriteLine("Hello World!");
             * Atm para çekme  en az banknot ile ödeme yapılacak 
             ör  580 tl için
             2 adet 200lük ,1adet 100lük ,1adet 50lik,1adet20lik, 1 adet 10luk şeklinde yazılacak

            Console.Write("tutar giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((s1 - (s1 % 200)) / 200) + "adet 200 lük");
            Console.WriteLine((((s1 - (s1 % 100)) / 100) % 2) + "adet 100 lük");
            Console.WriteLine((((s1 % 100) - (s1 % 50)) / 50) + "adet 50 lik");
            Console.WriteLine(((s1 % 50) / 20) + "adet 20 lik");
            Console.WriteLine(((s1 % 50) / 30) + "adet 10 luk");
            Console.ReadLine();


             Console.WriteLine("Para çekme");
            int tutulan=Convert.ToInt32(Console.ReadLine());

         int bölme  = tutulan / 200;
            Console.WriteLine("bu kadar" + bölme + "var");

            2. çözüm

            Console.WriteLine("Parayı giriniz");
            int girdi = Convert.ToInt32(Console.ReadLine());

            int ikiyüzlük = girdi / 200;

              Console.WriteLine("İki yüzlük: "+ikiyüzlük);

              int yüzlük = (girdi - ikiyüzlük*200) / 100;
              Console.WriteLine("Yüzlük: " + yüzlük);

             int ellilik = (girdi - yüzlük*100 - ikiyüzlük*200) / 50;

             Console.WriteLine("Ellilik: " + ellilik);
             int yirmilik = (girdi - yüzlük*100 - ikiyüzlük*200-ellilik*50) / 20;

             Console.WriteLine("Yirmilik: " + yirmilik);
             int onluk = (girdi - yüzlük*100 - ikiyüzlük*200 - ellilik*50-yirmilik*20) / 10;

             Console.WriteLine("onluk: " + onluk);

            int beslik = (girdi - yüzlük*100 - ikiyüzlük *200- ellilik*50 - yirmilik*20-onluk*10) / 5;

            Console.WriteLine("beslik: " + beslik);

            sonsuz söngüye giriyor hatalı long yazınca düzeliyor
            int sayac=0;
            git:
            sayac++;
            if (sayac<5)
            {
                Console.WriteLine("yaz");
            }
            Console.WriteLine(sayac);
            goto git;

            kullanıcı sayı ve ifade girsin ne yazdırmasını istiyorsun?


            string a; int b = 0;
            Console.WriteLine("Yazılmasını istediğiniz ifadeyi yazınız");
            a = Console.ReadLine();
            Console.WriteLine("Kaç adet yazılsın");
            b = Convert.ToInt32(Console.ReadLine());

            int sayac = 0;
        git:
            sayac++;
            if (sayac <= b)
            {
                Console.WriteLine(a);
                goto git;
            }

            **benim yarım çözüm**

            Console.WriteLine("Kaç kere yazdırmak istersiniz");
            int sayac =Convert.ToInt32(Console.ReadLine());
            sayac++;
            if (sayac ++)
            {
                Console.WriteLine("yaz");
            }
           
            Console.WriteLine("Ne yazdırmak istersiniz");
            1den 100 kadar sayıları yazdır
            int sayac = 1;
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
        git:
            
            if (sayac <= sayi) 
            { 
                Console.WriteLine("SAYI:" + sayac); 
                sayac = sayac+1; 
            }
            goto git;

            int sayac = 0;
            int toplam = 0;
        git:

            sayac++;
            if (sayac< 11)
            {

                Console.WriteLine(sayac);
                
                
                goto git;
            }
            toplam = toplam + sayac;
            1den 10 kadar olan sayıların toplamı
            int sayac = 0;
            int toplam = 0;
        git:

            sayac++;
            if (sayac< 11)
            {

                
                toplam = toplam + sayac;

                goto git;
            }
            Console.WriteLine(toplam);

            örnekk

             int s = 0, a = 0; int dadet=0 ,dadeti=0;
            Random rnd = new Random();
         kl:
            if ( s < 10)
            {
                a = rnd.Next(10, 100);
                Console.WriteLine(a);
                if (a % 5 ==0)
                {
                    Console.WriteLine("bölünebilir    ");
                    dadet++;
                }
                else
                {
                    Console.WriteLine("bölünemez    ");
                    dadeti++;
                }
                s++; goto kl;
            }
            Console.WriteLine(dadet + "kadar bölünebilir");
            Console.WriteLine(dadeti + "kadar bölünemez");
            Console.Read();

            Soru: Kullanıcının gireceği Random istenen adet sayı, alt sınır, üst sınır girilecek. 
            Sayıların mod 10 a göre 5 e eşit ve büyük olanların % 10 fazlalarını alıp toplayacak ve
            ortalamasını alacak program.
            int alt = 0, ust = 0 , girenadet=0,sayac=0;
            double t = 0;
            Random rnd = new Random();
            
            int altsınır=Convert.ToInt32(Console.ReadLine());
            int ustsınır = Convert.ToInt32(Console.ReadLine());
            int adet = Convert.ToInt32(Console.ReadLine());
            
            k:
            if (sayac < adet)
            {
                int s = rnd.Next(alt, ust + 1);
                if (s % 10 >= 5)
                {
                    t = t + s * 110 / 100;
                    girenadet++;
                }
                sayac++; goto k;
            }
            Console.WriteLine(t);
            Console.WriteLine(t/girenadet);
            CRTL kD aynı anda bas

            ör zar 100 kere  atılıyor kaçtan kaç kere geldi
            int s = 0; int a = 1, bir = 0, iki = 0, uc = 0, dort = 0, bes = 0, altı = 0;
            Console.WriteLine("Kaç Kere Zar Atılacak?");
            s=Convert.ToInt32(Console.ReadLine());
           
            Random rnd = new Random();
        erd:
            if (a <= s)
            {
                int g = rnd.Next(1,7);
                switch (g)
                {
                    case 1: bir = bir + 1; break;
                        case 2: iki=iki+1; break;
                        case 3: uc=uc+1; break;
                        case 4:dort = dort+1; break;
                        case 5:bes=bes+1; break;   
                        case 6:altı=altı+1; break;                    
                }

                a++; goto erd;
            }
            
            Console.WriteLine(bir  +  " Adet 1 Geldi");
            Console.WriteLine(iki  +  " Adet 2 Geldi");
            Console.WriteLine(uc  +  " Adet 3 Geldi");
            Console.WriteLine(dort  +  " Adet 4 Geldi");
            Console.WriteLine(bes  +  " Adet 5 Geldi");
            Console.WriteLine(altı  +  " Adet 6 Geldi");
            Console.ReadLine();

            örnek
            bütün zarların toplamı 

            int toplam = 0; int s = 0; int a = 1, bir = 0, iki = 0, uc = 0, dort = 0, bes = 0, altı = 0;
            Console.WriteLine("Kaç Kere Zar Atılacak?");
            s = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
        erd:
            if (a <= s)
            {
                int g = rnd.Next(1, 7);
                switch (g)
                {
                    case 1: bir = bir + 1; break;
                    case 2: iki = iki + 1; break;
                    case 3: uc = uc + 1; break;
                    case 4: dort = dort + 1; break;
                    case 5: bes = bes + 1; break;
                    case 6: altı = altı + 1; break;
                }
                toplam = toplam + g;
                 a++; goto erd;
            }

            Console.WriteLine(bir + " Adet 1 Geldi");
            Console.WriteLine(iki + " Adet 2 Geldi");
            Console.WriteLine(uc + " Adet 3 Geldi");
            Console.WriteLine(dort + " Adet 4 Geldi");
            Console.WriteLine(bes + " Adet 5 Geldi");
            Console.WriteLine(altı + " Adet 6 Geldi");
            Console.ReadLine();

            Soru:  2 basamaklı rastgele iki sayının toplamı ekrana yazacak. Kullanıcı işlemin cevabını yazıp enter a basacak.
            Eğer cevap doğruysa ekrana “tebrikler bildiniz puanınız x” şeklinde yazacak, soruya verilen cevap
            yanlışsa “üzgünüz yanlış cevap, puanınız x” şeklinde yazacak. Her doğru cevaba +5,her yanlış cevaba -2 puan ekleyecek.
            Sorulara evet denirse bir sonraki soru gelecek, hayır denirse işlemi sonlandırıp test puanını yazacak.

            Random rnd = new Random();
            int Dpuan=0, Ypuan = 0;
        g:

            int sayi = rnd.Next(10, 100);
            Console.WriteLine(sayi);
            int sayi2 = rnd.Next(10, 100);
            Console.WriteLine(sayi2);
            int toplam = sayi + sayi2;

            Console.WriteLine("İki sayının toplamını yazınız :");
            int cvp = Convert.ToInt32(Console.ReadLine());


            if (cvp == toplam)
            {
                Console.WriteLine("TEBRİKLER DOĞRU BİLDİNİZ.  +5 PUAN KAZANDINIZ .");
                Dpuan = Dpuan + 5;

            }
            else
            {
                Console.WriteLine("ÜZGÜNÜZ BİLEMEDİNİZ.  -2 PUAN  .");
                Ypuan = Ypuan - 2;

            }
            Console.WriteLine("Tekrar devam etmek istiyor musunuz : \n EVET =1 HAYIR=0");
            int devamMi = Convert.ToInt32(Console.ReadLine());

            if (devamMi == 1)
            {

                goto g;


            }
            else
            {
                goto k;
            }

        k:
            Console.WriteLine("Puanınız: " + (Dpuan + Ypuan));

        }

           ** benim eksik cevap
            Random rnd = new Random();
            rnd.Next();
            int sonuc=rnd.Next();
            int sayi1, sayi2;
            sonuc= sayi1 = rnd.Next();
            if (sonuc<10)
            {
                
            }
            else
            {
                sonuc > 2;
            }
            Console.WriteLine("iki basamaklı 1 sayi");
            
            Console.WriteLine("iki basamaklı 2 sayi");


            1-100 arası sayı tahmin etme  kullanıcıdan aşağı dedi 
            int a=0,tahmin=0;
            Random rnd  = new Random(); 
            a= rnd.Next(1,100); 
            k:
            Console.WriteLine("Tahmin edin:");
            tahmin=Convert.ToInt32(Console.ReadLine());

           
            if (a==tahmin)
            {
                Console.WriteLine("Tebrikler Bildiniz");
            }

            else if (a<=tahmin) 
            {
                Console.WriteLine("Daha küçük tahmin yapın");
            }

            else if (a >= tahmin)
            {
                Console.WriteLine("Daha büyük tahmin yapın");
            }

            goto k;
            */










        }
    }
}
