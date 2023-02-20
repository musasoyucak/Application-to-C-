
using System;

namespace Hafta4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             DIZILER[]
            --------------------------------------------------------------------
            Soru
            kullanıcının girdiği 5 hücreleri veri girsin
            int[] sayi = new int[5] ;
            
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine("5 adet sayi giriniz");
                sayi[i] = Convert.ToInt32(Console.ReadLine()) ;
            }
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]);
              
            }--------------------------------------------------------------------
            Soru
            kullanıcı çiçekçiden çiçek istesin 5 adet farklı çiçek
            string[] cicek = new string[5];

            for (int i = 0; i < cicek.Length; i++)
            {
                Console.WriteLine("5 çiçek giriniz");
                cicek[i] = Console.ReadLine();
            }
            for (int i = 0; i < cicek.Length; i++)
            {
                Console.WriteLine(cicek[i]);

            }
            --------------------------------------------------------------------
              Soru
            Sınıftaki  ögrencileri diziye atıyarak random seçme programı
          
            string[] isim = new string[] {"didem","ferhat", "burak", "ahmet", "H.ibrahim", "burak ender", "muzaffer", "oğuzhan", "gözde", "gizem", "özay", "musa", "ibrahim", "alper", "rüveyda", "vedat","Ugur" };

           Random rnd = new Random();
            int sayi= rnd.Next(0,18);
            Console.WriteLine(isim[sayi]);
             --------------------------------------------------------------------
              Soru
             lig katımı yap   randomla eşleştir 18 alt alta sırala
             string[] takimlar = new string[] { "Fenerbahçe", "Galatasaray", "Beşiktaş", "Trabzon", "Başakşehir", "Gençlerbirliği", "Adana", "Kayseri", "Konya", "Alanya", "Gaziantep", "Antalya", "Giresun", "Kasımpaşa", "Hatay", "Karagümrük", "Sivas","İstanbul" };

            Random rnd = new Random();
            
            for (int i = 0; i < takimlar.Length; i++)
            {
                int sayi = rnd.Next(0,100);
                Console.WriteLine(takimlar[i] +"\t"+sayi);
            }
             --------------------------------------------------------------------
              Soru
             lig katımı yap   randomla eşleştir 18 alt alta sırala ve şampiyonu yazdır
             string[] takimlar = new string[] { "Fenerbahçe", "Galatasaray", "Beşiktaş", "Trabzon", "Başakşehir", "Gençlerbirliği", "Adana", "Kayseri", "Konya", "Alanya", "Gaziantep", "Antalya", "Giresun", "Kasımpaşa", "Hatay", "Karagümrük", "Sivas","İstanbul" };

            Random rnd = new Random();
            int enb = 0;
            int s=0;
            for (int i = 0; i < takimlar.Length; i++)
            {
               
                int sayi = rnd.Next(0,100);
                Console.WriteLine(takimlar[i] +"\t"+sayi);
                if (enb<sayi)
                {
                    enb = sayi;
                    
                    s = i;
                    
                }
                
            }
            Console.WriteLine("Sampiyon "+takimlar[s]+enb);
            --------------------------------------------------------------------
              Soru
            100 hücre random deger ata çift ve tek degerlerin toplamı aralarındaki 
            farkı bulucaz alabilceği degerler 0-100 arasında
            int tek=0,cift=0,tektoplam = 0,Ciftoplam = 0;

            int[] sayilar = new int[100];
            Random random = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(100);
                //Console.WriteLine(i+". sayi"+ sayilar[i]);
                if (sayilar[i] %2 ==0)
                {
                    Console.WriteLine(sayilar[i]+"\t Çifttir");
                    cift++;
                    Ciftoplam = Ciftoplam + sayilar[i];
                }
                else
                {
                    Console.WriteLine(sayilar[i] + "\t Tektir");
                    tek++;
                    tektoplam = tektoplam + sayilar[i];
                    
                }
            }
            Console.WriteLine("sonuc="+(tektoplam-Ciftoplam));

             --------------------------------------------------------------------
              Soru
            ismi  diziye at tersten yazdırma
             string[] isim = new string[] { "g","i","z","e","m" };
            
            for (int i = isim.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(isim[i]);
            }
             --------------------------------------------------------------------
              Soru
            
            string a = "gizem";
            Console.WriteLine(a[3]);
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
             --------------------------------------------------------------------
              Soru
            Kullanıcı herhangi bir cümle girsin son karekterini versin

            Console.WriteLine("bir cümle yazınınız.  ");
            string metin =Console.ReadLine();
            Console.WriteLine(metin[metin.Length-1]);
            --------------------------------------------------------------------
             Soru:  Elemanları tam sayı olan bir A dizisinin eleman sayısını
            kullanıcı rastgele sayılar atayan, sonra elemanlarının aritmetik 
            ortalamasını hesaplayan ve elemanlarından kaç tanesinin bu ortalamadan 
            büyük ve küçük olduğunu sayan program.
                        double toplam = 0, s1 = 0, s2 = 0;
            Console.WriteLine("Dizi kaç elemanlı olsun= ");
            int dizi = Convert.ToInt32(Console.ReadLine()); 
            int[] diziler = new int[dizi]; 
            Random rnd = new Random();
            for (int i = 0; i < diziler.Length; i++) 
            { diziler[i] = rnd.Next(1, dizi); toplam = toplam + diziler[i]; 
                Console.WriteLine(diziler[i]); }
            for (int j = 0; j < diziler.Length; j++) { if (diziler[j] <= (toplam / dizi)) { s1++; } else { s2++; } }
            Console.WriteLine("Ortalama=" + (toplam / dizi));
            Console.WriteLine("Ortalamanın altında kalan eleman sayısı= " + s1); 
            Console.WriteLine("Ortalamanın üstünde kalan eleman sayısı= " + s2);

             --------------------------------------------------------------------
             Soru: 
            şehir sorusu
            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
                Random random = new Random();

                string secilenSehir = sehirler[random.Next(0, sehirler.Length - 1)];
                int hak = 10;
               
               
                char[] yildizlar = new char[secilenSehir.Length];

                for (int i = 0; i < yildizlar.Length; i++)
                {
                    yildizlar[i] = '*';
                    Console.Write('*');
                }
                Console.WriteLine();

                while (true)
                {

                    Console.WriteLine("Kalan Hak:{0}", hak);
                    Console.Write("Bir harf girin   :");
                    char harf = Convert.ToChar(Console.ReadLine());

                    bool referans = false;
                    int kalanKelime = 0;
                    for (int i = 0; i < secilenSehir.Length; i++)
                    {
                        if (secilenSehir[i] == harf)
                        {
                            yildizlar[i] = harf;
                            referans = true;
                        }
                        if (yildizlar[i] == '*')
                        {
                            kalanKelime++;
                        }
                        Console.Write(yildizlar[i]);
                    }
                    Console.WriteLine();

                    if (kalanKelime == 0)
                    {
                        Console.WriteLine("Tebrikler...");
                        break;
                    }

                    if (referans == false)
                    {
                        hak--;
                    }

                    if (hak == 0)
                    {
                        Console.WriteLine("Üzgünüm kaybettiniz.");
                        break;
                    }

                    Console.WriteLine("******");
                } 

                Console.Write("[-- {0} --]", secilenSehir);
                Console.ReadLine();
            }
            */
            int toplam = 0;
            Console.WriteLine("sayi girelim");
            int sayi= Convert.ToInt32(Console.ReadLine());
           

            int[] tamsayi = new int[sayi];
            Random random = new Random();

            for (int i = 0; i < tamsayi.Length; i++)
            {
                tamsayi[i] = random.Next();
                Console.WriteLine(tamsayi[i]);

            }






        }
    }
}
