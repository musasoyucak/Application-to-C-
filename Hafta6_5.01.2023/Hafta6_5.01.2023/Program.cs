using System;
using System.Collections;
using System.Collections.Generic;

namespace Hafta6_5._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList Sehirler = new ArrayList();
            Sehirler.Add("Ankara");
            Sehirler.Add("İstanbul");
            Sehirler.Add("İzmir");
            foreach (var sehir in Sehirler)
            {
                Console.WriteLine(sehir);
            }
            Sehirler.Add("Gaziantep");
            Sehirler.Add("Antalya");
            Console.WriteLine(Sehirler[0]);
            Console.WriteLine(Sehirler[3]);
            Sehirler.Add(123);
            Sehirler.Add('G');

            Console.WriteLine("----------------------------------------------------------------------");

            foreach (var item in Sehirler)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.WriteLine("=======================================================");

            #region List
            List<string> sehirler = new List<string>();
            sehirler.Add("Hatay");
            sehirler.Add("Erzurum");
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }

            // class listeleme

            List<Ogrenci> ogrenci = new List<Ogrenci>();
            ogrenci.Add(new Ogrenci { OgrenciId = 1, OgrenciName = "Haşmet" });
            ogrenci.Add(new Ogrenci { OgrenciId = 2, OgrenciName = "jale" });
            foreach (var item in ogrenci)
            {
                Console.WriteLine(item.OgrenciName);
            }

            // Farklı yazım şekli

            List<Ogrenci> ogrencis = new List<Ogrenci>()
            {
                new Ogrenci { OgrenciId = 3,OgrenciName="Kadir"},
                new Ogrenci { OgrenciId = 4,OgrenciName="lale"}
            };

            foreach (var item in ogrencis)
            {
                Console.WriteLine(item.OgrenciName);
            }
        }
        
    }
}
