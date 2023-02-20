using System;
using System.Threading.Channels;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AracListele liste = new AracListele();

            Otomobil otomobil1 = new Otomobil{Agirlik = 1000,AracAdi = "Mercedes",AracRengi = "Siyah",Hiz=0};
            Otomobil otomobil2 = new Otomobil { Agirlik = 1000, AracAdi = "Bmw", AracRengi = "Siyah", Hiz = 0 };
            Otomobil otomobil3;

            Gemi gemi1 = new Gemi { Agirlik = 150000, AracAdi = "Gemi1", AracRengi = "Beyaz", Hiz = 0};

            Ucak ucak1 = new Ucak{ Agirlik = 200000, AracAdi = "Ucak1", AracRengi = "Beyaz", Hiz = 0,CalismaDurumu = "Ucak Şuan Pistte" };

            //ucak1.InisYap();
            ucak1.KalkisYap();
            //gemi1.DemirAt();
            //gemi1.LimanaParkEt();
           // otomobil1.FrenYap();
            //otomobil1.GazaBas();

   
            liste.UcakListele(ucak1);
            liste.OtomobilListele(otomobil2);
            //liste.GemiListele(gemi1);

            //liste.UcakListele(ucak1);

           
        }
        
    }
}
