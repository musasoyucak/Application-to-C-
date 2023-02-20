using System;
using System.Data.SqlClient;

namespace console1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Console.WriteLine("Merhaba ben Gizem");
            Console.WriteLine("Soyadım=Topaloglu");
            Console.WriteLine("27 yaşındayım");
            Console.WriteLine("Koç burcuyum");
            Console.WriteLine("Yazılım öğreniyorum");

            int s2 = Convert.to(B);
            int a = 5;
            int b = 3;
            Console.WriteLine(a + b);
            kullanıcı isim sor kullanıcı ..kişidir yaz
            
            
            Console.Write("isminizi giriniz.");
            string a= Console.ReadLine();
            Console.Write("soyisim giriniz.");
            string b = Console.ReadLine();
            Console.WriteLine("merhaba "+a ,b );


            kullanıcıdan veri iste convertle dönüştütr topla
                    Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi + sayi2);
           
            Karenin alanını hesaplayan program
            Console.Write("Karenin bir kenarını giriniz: ");
            int kare = Convert.ToInt32(Console.ReadLine());
            int alan = kare * kare;
            Console.WriteLine("karenin alanı: "+" "+alan);
            Math.Pow(b, 2);== üs alma
             Δ =b2– 4ac 
             Console.WriteLine("Δ =b2– 4ac  diskirimat veren program");
            Console.WriteLine("a degeri giriniz");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b degeri giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c degeri giriniz");
            int c = Convert.ToInt32(Console.ReadLine());
            int s = 4;
            Console.WriteLine("d="+(b*b-s*a*c));
            silindirin hacmini hesaplayalım
            2πr2 * h
             Console.WriteLine("2πr2 * h silindirin veren program");
            Console.WriteLine("yarıcap degeri giriniz");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("yükseklik degeri giriniz");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.PI*2* Math.Pow(r, 2) * h); 
            Girilen sayı 10dan büyükse büyüktür yazsın
             Console.WriteLine("Sayı giriniz");
            int sayi =Convert.ToInt32( Console.ReadLine());
            if ( sayi  > 10)
            {
                Console.WriteLine("sayı 10dan büyüktür.");
            }
            else if (sayi==10)
            {
                Console.WriteLine("sayı 10'a eşittir.");
            }
            else
            {
                Console.WriteLine("sayı 10dan küçük .");
            }
            sayı pozitifmi negatifmi
             Console.WriteLine("Sayı giriniz");
            float sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                Console.WriteLine("sayı pozitiftir.");
            }
          
            else
            {
                Console.WriteLine("sayı negatiftir  .");
            }
            vize ve final  notu 50dan büyükse geçsin küçükse kalsın
            */
            Console.WriteLine("vize notu giriniz");
            double vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notu giriniz");
            double final = Convert.ToInt32(Console.ReadLine());
            double gecme = (vize * 0.4 + final * 0.6);
            if (gecme > 50)
            {
                Console.WriteLine("dersi geçmiştir.");
            }
          
            else
            {
                Console.WriteLine("dersten kalmıştır  .");
            }






        }
    }
}
