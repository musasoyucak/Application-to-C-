using System;

namespace hafta4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Hello World!");
             
             ---------------------------------------------------------------------------
            soru boyutunu kullanıcının belirlediği bir dizi isimlerin yazıldığı bir dizi
            isimler dışarı çıksın cagırılsın
            Console.WriteLine("Bir boyut giriniz");
            int a= Convert.ToInt32(Console.ReadLine());
            string[] isim= new string[a] ;
            
            
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Bir isim yazınız");
                isim[i] = Console.ReadLine();

            }
            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i] + "" + a);
            }
            ---------------------------------------------------------------------------
            //Substring(2,1) bak
            soru
            Kullanıcının dizideki ilk karekterii bul
             Console.WriteLine("bir boyut giriniz");
            int a= Convert.ToInt32(Console.ReadLine());
            string[] isim = new string[a];
             

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("isim dizisinin"+(i+1)+"isim giriniz");
                isim[0] = Console.ReadLine();
            }
            Console.Clear();
            for (int j = 0; j < a; j++)
            {
                Console.WriteLine("isim dizisinin" + (j + 1) + "hücresi \t");
                Console.WriteLine(isim[j].Substring(2,1));
            }
            string ilk= isim[0];
            Console.WriteLine(ilk[2]);
            Console.Read();
            ---------------------------------------------------------------------------
            soru
             Girilen Random 200 tane sayı  büyük olanları yazdırıcak 100den büyük olanlarını
             int[] sayi = new int[200];
            int sayac = 0;
            Random random = new Random();
            for (int i = 0; i < 200; i++)
            {
                int rand= random.Next(0, 500);
                Console.WriteLine("büyüktür");
                if (rand<100)
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac+"100den büyük sayi");
            ---------------------------------------------------------------------------
            soru 
            Şehirler diziye tanımlanacak plaka numarası girildiğinde ili bulucak
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
            Console.WriteLine("Plaka kodu giriniz");  
            int kod= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seçiniz plaka kodu  " + sehirler[kod-1]+ "  iline aittir");
              ---------------------------------------------------------------------------
            soru Şehir girince plaka versin
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
            Console.WriteLine("Plaka kodu giriniz");
            int kod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seçiniz plaka kodu  " + sehirler[kod - 1] + "  iline aittir");
            Console.WriteLine("sehir adı giriniz");
            string plaka = Console.ReadLine();
            for (int i = 0; i < 81; i++)
            {
                if (plaka.ToLower() == sehirler[i].ToLower())
                {
                    Console.WriteLine("sehir kodunuz "+(i+1)+"  aittir");
                }
            }
              ---------------------------------------------------------------------------
            soru
              int sayac = 20;
            Random r = new Random();
            int[,] deger = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    deger[i, j] = sayac;
                    sayac += r.Next(20);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + ". satir   ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("\t" + deger[i, j]);
                }
                Console.WriteLine();
            }
             ---------------------------------------------------------------------------
            soru
             5,4 dizi oluşturucaz random sayı atıcaz girilen satırların ortalması alınıcak
             int toplam = 0;
            int sayac = 20;
            Random r = new Random();
            int[,] deger = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    deger[i, j] = sayac;
                    sayac= r.Next(20);
                     toplam= toplam+sayac;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + ". satir   ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("\t" + deger[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(toplam/(5*4));
            */







        }
    }
}
