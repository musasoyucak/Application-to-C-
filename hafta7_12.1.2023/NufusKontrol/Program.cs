using System;

namespace NufusKontrol
{
    internal class Program
    {
        /*Kimlik Bilgileri sınıfı oluşturulacak  Ad,Soyad,TcNo Propertyleri ve Kullanım metodu olacak kimlik kullanıldı yazacak
   * Nüfus sınıfı kimlik sınıfından miras alacak kullanım metodu olacak Nüfus cüzdanı Kullanıldı yazacak
   * Ehliyet sınıfı kimlik sınıfından miras alacak kullanım metodu olacak Ehliyet Kullanıldı yazacak
   * Okul sınıfı kimlik sınıfından miras alacak kullanım metodu olacak Okul Kimliği Kullanıldı yazacak
   * Kontrol sınıfında kontrol et metodu oluşturulacak  kimlikbilgileri nesnesi parametresi alacak 
   * 
   * mainde kontrol et metodu çalıştırılarak kimlik kontrolü yapılacak 

   */
        static void Main(string[] args)
        {
            Kontrol kontrol = new Kontrol();
            Nufus   nufus = new Nufus();
            nufus.Ad = "Gizem";
            nufus.Soyad = "Cakan";
            nufus.Tc = "1234567";

            kontrol.KontrolEt(nufus);

        }

    }
}
