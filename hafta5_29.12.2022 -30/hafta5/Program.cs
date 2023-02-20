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
    ------------------------------------------------------------------------------------------
      //öğrenci classı 


    internal class ogrenci
    {
        public int sınıf;
        public string isim;
        public int num;

        public void yazdır()
        {
            Console.WriteLine("Öğrencinin adı = " + isim+"\tÖğrencinin sınıfı = "+sınıf+"\tÖğrencinin numarası = "+num);
        }
    }

//kitap classı

 internal class kitap
    {
        public string isim;
        public string yazar;
        public int sayfa;


        public void yazdır()
        {
            Console.WriteLine("Kitabın adı = " + isim + "\tYazarın adı = " + yazar + "\tKitabın sayfa sayısı = " + sayfa);
        }


    }


//main fonksiyon

static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.sınıf = 5;
            ogrenci1.isim = "Alper";
            ogrenci1.num = 15;
            

            ogrenci ogrenci2 = new ogrenci();
            ogrenci2.sınıf = 7;
            ogrenci2.isim = "İbrahim";
            ogrenci2.num = 18;

            ogrenci ogrenci3 = new ogrenci();
            ogrenci3.sınıf = 6;
            ogrenci3.isim = "Vedat";
            ogrenci3.num = 110;

            kitap kitap1 = new kitap();
            kitap1.isim = "Mecburiyet";
            kitap1.yazar = "Stefan Zweig";
            kitap1.sayfa = 70;

            kitap kitap2 = new kitap();
            kitap2.isim = "Beyoğlunun En Güzel Abisi";
            kitap2.yazar = "Ahmet Ümit";
            kitap2.sayfa = 300;

            kitap kitap3 = new kitap();
            kitap3.isim = "Küçük Ağa";
            kitap3.yazar = "Tarık Buğra";
            kitap3.sayfa = 480;

            k:
            Console.WriteLine("Öğrenci seçiniz ..... 1 Öğrenci1   2 Öğrenci2   3 Öğrenci3");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Kitap seçiniz ..... 1 Kitap1   2 Kitap2   3 Kitap3");
            int y = int.Parse(Console.ReadLine());

            if (x == 1 && y == 1)
            {
                Console.WriteLine("1.ÖĞRENCİ 1.KİTABI ALDI");
                ogrenci1.yazdır();
                kitap1.yazdır();
            }
            else if (x == 1 && y == 2)
            {
                Console.WriteLine("1.ÖĞRENCİ 2.KİTABI ALDI");
                ogrenci1.yazdır();
                kitap2.yazdır();
            }
            else if (x == 1 && y == 3)
            {
                Console.WriteLine("1.ÖĞRENCİ 3.KİTABI ALDI");
                ogrenci1.yazdır();
                kitap3.yazdır();
            }
            else if (x == 2 && y == 1)
            {
                Console.WriteLine("2.ÖĞRENCİ 1.KİTABI ALDI");
                ogrenci2.yazdır();
                kitap1.yazdır();
            }
            else if (x == 2 && y == 2)
            {
                Console.WriteLine("2.ÖĞRENCİ 2.KİTABI ALDI");
                ogrenci2.yazdır();
                kitap2.yazdır();
            }
            else if (x == 2 && y == 3)
            {
                Console.WriteLine("2.ÖĞRENCİ 3.KİTABI ALDI");
                ogrenci2.yazdır();
                kitap3.yazdır();
            }
            else if (x == 3 && y == 1)
            {
                Console.WriteLine("3.ÖĞRENCİ 1.KİTABI ALDI");
                ogrenci3.yazdır();
                kitap1.yazdır();
            }
            else if (x == 3 && y == 2)
            {
                Console.WriteLine("3.ÖĞRENCİ 2.KİTABI ALDI");
                ogrenci3.yazdır();
                kitap2.yazdır();
               
            }
            else if (x == 3 && y == 3)
            {
                Console.WriteLine("3.ÖĞRENCİ 3.KİTABI ALDI");
                ogrenci3.yazdır();
                kitap3.yazdır();
                
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız");
                goto k;
            }

        }
     Cevap2 ---
      ogrenci class
       public string Ad;
        public string Soyad;
        public string Adres;
        public int OgrenciNo;
        public void OzellikleriYaz()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Ad = " + Ad);
            Console.WriteLine("SoyAdı = " + Soyad);
            Console.WriteLine("Adresi = " + Adres);
            Console.WriteLine("Öğrenci No = " + OgrenciNo);
            Console.WriteLine("-----------------------");

        }
    Kıtap class
      {
        public string Ad;
        public string Yazarı;
        public int KitapNo;

        public void kitapAl(string _Ad , string _SoyAd , int _OgrenciNo)
        {
            
            Console.WriteLine("-----------------------");
            Console.WriteLine("Kitap Adı = " + Ad);
            Console.WriteLine("Yazarı = " + Yazarı);
            Console.WriteLine("Kitap No = " + KitapNo);
            Console.WriteLine("Kitap Sahibi Adı = " + _Ad);
            Console.WriteLine("Kitap Sahibi SoyAdı = " + _SoyAd);
            Console.WriteLine("Kitap Sahibi Öğrenci No = " + _OgrenciNo);
            Console.WriteLine("-----------------------");

        }
    }
      Main

       {
            // KİTAPLAR ------------------------------------------------------
            Kitap kitap1 = new Kitap();

            kitap1.Ad = "İnce Memed";
            kitap1.KitapNo = 1;
            kitap1.Yazarı = "Yaşar Kemal";

            Kitap kitap2 = new Kitap();

            kitap2.Ad = "Tutunamayanlar";
            kitap2.KitapNo = 2;
            kitap2.Yazarı = "Oğuz Atay";

            Kitap kitap3 = new Kitap();

            kitap3.Ad = "Huzur";
            kitap3.KitapNo = 3;
            kitap3.Yazarı = "Ahmet Hamdi Tanpınar";

            // ÖĞRENCİLER ------------------------------------------------------
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.OgrenciNo = 1;
            ogrenci1.Ad = "Muzaffer";
            ogrenci1.Soyad = "Atasoy";
            ogrenci1.Adres = "İstanbul";
            Ogrenci ogrenci2 = new Ogrenci();

            ogrenci2.OgrenciNo = 2;
            ogrenci2.Ad = "Berat";
            ogrenci2.Soyad = "Atasoy";
            ogrenci2.Adres = "İstanbul";
            Ogrenci ogrenci3 = new Ogrenci();

            ogrenci3.OgrenciNo = 3;
            ogrenci3.Ad = "Ahmet";
            ogrenci3.Soyad = "Kara";
            ogrenci3.Adres = "Antalya";

            Console.WriteLine("Hangi Öğrenci ? \nÖğrenci 1 = 1\nÖğrenci 2 = 2\nÖğrenci 3 = 3");
            int islem = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (islem)
            {
                case 1:
                    ogrenci1.OzellikleriYaz();
                    Console.WriteLine($"Hangi Kitabı Alacak ? \n{kitap1.Ad} = 1\n{kitap2.Ad}  = 2\n{kitap3.Ad} = 3");
                    int islem2 = Convert.ToInt32(Console.ReadLine());
                    switch (islem2)
                    {
                        case 1:
                            Console.Clear();
                            kitap1.kitapAl(ogrenci1.Ad, ogrenci1.Soyad, ogrenci1.OgrenciNo);
                            break;
                        case 2:
                            Console.Clear();
                            kitap2.kitapAl(ogrenci1.Ad, ogrenci1.Soyad, ogrenci1.OgrenciNo);
                            break;
                        case 3:
                            Console.Clear();
                            kitap3.kitapAl(ogrenci1.Ad, ogrenci1.Soyad, ogrenci1.OgrenciNo);
                            break;
                    }


                    break;
                case 2:
                    ogrenci2.OzellikleriYaz();
                    Console.WriteLine($"Hangi Kitabı Alacak ? \n{kitap1.Ad} = 1\n{kitap2.Ad}  = 2\n{kitap3.Ad} = 3");
                    int islem3 = Convert.ToInt32(Console.ReadLine());
                    switch (islem3)
                    {
                        case 1:
                            Console.Clear();
                            kitap1.kitapAl(ogrenci2.Ad, ogrenci2.Soyad, ogrenci2.OgrenciNo);
                            break;
                        case 2:
                            Console.Clear();
                            kitap2.kitapAl(ogrenci2.Ad, ogrenci2.Soyad, ogrenci2.OgrenciNo);
                            break;
                        case 3:
                            Console.Clear();
                            kitap3.kitapAl(ogrenci2.Ad, ogrenci2.Soyad, ogrenci2.OgrenciNo);
                            break;
                    }
                    break;
                case 3:
                    ogrenci3.OzellikleriYaz();
                    Console.WriteLine($"Hangi Kitabı Alacak ? \n{kitap1.Ad} = 1\n{kitap2.Ad}  = 2\n{kitap3.Ad} = 3");
                    int islem4 = Convert.ToInt32(Console.ReadLine());
                    switch (islem4)
                    {
                        case 1:
                            Console.Clear();
                            kitap1.kitapAl(ogrenci3.Ad, ogrenci3.Soyad, ogrenci3.OgrenciNo);
                            break;
                        case 2:
                            Console.Clear();
                            kitap2.kitapAl(ogrenci3.Ad, ogrenci3.Soyad, ogrenci3.OgrenciNo);
                            break;
                        case 3:
                            Console.Clear();
                            kitap3.kitapAl(ogrenci3.Ad, ogrenci3.Soyad, ogrenci3.OgrenciNo);
                            break;
                    }
                    break;
            }



        }
     cvp 3----------------------
        static void Main(string[] args)
        {
            kitap k = new kitap();
            kitap k1 = new kitap();
            kitap k2 = new kitap();
            kitap k3 = new kitap();
            k.Adı = "Bir idam mahkumunun son günü";
            k.Yazarı = "Viktor hugo";
            k.Sayfa = 150;
            k.Turu = "Roman, Kurgu, Romantizm";
            k.Ciltno = 15;
            Console.WriteLine("*********************");
            k1.Adı = "Sefiller";
            k1.Yazarı = "Viktor hugo";
            k1.Sayfa = 160;
            k1.Turu = "Roman, Trajedi, Tarihî Kurgu, Epik, Epik Kurgu";
            k1.Ciltno = 16;
            Console.WriteLine("*********************");
            k2.Adı = "Notre Dame'ın Kamburu";
            k2.Yazarı = "Viktor hugo";
            k2.Sayfa = 180;
            k2.Turu = "Roman, Romantizm, Drama, Aşk Romanı, Gotik Kurgu, Saga, Tarihî Kurgu, Şövalye Romansı, Biyografik Kurgu";
            k2.Ciltno = 17;
            Console.WriteLine("*********************");
            k3.Adı = "Hamlet";
            k3.Yazarı = "William Shakespeare";
            k3.Sayfa = 200;
            k3.Turu = "Trajedi, Drama";
            k3.Ciltno = 18;
            Ogrenci o= new Ogrenci();
            Ogrenci o1 = new Ogrenci();
            Ogrenci o2 = new Ogrenci();
            Ogrenci o3 = new Ogrenci();
            o.Adı = "Gizem";
            o.Soyadı = "Topaloglu";
            o.Tc = 12345678911;
            o.Numarası = 1;
            Console.WriteLine("*********************");
            o2.Adı = "Gozde";
            o2.Soyadı = "Bulut";
            o2.Tc = 12345678912;
            o2.Numarası = 2;
            Console.WriteLine("*********************");
            o3.Adı = "Ozay";
            o3.Soyadı = "Demirci";
            o3.Tc = 12345678913;
            o3.Numarası = 3;
            Console.WriteLine("*********************");
            o1.Adı = "Didem";
            o1.Soyadı = "Yavuz";
            o1.Tc = 12345678914;
            o1.Numarası = 4;


        }
    ---------- cvp 4
      namespace CLASSS
{
    internal class ogrenci
    {

        public string ogrenciadi;
        public string sinif;
    }
}

namespace CLASSS
{
    internal class kitap
    {

        public string kitapad;
        public string yazar;
        public string tur;

    }
}
ogrenci bir = new ogrenci();
            ogrenci iki = new ogrenci();

            bir.ogrenciadi = "Ali";
            bir.sinif = "1A";

            iki.ogrenciadi = "Sıla";
            iki.sinif = "2A";

            kitap a = new kitap();
            kitap b = new kitap();

            a.kitapad = "Notre Dame'ın Kamburu";
            a.yazar = "VICTOR HUGO";
            a.tur = "ROMAN";

            b.kitapad = "Sefiller";
            b.yazar = "VICTOR HUGO";
            b.tur = "ROMAN";

            Console.WriteLine("öğrenci id sini girin");
            int ogrsecim = int.Parse(Console.ReadLine());

            Console.WriteLine("Kitap seçimi yapınız");
            int kitapsecim = int.Parse(Console.ReadLine());

            if (ogrsecim == 1 & kitapsecim == 1)
            {
                Console.WriteLine(bir.ogrenciadi + " " + bir.sinif + " " + a.kitapad + " " + a.yazar + " " + a.tur);
            }

            else if (ogrsecim == 1 & kitapsecim == 2)
            {
                Console.WriteLine(bir.ogrenciadi + " " + bir.sinif + " " + b.kitapad + " " + b.yazar + " " + b.tur);
            }
            else if (ogrsecim == 2 & kitapsecim == 1)
            {
                Console.WriteLine(iki.ogrenciadi + " " + iki.sinif + " " + a.kitapad + " " + a.yazar + " " + a.tur);
            }
            else if (ogrsecim == 2 & kitapsecim == 2)
            {
                Console.WriteLine(iki.ogrenciadi + " " + iki.sinif + " " + b.kitapad + " " + b.yazar + " " + b.tur);
            }
    ----------------------------------------------------------
    internal class Personel
    {
        public Personel() 
        {

        }

        public string adSoyad;
        public int maas;
        public string departman;
        public string kurum;

        public void mesai(int gun)
        {
            int mesai = maas / 22;
            int mMaas = maas + mesai * gun;
            Console.WriteLine($"Personel adı : {adSoyad}\nKurum : {kurum}\nDepartman : {departman}\nMesai eklenmiş maaş : "+mMaas);
            Console.WriteLine("--------------------");
        }
[18:15]
Personel personel2 = new Personel();
            personel2.adSoyad = "Muzaffer";
            personel2.kurum = "Üsküdar Üniversitesi";
            personel2.departman = "İK";
            personel2.maas = 20000;
            personel2.mesai(5);
      -----------------------------------------------------------------------------------------------
       static void Main(string[] args)
        {
            Personel p = new Personel();
            p.Ad = "Gizem";
            p.Soyad = "Cakan";
            p.maas = 100000;
            p.Bolum = "Bilgi Işlem";
            p.Calıstigibolum = "IT Mudur";
            p.Kurum = "Ford";
            Personel p1 = new Personel();
            p1.Ad = "Gozde";
            p1.Soyad = "bulut";
            p1.maas = 60000;
            p1.Bolum = "Bilgi Işlem";
            p1.Calıstigibolum = "Devoloper";
            p1.Kurum = "Ford";
            Personel p2 = new Personel();
            p2.Ad = "Didem";
            p2.Soyad = "Yavuz";
            p2.maas = 50000;
            p2.Bolum = "Bilgi Işlem";
            p2.Calıstigibolum = "Personel müdürü";
            p2.Kurum = "Ford";
            Personel p3 = new Personel();
            p3.Ad = "Rüveyda";
            p3.Soyad = "Kemik";
            p3.maas = 80000;
            p3.Bolum = "Bilgi Işlem";
            p3.Calıstigibolum = "Uretim Müdürü";
            p3.Kurum = "Ford";

            Personel p4 = new Personel(DateTime.Now);
            Console.WriteLine(p4.Isegiris);


            //Console.WriteLine("Mesai ücreti hesaplayacağınız personeli seçiniz");
            //Console.WriteLine(p1.Ad + " için 1 tuşuna " + p2.Ad + " için 2 tuşuna " + p3.Ad + " için 3 tuşuna personel bilgilerinin tamamını görmek için 4 tuşuna basınız...");
            //int sonuc = int.Parse(Console.ReadLine()); if (sonuc == 1) { p1.mesai(); }
            //else if (sonuc == 2) { p2.mesai(); }
            //else if (sonuc == 3) { p3.mesai(); }
            //else if (sonuc == 4)
            //{
            //    Console.WriteLine("**");
            //    Console.WriteLine($"Personel adı= {p1.Ad} \n Personel departmanı= {p1.Bolum} \n Personel maaşı= {p1.maas} \n Kurum adı= {p1.Kurum} şeklindedir.");
            //    Console.WriteLine("**");
            //    Console.WriteLine($"Personel adı= {p1.Ad} \n Personel departmanı= {p1.Bolum} \n Personel maaşı= {p1.maas} \n Kurum adı= {p1.Kurum} şeklindedir.");
            //}


            Console.WriteLine("1 bas");
            int cevap =Convert.ToInt32(Console.ReadLine());
            if (cevap==1)
            {
                Console.WriteLine("Personelin  adı ="+ p.Ad);
                Console.WriteLine("Personelin  Maas =" + p.maas);
                Console.WriteLine("Personelin  Bolum =" + p.Bolum);
                p.mesai();
            }



        }
      
    internal class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Calıstigibolum { get; set; }
        public string Bolum { get; set; }
        public string Kurum { get; set; }
        public int maas { get; set; }
        public int mesaisaat { get; set; }
        public string Isegiris { get; set; }

        public void mesai() 
            
        {
            Console.WriteLine("Kac saaat mesai kalınmıstır ?"); 
            
            int mesaisaat = int.Parse(Console.ReadLine());
            int mesai = (maas*176)*mesaisaat;
            Console.WriteLine("Mesai ucretiniz ="+mesai);
            
        }
        public Personel()
        {
            Kurum = "Gizemm";
        }

        public Personel(string ad)
        {
            Ad = ad;
        }
        public Personel(DateTime Now)
        {
            Isegiris = Now.ToString();
        }
    }

         Normal constructer önce çalışır
         Ilgili sınıftan olusan nesne taleplerinin ilkinde tetiklenir sonrakilerde tetiklenmez
     */


    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.Ad = "Gizem";
            p.Soyad = "Cakan";
            p.maas = 100000;
            p.Bolum = "Bilgi Işlem";
            p.Calıstigibolum = "IT Mudur";
            p.Kurum = "Ford";
            Personel p1 = new Personel();
            p1.Ad = "Gozde";
            p1.Soyad = "bulut";
            p1.maas = 60000;
            p1.Bolum = "Bilgi Işlem";
            p1.Calıstigibolum = "Devoloper";
            p1.Kurum = "Ford";
            Personel p2 = new Personel();
            p2.Ad = "Didem";
            p2.Soyad = "Yavuz";
            p2.maas = 50000;
            p2.Bolum = "Bilgi Işlem";
            p2.Calıstigibolum = "Personel müdürü";
            p2.Kurum = "Ford";
            Personel p3 = new Personel();
            p3.Ad = "Rüveyda";
            p3.Soyad = "Kemik";
            p3.maas = 80000;
            p3.Bolum = "Bilgi Işlem";
            p3.Calıstigibolum = "Uretim Müdürü";
            p3.Kurum = "Ford";

            Personel p4 = new Personel(DateTime.Now);
            Console.WriteLine(p4.Isegiris);


            //Console.WriteLine("Mesai ücreti hesaplayacağınız personeli seçiniz");
            //Console.WriteLine(p1.Ad + " için 1 tuşuna " + p2.Ad + " için 2 tuşuna " + p3.Ad + " için 3 tuşuna personel bilgilerinin tamamını görmek için 4 tuşuna basınız...");
            //int sonuc = int.Parse(Console.ReadLine()); if (sonuc == 1) { p1.mesai(); }
            //else if (sonuc == 2) { p2.mesai(); }
            //else if (sonuc == 3) { p3.mesai(); }
            //else if (sonuc == 4)
            //{
            //    Console.WriteLine("**");
            //    Console.WriteLine($"Personel adı= {p1.Ad} \n Personel departmanı= {p1.Bolum} \n Personel maaşı= {p1.maas} \n Kurum adı= {p1.Kurum} şeklindedir.");
            //    Console.WriteLine("**");
            //    Console.WriteLine($"Personel adı= {p1.Ad} \n Personel departmanı= {p1.Bolum} \n Personel maaşı= {p1.maas} \n Kurum adı= {p1.Kurum} şeklindedir.");
            //}


            Console.WriteLine("1 bas");
            int cevap =Convert.ToInt32(Console.ReadLine());
            if (cevap==1)
            {
                Console.WriteLine("Personelin  adı ="+ p.Ad);
                Console.WriteLine("Personelin  Maas =" + p.maas);
                Console.WriteLine("Personelin  Bolum =" + p.Bolum);
                p.mesai();
            }



        }
    }
}
