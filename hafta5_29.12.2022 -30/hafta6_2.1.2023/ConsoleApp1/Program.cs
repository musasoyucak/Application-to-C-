using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            Console.WriteLine(insan.Ad);
            Erkek erkek =new Erkek();
            erkek.Ad = "Abdullah";
            erkek.Soyad = "Cakan";
            erkek.Boy = 174;
            erkek.Nerelisin = "Çanakkale";
            erkek.Sakal = "evet";
            erkek.Tc = 123456789;
            erkek.Yas = 20;
            //erkek.Ad = "mert";
            //erkek.Soyad = "Topaloglu";
            //erkek.Boy = 175;
            //erkek.Nerelisin = "Edirne";
            //erkek.Sakal = "evet";
            //erkek.Tc = 123456789;
            //erkek.Yas = 27;

            Kadin kadin = new Kadin();
            kadin.Makyaj = "evet";
            kadin.Ad = "Gizem";
            kadin.Soyad = "Topaloglu";
            kadin.Boy = 158;
            kadin.Yas = 27;
            

            Baba baba = new Baba();
            baba.Ad = "Ahmet";
            baba.Soyad = "Cakan";
            baba.Tc = 123456789;
            baba.Boy = 170;
            baba.Sakal = "";

            Anne anne = new Anne();
            anne.Ad = "Musebbiye";
            anne.Soyad = "Cakan";
            anne.Boy = 150;
            anne.Tc = 123456789;

            erkek.erkek();
            

        }
    }
}
