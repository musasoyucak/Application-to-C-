using System;

namespace hafta5
{
    internal class Program
    /*
      OOP
      Nesneye yönelikli programlama
     Çevre ve alan hesaplasın 
    static void Main(string[] args)
    {

        Dikdortgen d = new Dikdortgen();
        //d.Alan();
        //d.Cevre();

        Console.Write("Kısa kenarı Girin : ");
        int kk = Convert.ToInt32(Console.ReadLine());
        Console.Write("Uzun kenarı Girin : ");
        int uk = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin alanı : {0}", d.Alan(kk, uk));
        Console.WriteLine("Dikdörtgenin çevresi : {0}", d.Cevre(kk, uk));
    }
      static void Main(string[] args)
        {
            //nesne oluşturma
            Insan insan = new Insan();
            // ad referans tür
           // insan.Ad = "Gizem";
            Console.WriteLine(insan.Ad);
        }
    ----------------------------------
     static void Main(string[] args)
        {

            Insan insan = new Insan("gizem");

            Console.WriteLine(insan.Ad);

            Insan zaman = new Insan(); 
            Console.WriteLine(zaman);
        }

    ---------------------------
     kayıt traihi girilicek
    date time nowla cagır
    bisiklek claso pedal cevirme ,hız ,vites ,lastik boyutu,renk özellikleri
    bisiklet 1 şu özelliklerde diye dolduruyoruz.
    static void Main(string[] args)
        {

            Bisiklet bisiklet = new Bisiklet();
            bisiklet.Renk = "kırmızı";
            Console.WriteLine(bisiklet.Renk);
            bisiklet.Hız = 100;
            Console.WriteLine(bisiklet.Hız);
            bisiklet.LastikBoy = 23;
            Console.WriteLine(bisiklet.LastikBoy);
            bisiklet.DireksiyonCesit = "düz";
            Console.WriteLine(bisiklet.DireksiyonCesit);

            Bisiklet bisiklet2 = new Bisiklet();
            bisiklet2.Renk = "siyah";
            Console.WriteLine(bisiklet2.Renk);
            bisiklet2.Hız = 200;
            Console.WriteLine(bisiklet2.Hız);
            bisiklet2.LastikBoy = 24;
            Console.WriteLine(bisiklet2.LastikBoy);
            bisiklet2.DireksiyonCesit = "oval";
            Console.WriteLine(bisiklet2.DireksiyonCesit);

            Bisiklet bisiklet3 = new Bisiklet();
            bisiklet3.Renk = "Mor";
            Console.WriteLine(bisiklet3.Renk);
            bisiklet3.Hız = 300;
            Console.WriteLine(bisiklet3.Hız);
            bisiklet3.LastikBoy = 21;
            Console.WriteLine(bisiklet3.LastikBoy);
            bisiklet3.DireksiyonCesit = "motorcu";
            Console.WriteLine(bisiklet3.DireksiyonCesit);

        }
    ----------------------------------------------------------------
      static void Main(string[] args)
        {

            Ulke ulke = new Ulke();
            Ulke ulke2=new Ulke();
            Ulke ulke3=new Ulke();
            ulke.Baskent = "Ankara";
            ulke.adı = "Turkiye";
            ulke.Dili = "Turkce";
            ulke.ParaBirimi = "Tl";
            ulke.Nufusu = 840000;
            Console.WriteLine("**********************");
            ulke2.Baskent = "Londra";
            ulke2.ParaBirimi = "İngiliz Sterlini";
            ulke2.adı = "Birleşik Krallık";
            ulke2.Dili = "İngilizce";
            ulke2.Nufusu = 559800;
            Console.WriteLine("**********************");
            ulke3.Baskent = "Washington, DC";
            ulke3.adı = "Amerika Birleşik Devletleri ";
            ulke3.Dili = "İngilizce";
            ulke2.ParaBirimi = "Dolar";
            ulke3.Nufusu = 3319000;
            Console.WriteLine("**********************");
            Console.WriteLine("");
            Ulke ülke4 = new Ulke();

            Console.WriteLine(ulke.Nufusu + "\t" + ulke.Baskent + "\t" + ulke.Dili + "\t\t" + ulke.ParaBirimi + "\t\t" + ulke.adı);
            Console.WriteLine(ulke2.Nufusu + "\t" + ulke2.Baskent + "\t" + ulke2.Dili + "\t\t" + ulke2.ParaBirimi + "\t\t" + ulke2.adı);
            Console.WriteLine(ulke3.Nufusu + "\t" + ulke3.Baskent + "\t" + ulke3.Dili + "\t\t" + ulke3.ParaBirimi + "\t\t" + ulke3.adı);
            ülke4.Kurulus = 1900;
            Console.WriteLine(ülke4.ülkeyasihesapla());
            Console.ReadLine();

        }
    ----------------------------
    2. cvp
      Ulkeler a= new Ulkeler();
            Ulkeler b = new Ulkeler();

            a.ülkeadı = "Türkiye";
            a.dil = "Türkçe";
            a.nüfus = "85,04 milyon";
            a.parabirimi = "TL";
            a.din = "İslam";
            a.bölge = "Asya";
            a.bayrakrengi = "Kırmızı - Beyaz";

            b.ülkeadı = "USA";
            b.dil = "İngilizce";
            b.nüfus = "331,9 milyon";
            b.parabirimi = "Dolar";
            b.din = "Protestan";
            b.bölge = "Amerika";
            b.bayrakrengi = "Kırmızı - Beyaz - Mavi";




            Console.WriteLine("Ülke adını yazınız");
            string ülkeadı=Console.ReadLine();

            if (ülkeadı==a.ülkeadı)
            {
                Console.WriteLine(a.ülkeadı + "\n" + a.din + "\n" + a.dil + "\n" + a.nüfus + "\n" + a.parabirimi + "\n" + a.bayrakrengi + "\n" + a.bölge);
            }
            else if (ülkeadı == b.ülkeadı)
            {
                Console.WriteLine(b.ülkeadı + "\n" + b.din + "\n" + b.dil + "\n" + b.nüfus + "\n" + b.parabirimi + "\n" + b.bayrakrengi + "\n" + b.bölge);
            }

        ------------------------------------------------------------
    static void Main(string[] args)
        {
            Evhalkı_ annem = new Evhalkı_();
            annem.Ad = "Hamdiye";
            annem.DogumYili = 1960;
            annem.Meslek = "Ev Hanımı";
            annem.GozRengi = "Kahverengi";

            Evhalkı_ babam = new Evhalkı_();
            babam.Ad = "Hayrettin";
            babam.DogumYili = 1957;
            babam.Meslek = "Emekli";
            babam.GozRengi = "Kahverengi";

            Evhalkı_ buyukkardesim = new Evhalkı_();
            buyukkardesim.Ad = "Elif";
            buyukkardesim.DogumYili = 1997;
            buyukkardesim.Meslek = "Öğrenci";
            buyukkardesim.GozRengi = "Siyah";

            Evhalkı_ kucukkardesim = new Evhalkı_();
            kucukkardesim.Ad = "Ahmet";
            kucukkardesim.DogumYili = 2009;
            kucukkardesim.Meslek = "Öğrenci";
            kucukkardesim.GozRengi = "Kahverengi";

            Evhalkı_ ortancakardes = new Evhalkı_();
            ortancakardes.Ad = "Yahya";
            ortancakardes.DogumYili = 1999;
            ortancakardes.Meslek = "Öğrenci";
            ortancakardes.GozRengi = "Siyah";

        label:
            Console.WriteLine("Kimin Özellikleri isteniyor ? \nAnne\t       = 1\nBaba\t       = 2\nBüyük Kardes   = 3\nOrtanca Kardeş = 4\nKüçük Kardeş   = 5");
            int islem = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (islem)
            {
                case 1:
                    annem.OzellikleriYaz("Anne");
                    break;
                case 2:
                    babam.OzellikleriYaz("Baba");
                    break;
                case 3:
                    buyukkardesim.OzellikleriYaz("Büyük Kardeş");
                    break;
                case 4:
                    ortancakardes.OzellikleriYaz("Ortanca Kardeş");
                    break;
                case 5:
                    kucukkardesim.OzellikleriYaz("Kücük Kardeş");
                    break;
                default:
                    Console.WriteLine("Yanlış giriş");
                    goto label;
            }
            Console.ReadKey();
        }



        class Evhalkı_
        {
            public string Ad;
            public int DogumYili;
            public string Meslek;
            public string GozRengi;

            public int yas()
            {
                return DateTime.Now.Year - DogumYili;
            }
            public void OzellikleriYaz(string str)
            {
                Console.WriteLine(str);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Ad       = " + Ad);
                Console.WriteLine("Yaşı     = " + yas());
                Console.WriteLine("Mesleği  = " + Meslek);
                Console.WriteLine("GözRengi = " + GozRengi);
                Console.WriteLine("-----------------------");
            }
        }


     */


    {
        static void Main(string[] args)
        {
            kitap k = new kitap();
            Ogrenci o= new Ogrenci();
           

        }

      
     

    }
}
