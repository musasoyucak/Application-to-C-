using OkulKayitSistemi.Odeme;
using System;


namespace OkulKayitSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Gizem"; 
            

            KrediKart krediKart = new KrediKart();

            krediKart.Ad = "Gizem";
            krediKart.Soyad = "Cakan";
            krediKart.Tc = "1234567";
            krediKart.Id = 1;
            krediKart.Telefon = "05051235678";
            krediKart.Mail = "g@gmail.com";
            
            Kontrol kontrol = new Kontrol();
            
            kontrol.Odeme = new KrediKart();
            kontrol.Ekle();

            kontrol.Odeme = new Nakit();
            kontrol.Ekle();
        }
    }
}
