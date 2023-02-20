using System;

namespace ConsoleApp3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Hello World!");*
             *  Ic içe if Konu
             *  cinsiyet sor yaş sor ve öğrencimi çalışanmı emeklimi
             *  Console.WriteLine("Cinsiyetiniz nedir? Erkek ise e Kadın ise k giriniz. ");
            string c = Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz= ");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((c == "e" || c== "E") && (y < 20)) Console.WriteLine("Erkek ve öğrencisiniz.");
            else if ((c == "e" || c == "E") && (y < 40)) Console.WriteLine("Çalışan bir erkeksiniz.");
            else if ((c == "e" || c == "E") && (y < 60)) Console.WriteLi
            1-Console.WriteLine("Cinsiyetiniz nedir? Erkek ise e Kadın ise k giriniz. ");
            string c = Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz= ");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((c == "e" || c== "E") && (y < 20)) Console.WriteLine("Erkek ve öğrencisiniz.");
            2-else if ((c == "e" || c == "E") && (y < 40)) Console.WriteLine("Çalışan bir erkeksiniz.");
            else if ((c == "e" || c == "E") && (y < 60)) Console.WriteLine("Emekli bir erkeksiniz.");
            else if ((c == "k" || c == "K") && (y < 40)) Console.WriteLine("Kadın ve öğrencisiniz.");
            else if ((c == "k" || c == "K") && (y < 60)) Console.WriteLine("Orta Yaşlı bir kadınsınız.");
            else if ((c == "k" || c == "K") && (y < 80)) Console.WriteLine("Allah hayırlısını versin.");
             * benim cevap
             * Console.WriteLine("Cinsiyet Giriniz Kadın için K erkek için E");
            string cinsiyet = Console.ReadLine();
            
            Console.WriteLine("yaş giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yas);
            if ( cinsiyet== "K")
            {              
                if (yas < 20)
                {
                    Console.WriteLine("gençsiniz");

                     if (yas > 20)
                    {
                        Console.WriteLine("orta yas");

                        if (yas>60)
                        {
                            Console.WriteLine("Emeklilik");
                        }
                    }
                }
            }
            if (cinsiyet == "E")
            {
                
                if (yas> 20)
                {

                    Console.WriteLine("ogrenci");
                    
                    if (yas <40)
                    {
                        Console.WriteLine("çalısan");
                        if (yas <60)
                        {
                            Console.WriteLine("emekli");
                        }
                        
                    }
                }
            }
             *
             *  Girilen ayın hangi mevsim olduğunu bulan program
             *  Console.WriteLine("Kaçıncı ay olduğunu giriniz");
            string ay = Console.ReadLine();
            ay=ay.ToLower();
            if (ay =="ocak" || ay =="subat" || ay =="aralık")
            {
                Console.WriteLine("Kıs Ayındayız");
            }
            else if (ay == "mart" || ay == "nisan" || ay == "mayıs")
            {
                Console.WriteLine("ilkbahar Ayındayız");
            }
            else if (ay == "haziran" || ay == "temmuz" || ay == "agustos")
            {
                Console.WriteLine("yaz Ayındayız");
            }
            else if  (ay == "eylül" || ay == "ekim" || ay == "kasım")
            {
                Console.WriteLine("sonbahar Ayındayız");
            }
            else
            {
                Console.WriteLine("gecersiz girdiniz");
            }
            SWich
            swich içine değişkeni gir
            case blokları
            durumlar
            örnek
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Merhaba");
                    break;
                case 2:
                    Console.WriteLine("Güle güle");
                    break;
                case 3:
                    Console.WriteLine("Git");
                    break;
                
            }
            Mevsimleri swichle yap
            < Console.WriteLine("Lütfen Ayı Giriniz");
            string ay = Console.ReadLine();
            switch (ay)
            {
                case "ocak":
                case "şubat":
                case "Aralık":
                    Console.WriteLine(ay + "dasınız" + " Kış Mevsimi");
                    break;
                case "mart":
                case "nisan":
                case "mayıs":
                    Console.WriteLine(ay + " dasınız" + " İlkbahar Mevsimi");
            2.çözüm
            Console.WriteLine("Hangi ay olduğunu giriniz");
            string ay = Console.ReadLine();
            ay = ay.ToLower();
            switch (ay )
            {
                case "yaz": Console.WriteLine("haziran-temmuz-agustos");
                        break;
                case "sonbahar":
                    Console.WriteLine("eylül-ekim-kasım");
                        break;
                case "kış":
                    Console.WriteLine("aralık-ocak-şubat");
                        break;
                case "ilkbahar":
                    Console.WriteLine("mart-nisan-mayıs");
                        break;
                default:
                    Console.WriteLine("geçersiz ay");
                    break;

            }
            1.toplama 2. çıkartma 3.çarpma 4. bölme işlemi yapan program
              
            Console.Write("1. Sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayiyi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("yapılacak işlem seçiniz.Toplama + ,cıkarma - ,çarpma * ,Bölme / tıklayınız: ");
            string islem = Console.ReadLine();
           switch (islem)
            {
                case "+";
                    Console.WriteLine("Sonuc" +(sayi1 + sayi2));
                case "-";
                    Console.WriteLine("Sonuc" + (sayi1 - sayi2));
                case "*";
                    Console.WriteLine("Sonuc" + (sayi1 * sayi2));
                case "/";
                    Console.WriteLine("Sonuc" + (sayi1 / sayi2));
                default:
                    Console.WriteLine("hata");
                    break;
            }
            Kullanıcı adı ve parola girip  isteyin  sisteme giriş için paraloyu isteyin

            Sayi Bulma
          Console.WriteLine("Kullanıcı adı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Parola giriniz");
            string parola = Console.ReadLine();
            if (ad == "gizemcakan" && parola == "123456asd")
            {
                Console.WriteLine("tebrikler");

            }
            else if (ad == "gizemcakan" && parola =! "123456asd")
            {
                Console.WriteLine("Parola yanlış");
            }
            else if (ad =! "gizemcakan" && parola "123456asd")
            {
                Console.WriteLine("kullanıcı yanlış");
            }
            else
            {
                Console.WriteLine("kullanıcı adı ve parola yanlış");
            }
            Console.ReadLine();
            kullanıcı adı  ve parola istenicek eger onaylanırsa atm ekranı acılacak ve bakıye sorgulama,
            para yatırma , para cekme ve kar iade secenegı olucak.kart iade
            String KullanıcıAdı = "parzival";
            int parola = 123123;
            double bakiye = 5500;
            Console.WriteLine("*********************");
        z:
            Console.WriteLine("Kullanıcı Adı: ");
            Console.WriteLine("*********************");
            String girdi = Console.ReadLine(); ;
            Console.WriteLine("*********************");
            Console.WriteLine("Parola: ");
            Console.WriteLine("*********************");
            int girdi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*********************");
            Console.WriteLine("KONTOL EDİLİYOR.....");
            Console.WriteLine("LÜTFEN BEKLEYİNİZ.....");
            Console.WriteLine("*********************");

            if (KullanıcıAdı == girdi && parola == girdi2)
            {
                Console.WriteLine("HOŞGELDİNİZ" + " " + KullanıcıAdı + " Ne yapmak istersiniz:");
               y:
                Console.WriteLine("*********************");

                Console.WriteLine("Bakiye sorgulama:1");
                Console.WriteLine("Para yatırma:2");
                Console.WriteLine("Para çekme:3");
                Console.WriteLine("Kart iade:4");

                Console.WriteLine("*********************");

                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim) {

                    case 1:
                        Console.WriteLine("Bakiyeniz: " + bakiye);
                        
                        Console.WriteLine("yapmak istediğiniz başka bir işlem var mı?");

                        goto y;
                        break;

                    case 2:
                        Console.WriteLine("yartırmak istediğiniz miktarı girin ");

                        int yatir = Convert.ToInt32(Console.ReadLine());

                        bakiye = bakiye + yatir;

                        Console.WriteLine("Güncel bakiye: " + bakiye);
                        Console.WriteLine("yapmak istediğiniz başka bir işlem var mı?");
                        goto y;    
                        break;

                    case 3:
                        Console.WriteLine("Çekmek istediğiniz miktarı girin ");

                        int cekme = Convert.ToInt32(Console.ReadLine());
                        if (cekme > bakiye) Console.WriteLine("bakıyenız yetmemekte");

                        else
                        {
                            bakiye = bakiye - cekme;
                        }
                        Console.WriteLine("Güncel bakiye: " + bakiye);
                        Console.WriteLine("yapmak istediğiniz başka bir işlem var mı?");
                        goto y;
                        break;


                    case 4:
                        Console.WriteLine("kartınız iade ediliyor...... ");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim");
                        break;
                }

            }
            else if (KullanıcıAdı != girdi && parola == girdi2)
            {
                Console.WriteLine("Kullanıcı adınız yanlış");

                goto z;
            }
            else if (KullanıcıAdı == girdi && parola != girdi2)
            {
                Console.WriteLine("Parolanız yanlış");
                goto z;
            }
            else if (KullanıcıAdı != girdi && parola != girdi2)
            {
                Console.WriteLine("Kullanıcı adınız ve parolanız yanlış");
                goto z;
            }
            Console.ReadKey();
        }
            SORU: Kullanıcı taksinin gittiği km yi girecek. Aşağıdaki şartlara göre taksi ücreti hesaplanacak.
              5 km e kadar = 2tl per km
              12 km e kadar = 1tl per km
              12 km üstü = 0,5tl per km
             */
            Console.WriteLine("km giriniz");
            if (5*2)
            {

            }
            








        }
    }
}
