using System;

namespace Alisveris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Satici satici = new Satici();
            Console.WriteLine("Satici bilgilerini  yazınız");
            satici.Ad=Console.ReadLine();
            satici.Soyad=Console.ReadLine();
            satici.Tc=Console.ReadLine();
            satici.Bolge=Console.ReadLine();

            Console.Clear();
            
            Alici alici = new Alici();
            Console.WriteLine("Alici bilgilerini  yazınız");
            alici.Ad = Console.ReadLine();
            alici.Soyad = Console.ReadLine();
            alici.Id = int.Parse(Console.ReadLine());
            alici.Tc = Console.ReadLine();

            Console.Clear();

            Urun urun= new Urun();
            Console.WriteLine("Urun bilgilerini  yazınız");
            urun.Id = int.Parse(Console.ReadLine());
            urun.Ad = Console.ReadLine();
            urun.Turu = Console.ReadLine();
            urun.Fiyat = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ad :"+satici.Ad+"\n"+satici.Soyad+"\n"+satici.Tc + "\n" +satici.Bolge + "\n");
            Console.WriteLine("Ad :" + alici.Ad + "\n" + alici.Soyad + "\n" + alici.Tc + "\n" + alici.Id + "\n");
            Console.WriteLine("Ad :" + urun.Id + "\n" + urun.Ad + "\n" + urun.Turu + "\n" + urun.Fiyat + "\n");

        }
    }
}
