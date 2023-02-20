using System;

namespace hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
             Girilen sayının  asal sayı olup olmaması
              int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol++;
                }
            }
            if (kontrol != 0)
            {
                Console.WriteLine("sayı asal değil");
            }
            else
            {
                Console.WriteLine("sayı asaldır");
            }
            ---------------------------------
            mükemel sayi programı 
            kendisi hariç bölenleri toplamı sayıyı veiryorsa mükemmel sayıdır
           int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
             Console.Write("Sayı Girin : ");
            int toplam = 0;
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam=toplam+i;
                }
            }
            if (toplam == 0)
            {
                Console.WriteLine(sayi +"sayı mükemel değil");
            }
            else
            {
                Console.WriteLine(sayi + "sayı mükemeldır");
            }
           
            -----------------------------------------
            iç içe FOR
            Carpım tablosu için  program
            for (int i = 1; i <= 10; i++)
            {
                for (int d = 1; d <= 10; d++)
                {
                    Console.WriteLine("{0}*{1}={2}", i,d,(d*i),"\n");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            FARKLI ÇÖZÜM
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i * j}");
                }
                Console.WriteLine("***************");
            }
            -------------------
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 1; n <= 5; n++)
                {
                    Console.Write(n + "*" + i + "=" + i * n + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------");
            for (int k = 1; k <= 10; k++)
            {
                for (int l = 6; l <= 10; l++)
                {
                    Console.Write(l + "*" + k + "=" + k * l + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            1 ile 100 arasında rastgele gelince 
            -----------------------------------------------
            Ekranda aşağıdaki ifadeyi yazdırak program
            Yıldız sayısı giriniz
            sıra sayısı giriniz
            
            Console.WriteLine("yıldız sayısı giriniz");
            int yıldız = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sıra sayısı giriniz");
            int sıra = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= yıldız; i++)
            {
                for (int a = 0; a < sıra; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                
            }
            Console.ReadKey();
            --------------------------------
            al alta üçgen yıldız
           Console.Write("Sayınızı Giriniz");
            int sayı;
            sayı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= sayı; i++)
            {
                for (int a = sayı; a > i; a--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" " + "G");
                }
                Console.WriteLine();
            }
            for (int t = 1; t <= sayı; t++)
            {
                for (int m = 1; m <= t; m++)
                {
                    Console.Write(" ");
                }
                for (int n = sayı; n > t; n--)
                {
                    Console.Write(" " + "G");
                }
                Console.WriteLine();
            }
            Console.Read();
            ------------------
            WHİLE comutu
            FOR ve if  birleşince
            1den 10 a kadar sayıları yazdır
            --------------------------------
            kullanıcıdan isim iste istediği adet kadar yazdıran program
            Console.WriteLine("isim giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("miktar giriniz");
            int sayi= Convert.ToInt32(Console.ReadLine());

            int a = 0;

            while (a<sayi)
            {
                Console.WriteLine(isim);
                a++;
            }
            -------------
            1den 50 kadar olan tek sayıları toplayıp ekrana yazdıran.
             int toplam = 0;
            int adet= 1;
            while (adet<50)
            {
                if (adet % 2==1)
                {
                    toplam = toplam + adet;
                   
                }
                adet++;
            }
            Console.WriteLine(toplam);


            ****Continue atla 
            ****break kopar
            ----------------------------------------------
            soru
            Klavyeden tek sayı girene kadar tek sayı(çift sayı girerse toplucak) giren program
            int toplam = 0;
           z:
            Console.WriteLine("Sayı giriniz");
            int sayı =Convert.ToInt32(Console.ReadLine());
            
            while (sayı%2==0)
            {
               toplam=toplam+sayı;
                goto z;
            }
            Console.WriteLine("Toplam= "+toplam);
            ------------------------------------------
            Klavyeden girilen sayıların 100  toplamı yüz olduğunda kaç sayıyla girmiş  kodu
             int a = 0, toplam=0, adet = 0;
            while (toplam<100)
            {
                Console.WriteLine("Bir sayı giriniz");
                a = Convert.ToInt32(Console.ReadLine());
                adet++;
                toplam = toplam + a;
            }
            Console.WriteLine("Toplam=100");
            Console.WriteLine("Girilen Sayı adeti {0}",adet);
            ---------------------------------------
            Soru
            klavyeden 0 100 girilen sayı kaçıncıda geldi programı 
            örğ 8 50 seferde şu kadar geldi.
            cevap1
            int a = 0, s = 0, d=0,e=0;
            Console.WriteLine("Buldurmak İstediğiniz Sayıyı Giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç Kez Bulunsun");
            int c = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            while (a<1)
            {
                s = rnd.Next(1, 101);
                e++;
                if (s==b)
                {
                    d = d + 1;
Console.WriteLine(e + ". KERE");
                }
                if (d==c)
                {
                    break;
                }
            }
            Console.ReadLine();
            **
            cevap2

             */

            Console.WriteLine("Hangi sayı girilece");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaç defa basılsın");
            int sayi2=Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            Random rand = new Random();
            int toplam = 0;
            while (true)
            {
                int uretim = rand.Next(100);
                sayac++;
                if (sayi== uretim)
                {
                    Console.WriteLine(sayac+"seferde" +uretim+"geldi");
                    toplam++;
                    if (toplam== sayi2)
                    {
                        Console.WriteLine("sonlandı");
                        break;
                    }
                }
            }



        }
    }
}
