using System;

namespace hafta6
{
    internal class Program
    {
        /*
         *internal class Program
    {
        static void Main(string[] args)
        {
           // Telefon telefon = new Telefon();
            Kilif klf=new Kilif();
            Console.ReadKey();
        }
    } 
    class Esya
    {
        public Esya()
        {
            Console.WriteLine("Eşya çalıştı !!!");
        }
    }
    class Elektronikesya : Esya
    {
        public Elektronikesya()
        {
            Console.WriteLine("Elektronik Eşya çalıştı !!!");
        }
    }

    class Telefon : Elektronikesya
    {
        public Telefon()
        {
            Console.WriteLine("Telefon çalıştı !!!");
        }
    }

    class Kilif:Telefon
    {
        public Kilif()
        {
            Console.WriteLine("Kılıf takıldı");
        }
    }
        Açıklaması
        Önce Hangisi çalışır ?

      Eşya classı var.
      Ardından Elektronik eşya classı var class eşyadan miras alıyor.
      Ardından telefon classı var oda elektronik eşya classından miras alıyor.
      Hepsinin içinde nesne oluşturduğu anda ait olduğu classın çalıştığını ekrana yazacak constructor bulunuyor.
      Mainden Telefon Classı için bir nesne oluşturuluyor. Önce Hangisi çalışır ???
        ---------------------------------------------------------------------
        arac sorusu 
        //ana class (araç)

internal class araç
    {
        public string isim { get; set; }
        public int tekersayisi { get; set; }
        public double maliyet { get; set; }
        public string yakittipi { get; set; }
        public int model { get; set; }
        public int hiz { get; set; }
        public string vites { get; set; }
        public int fiyat { get; set; }

        public void borc()
        {
            Console.WriteLine("Borcunuz = " + fiyat+" TL");
        }
    }

// yan class


    internal class otomobil : araç
    {
        public string kasa { get; set; }
        public string yolcu { get; set; }

        public void yazotomobil()
        {
            Console.WriteLine("İsim = " + isim + "\nTeker Sayısı = " + tekersayisi + "\nKm başı maliyet = " + maliyet + "\nYakıt tipi = " + yakittipi + "\nModel = " + model + "\nMaksimum Hız = " + hiz + "\nVites Türü = " + vites +"\nKasa tipi = "+kasa+"\nYolcu Sayısı = "+yolcu +"\nFiyat = " + fiyat+"\n");
        }
    }
// yan class


    internal class kamyon : araç
    {
        public string kapasite { get; set; }
        public void yazkamyon()
        {
            Console.WriteLine("İsim = " + isim + "\nTeker Sayısı = " + tekersayisi + "\nKm başı maliyet = " + maliyet + "\nYakıt tipi = " + yakittipi + "\nModel = " + model + "\nMaksimum Hız = " + hiz + "\nVites Türü = " + vites +"\nKapasite = "+kapasite+ "\nFiyat = " + fiyat);
        }
    }
// yan class
  internal class motorsiklet : araç
    {
        public string ruzgarlik { get; set; }
        public void yazmotosiklet()
        {
            Console.WriteLine("İsim = " + isim + "\nTeker Sayısı = " + tekersayisi + "\nKm başı maliyet = " + maliyet + "\nYakıt tipi = " + yakittipi + "\nModel = " + model + "\nMaksimum Hız = " + hiz + "\nVites Türü = " + vites + "\nRüzgarlık = " + ruzgarlik + "\nFiyat = " + fiyat);
        }
    }

//main fonksiyon

  static void Main(string[] args)
        {
            otomobil toyota = new otomobil();
            toyota.isim = "Toyota Corolla";
            toyota.yakittipi = "Dizel";
            toyota.maliyet = 1.2;
            toyota.hiz = 240;
            toyota.kasa = "Sedan";
            toyota.yolcu = "5";
            toyota.tekersayisi = 4;
            toyota.vites = "Manuel";
            toyota.model = 2015;
            toyota.fiyat = 420000;

            otomobil bmw = new otomobil();
            bmw.isim = "BMW 520";
            bmw.yakittipi = "Benzin";
            bmw.maliyet = 1.4;
            bmw.hiz = 260;
            bmw.kasa = "Sedan";
            bmw.yolcu = "5";
            bmw.tekersayisi = 4;
            bmw.vites = "Otomatik";
            bmw.model = 2021;
            bmw.fiyat = 2000000;

            kamyon x = new kamyon();
            x.isim = "Isuzu NPR";
            x.yakittipi = "Dizel";
            x.maliyet = 2.5;
            x.hiz = 180;
            x.tekersayisi = 6;
            x.vites = "Manuel";
            x.model = 2009;
            x.kapasite = "5-10 Ton";
            x.fiyat = 350000;

            motorsiklet y = new motorsiklet();
            y.isim = "Honda Forza 750";
            y.yakittipi = "Benzin";
            y.maliyet = 0.75;
            y.hiz = 260;
            y.tekersayisi = 2;
            y.vites = "Otomatik";
            y.model = 2020;
            y.ruzgarlik = "Var";
            y.fiyat = 300000;

        k:
            Console.WriteLine("Ne almak istiyorsunuz? \n1 Otomobil \n2 Kamyon \n3 Motosiklet");
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            if (a == 1)
            {
                toyota.yazotomobil();
                bmw.yazotomobil();
                Console.WriteLine("Hangisini almak istiyorsunuz? \n1." + toyota.isim + "\n2." + bmw.isim);
                int z = int.Parse(Console.ReadLine());
                Console.Clear();
                if (z == 1)
                {
                    toyota.borc();
                }
                else if (z == 2)
                {
                    bmw.borc();
                }
            }
            else if (a == 2)
            {
                x.yazkamyon();
                x.borc();
            }
            else if (a == 3)
            {
                y.yazmotosiklet();
                y.borc();
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız. Yeniden seçiniz.");
                goto k;
            }
            Console.ReadLine();
        }
         */
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            Gemi gemi= new Gemi();
            Tren tren= new Tren();
            Ucak ucak= new Ucak();

            araba.Marka = "Mercedes";
            araba.Renk = "Kırmızı";
            araba.Hiz = "200";
            araba.Yil = 2023;
            araba.Fiyat = 1000000;
            araba.Karayollari = "evet";
            araba.Koltuk = "5";
            araba.Yolcutasima = "evet";

            araba.Marka = "LandRover";
            araba.Renk = "Siyah";
            araba.Hiz = "200";
            araba.Yil = 2023;
            araba.Fiyat = 1000000;
            araba.Karayollari = "evet";
            araba.Koltuk = "5";
            araba.Yolcutasima = "evet";

            gemi.Marka = "Celebrity Cruises";
            gemi.Renk = "Beyaz";
            gemi.Hiz = "100000";
            gemi.Yil = 2022;
            gemi.Fiyat = 100000000;
            gemi.DenizYollari = "evet";
            gemi.Koltuk = "500";
            gemi.Yolcutasima = "evet";

            tren.Marka = "KaraTren";
            tren.Renk = "Siyah";
            tren.Yil = 2022;
            tren.Hiz = "500";
            tren.Fiyat = 200000;
            tren.DemirYollari = "evet";
            tren.Koltuk = "500";
            tren.Yolcutasima = "evet";

            ucak.Marka = "THY";
            ucak.Renk = "Krem";
            ucak.Yil = 2022;
            ucak.Hiz = "500";
            ucak.Fiyat = 200000;
            ucak.HavaYollari = "evet";
            ucak.Koltuk = "5000";
            ucak.Yolcutasima = "evet";



            //Console.WriteLine("hangi  araç istersiniz");
            //string arac = Console.ReadLine();
            //if (arac == "bmw")
            //{
            //    b.yazdır();
            //    Console.WriteLine("hayırlı olsun");
            //}

            //else if (arac == "mercedes")
            //{
            //    m.yazdır();
            //    Console.WriteLine("hayırlı olsun");
            //}

            //else if (arac == "volvo")
            //{
            //    v.yazdır();
            //    Console.WriteLine("hayırlı olsun");
            //}
            //else
            //{
            //    Console.WriteLine("girilen araç elimizde mevcut değil");
            //}

        }
    }
}
