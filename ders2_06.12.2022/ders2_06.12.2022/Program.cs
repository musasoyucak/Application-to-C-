using System;

namespace ders2_06._12._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             Dogum tarihini girince yaşı bulan program
             Console.WriteLine("Dogum tarihini giriniz");
            string a  = Console.ReadLine(); kullanıcıdan bilgi iste
            int yas = 2022 - Convert.ToInt32(a);
            Console.WriteLine(yas); kulanıcıya bilgi ver
            katı sıvı gaz kullanıcıdan sıcaklık girilecek
            Console.WriteLine("Sıcaklık Degeri");

            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Katı");
            }
            else if (a > 0 && a > 100)
            {
                Console.WriteLine("Sıvı");
            }

            else (a > 0)
            {
                Console.WriteLine("Gaz");
            }
             girilen 3 kenardan üçgenin türünü sor 
             Console.WriteLine("üçgenin türü nedir");
            Console.WriteLine("1.kenar");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.kenar");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.kenar");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && c ==b)
            {
                Console.WriteLine("eş kenar");
            }
            else if (a == b || c==b || a==c )
            {
                Console.WriteLine("ikiz kenar");
            }
            else
            {
                Console.WriteLine("çeşit kenar");
            }
            toplama çıkarma işlemi yapan progrm
             Console.Write("1. Sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayiyi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n1. Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
            Console.Write("\nİsleminizi seciniz: ");
            int islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 + sayi2));
            }
            else if (islem == 2)
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 - sayi2));
            }
            else if (islem == 3)
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 * sayi2));
            }
            else if (islem == 4)
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 / sayi2));
            }
            else
            {
                Console.WriteLine("Yanlis secim yaptınız !!");
            }
            Console.ReadLine();

            
             Girilen sınav notlarına göre aa ff durumu hesaplayan program 
            Console.WriteLine("vize giriniz");
            string a = Console.ReadLine();
            double x= Convert.ToDouble(a);
            Console.WriteLine("final giriniz");
            string b = Console.ReadLine();
            double y = Convert.ToDouble(b);
            double z= (x+y)/2;
            if (z < 45)
            {
                Console.WriteLine("harf notu =FF");
            }
            else if (z >= 45 && z <55)
            {
                Console.WriteLine("harf notu =CC");
            }
            else if (z >= 55 && z < 65)
            {
                Console.WriteLine("harf notu =BC");
            }
            else if (z >= 65 && z < 75)
            {
                Console.WriteLine("harf notu =BB");
            }
            else if (z >= 75 && z < 85)
            {
                Console.WriteLine("harf notu =BA");
            }
            else if (z >= 85 && z < 100)
            {
                Console.WriteLine("harf notu =AA");
            }
            örnek
             Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(1,6));
            Console.WriteLine(random.Next(1, 6));
            Console.ReadLine();
            örnek
            Random random = new Random();
            Console.WriteLine(random.Next(1000));
            Console.ReadLine(); */

            Random random = new Random();
            Console.WriteLine(random.Next(1000));
            Console.ReadLine();






        }
    }
}
