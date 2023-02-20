using System;

namespace Hafta7
{
    internal class Program
    {
      
   
    
            static void Main(string[] args)
            {

            /*
                *Bir nesne üretir iken tüm memberlar derleme zamanında belirgi haldedir
                * Yani derleme aşamasında hangi nesne üzerinden hangi metotların çağrılabileceğini bilinmektedir.
   
                *
                *Sanal Yapılar ile derleme zamanında kesin bilinen bilgi runtime da bilinmemektedir.
             *ilgili nesnein hangi metot kullanacağını o anki durumda belirlenir.
             *
             *SanalYapilar Yapı nedir.
             *Bir sınıf içerisinde bildirilmiş olan ve o sınıftan türeyen alt sınıflardada tekrar bildirilebilen yapıalrdır.
             * mretot yada property olabilir.
             *
             *
            */


            Terlik t = new Terlik();
                t.Bilgi();


            }




        }

        class Obje
        {
            public virtual void Bilgi()
            {
                Console.WriteLine("Ben bir Objeyim");
            }
        }

        class Terlik : Obje
        {
            public override void Bilgi()
            {
                Console.WriteLine("terlik");
                base.Bilgi();
                this.Bilgi();
            }

        }
        class Kalem : Obje
        {
            public override void Bilgi()
            {
                Console.WriteLine("Ben bir kalemim");
            }

        }

    }


