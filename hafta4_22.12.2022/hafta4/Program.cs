using System;

namespace hafta4
{
    internal class Program
    {
        /*Console.WriteLine("Hello World!");
             ----------------------------------------------------------------------------
            -Foreach
            ----------------------------------------------------------------------------
            soru 
             foreach  şehileri çekin 
            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya",
                "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa",
                "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan",
                "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta",
                "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir",
                "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş",
                "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ",
                "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray",
                "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova",
                "Karabük", "Kilis", "Osmaniye", "Düzce" };
            foreach (string eleman in sehirler)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
             ----------------------------------------------------------------------------
            *Methodlar
            *void (işlemleri burda yap demek )
             static void Main(string[] args)
        {
            
            İsmimiYaz();
            Console.Read();
             static void İsmimiYaz()
            }
        {
            Console.WriteLine("Gizem");
        }
            ----------------------------------------------------------------------------
               sayiiste();
            
        }
        static void sayiiste()
        {
            Console.WriteLine("sayi gir");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi gir2");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

        }


            soru 
             ----------------------------------------------------------------------------
            toplama();
           
            
        }
        
        static void toplama()
        {
            Console.WriteLine("sayi gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi gir2");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam   = sayi + sayi2;
            Console.WriteLine(toplam);



        }
         ----------------------------------------------------------------------
            soru 
        adet ve mesaj isteyip ekrana yazdırıcak methodla
         static void Main(string[] args)
        {


            mesaj();
            
        }
        
        static void mesaj()
        {
            Console.WriteLine("adet gir");
            int adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mesaj girin");
           string mesaj = Console.ReadLine();
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(mesaj);
            }
              

        }
        ----------------------------------------------------------------------
         soru 
        üçgen alanını bul
      #region ucgen 
        static void Main(string[] args)
        {


            ucgenalan();
            
        }
        
        static void ucgenalan()
        {
            Console.WriteLine("taban alan giriniz");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yükseklik giriniz");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            int toplamAlan = (taban * yukseklik / 2);
           Console.WriteLine(toplamAlan);
              

        }
        #endregion

        ---------------------------------------------------------------------
        Soru
        Karealani- silindirin hacmi -daire alanı

        static void Main(string[] args)
        {


            Kareninalan();
            Silindir();
            daire();
            Console.Read();
            
        }
        
        static void Kareninalan()
        {
            Console.WriteLine("taban alan giriniz");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yükseklik giriniz");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            int toplamAlan = (taban * yukseklik);
           Console.WriteLine(toplamAlan);
              

        }
        #endregion

        #region Silindir 
       

        static void Silindir()
        {
            double tabana, tabanc, yukseklik, secim, r;
            Console.WriteLine("silindirin taban alan giriniz");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yükseklik giriniz");
            yukseklik = Convert.ToInt32(Console.ReadLine());
            tabanc= 2*Math.PI *r;
            double tbnc=Math.Floor(tabanc);
            tabana = Math.PI * r * r;
            double tbna = Math.Floor(tabana);
            Console.WriteLine("Silindir alan1 hacmi2");
            secim=Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Silindir alanı"+ (tbnc*yukseklik));
                    break;
                case 2:
                    Console.WriteLine("Silindir hacmi" +(tbna*yukseklik));
                
                    break;
            }
        }
        #endregion

        #region Daire 


        static void daire()
        {
            Console.WriteLine("Daire Alan Hesaplanması"); 
            Console.Write("Lütfen Alan giriniz:");
            int alan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yükseliği giriniz"); 
            int yükselik = Convert.ToInt32(Console.ReadLine());
            int toplamAlan = (alan * yükselik); 
            Console.WriteLine("Daire Alan: " + toplamAlan); 

        }
          ---------------------------------------------------------------------
        Soru
        girilen sayını tekmi çiftmi yazdığını yapan method
         static void Main(string[] args)
        {
            Girilensayi();
            Console.Read();
        }
        
        static void Girilensayi()
        {
            Console.WriteLine("biz sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2==0)
            {
                Console.WriteLine("Sayi çifttir");
            }
            else
            {
                Console.WriteLine("Sayi tektir");
            }
        }



        -----------------------------------------------------------------------------
        soru
        
            int[] takımlar = new int[8];
            for (int i = 0; i < 8; i++)
            {
                takımlar[i] = i + 1;
            }
            int sayac = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0;
            Random ran = new Random();
            int[] dizi2 = new int[takımlar.Length / 2];
            int[] dizi3 = new int[takımlar.Length / 2];
            for (int i = 0; i < takımlar.Length;)
            {
                int eleman = ran.Next(1, 9);
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (eleman == dizi2[j])
                    {
                        sayac++;
                    }
                    if (eleman == dizi3[j])
                    {
                        sayac++;
                    }
                }
                if (sayac2 % 2 == 1)
                {
                    if (sayac == 0)
                    {
                        dizi2[sayac3] = eleman;
                        i++;
                        sayac3++;
                        sayac2++;
                    }
                }
                else if (sayac2 % 2 == 0)
                {
                    if (sayac == 0)
                    {
                        dizi3[sayac4] = eleman;
                        i++;
                        sayac4++;
                        sayac2++;
                    }
                }
                sayac = 0;
            }
            Console.WriteLine("İlk Turnuva Maçları\n----------------------");
            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.WriteLine("Takım" + dizi2[i] + " Vs " + "Takım" + dizi3[i]);
            }
            for (int i = 0; i < dizi2.Length; i++)
            {
                int mac = ran.Next(1, 3);
                if (mac == 1)
                {
                    dizi2[i] = 0;
                }
                else if (mac == 2)
                {
                    dizi3[i] = 0;
                }
            }
            int[] dizi4 = new int[4];
            int sayac5 = 0;
            Console.WriteLine("Maçlar Başlasın mı ?");
            Console.Read();
            Console.WriteLine("!!!!!...Turnuva 1 Başlıyor...!!!!");
            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.Write((i + 1) + ". Maç Yapılıyor.");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".\n");
                System.Threading.Thread.Sleep(1000);
                if (dizi2[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi2[i]);
                    dizi4[sayac5] = dizi2[i];
                    sayac5++;
                }
                else if (dizi3[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi3[i]);
                    dizi4[sayac5] = dizi3[i];
                    sayac5++;
                }
            }

            int[] dizi5 = new int[2];
            int[] dizi6 = new int[2];
            sayac4 = 0;
            sayac3 = 0;
            sayac5 = 0;
            sayac2 = 0;
            for (int i = 0; i < 4;)
            {
                int eleman = ran.Next(0, 4);
                for (int j = 0; j < dizi5.Length; j++)
                {
                    if (dizi4[eleman] == dizi5[j])
                    {
                        sayac++;
                    }
                    if (dizi4[eleman] == dizi6[j])
                    {
                        sayac++;
                    }
                }
                if (sayac2 % 2 == 1)
                {
                    if (sayac == 0)
                    {
                        dizi5[sayac3] = dizi4[eleman];
                        i++;
                        sayac3++;
                        sayac2++;
                    }
                }
                else if (sayac2 % 2 == 0)
                {
                    if (sayac == 0)
                    {
                        dizi6[sayac4] = dizi4[eleman];
                        i++;
                        sayac4++;
                        sayac2++;
                    }
                }
                sayac = 0;
            }
            Console.WriteLine("5 Sn Sonra 1. Tur Turnuva Maçları Bitiyor");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("2. Turnuva Maçları\n----------------------");
            for (int i = 0; i < dizi5.Length; i++)
            {
                Console.WriteLine("Takım" + dizi5[i] + " Vs " + "Takım" + dizi6[i]);
            }
            for (int i = 0; i < dizi6.Length; i++)
            {
                int mac = ran.Next(1, 2);
                if (mac == 1)
                {
                    dizi5[i] = 0;
                }
                else if (mac == 2)
                {
                    dizi6[i] = 0;
                }
            }
            Console.WriteLine();
            sayac5 = 0;
            int[] dizi7 = new int[2];
            Console.WriteLine("!!!!!...Turnuva 2 Başlıyor...!!!!");
            Console.WriteLine("5 Sn Sonra 2. Turnuva Maçları Başlıyor");
            System.Threading.Thread.Sleep(5000);
            for (int i = 0; i < dizi5.Length; i++)
            {
                Console.Write((i + 1) + ". Maç Yapılıyor.");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".\n");
                System.Threading.Thread.Sleep(1000);
                if (dizi2[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi5[i]);
                    dizi7[sayac5] = dizi5[i];
                    sayac5++;
                }
                else if (dizi3[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi6[i]);
                    dizi7[sayac5] = dizi6[i];
                    sayac5++;
                }
            }
            Console.WriteLine("!!!! Final !!!!\n----------------");
            Console.WriteLine("Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            Console.WriteLine("Final 5 Sn sonra Başlıyacak ?");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("!!!!!...Final Başlıyor...!!!!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Maç Yapılıyor " + "Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            int mac2 = ran.Next(3, 5);
            if (mac2 == 3)
            {
                Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[0]);
            }
            else if (mac2 == 4)
            {
                Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[1]);
            }
            Console.ReadKey();
        ----------------------------------------------------------------------------------
        soru
        static void Main(string[] args)
        {
            usalma();
            karekök();
            mutlak();
            Console.Read();
        }
        // usalma -mutlak- sinus -karekök
        static void usalma()
        {
            int sonuc = 0;
            Console.WriteLine("birinci giriniz");
            int tabansayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci giriniz");
            int kuvet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < kuvet; i++)
            {
                sonuc = sonuc * tabansayi;
            }
            Console.WriteLine("Tabanı {0} ve kuvveti {1} olan sayının değeri = {2}", tabansayi, kuvet, sonuc);

            Console.ReadLine();

        }
        #endregion
        static void karekök()
        {
             Console.WriteLine("Bir sayı girin");
            double sayi = Convert.ToDouble(Console.ReadLine());
            long i, n = (long)sayi, t;
            double r = sayi;
            for (i = 0; i < n; i++)
            {
                r = (r + (sayi / r)) * 0.5;
                t = (long)r;
                if ((t * t) < t)
                    break;
            }
                     
            Console.WriteLine("Sayının Karekökü =" + r.ToString());
            Console.ReadLine();

        }
        static void mutlak()
        {
            Console.WriteLine("Bir sayı girin");
           
            int mutlak = Convert.ToInt32(Console.ReadLine());
            if (mutlak < 0)
            {
                Console.WriteLine("sonuc = " + mutlak * (-1));
            }
            else
            {
                Console.WriteLine("sonuc = " + mutlak);
            }
           

        }
        -----------------------------------------------------------------------
        soru
          static void Main(string[] args)
        {
            isim("gizem");
           
            Console.Read();
        }
        // usalma -mutlak- sinus -karekök
        static void isim(string f)
        {
           
         Console.WriteLine(f);  
        }

        -------------------------------------------------------------------

        soru
        static void yaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
        static void Main(string[] args)
        {
            //sayiiste();
            //toplama();
            // iste();
            Console.WriteLine("yaz bişi");

            yaz(Console.ReadLine());

        }
        -------------------------------------------------------------------
        soru
           static void Main(string[] args)
        {
            isim("");
            Console.WriteLine("bir mesaj gönderin");
            Console.Read();
        }
       
        static void isim(string f)
        {
           
         Console.WriteLine(f);  
        }
            */
        #region methot

        #endregion


    }
}
