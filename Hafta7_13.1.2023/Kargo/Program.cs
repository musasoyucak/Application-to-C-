using System;

namespace Kargo
{
    internal class Program
    {
        /*
       Bir kargo firması
      kapıda ödendi
      kart ile ödendi
      interfaceden yararlanarak
        ------------------------------------------------------------------------
        
       */
        static void Main(string[] args)
        {
            Paymentbycard paymentcard = new Paymentbycard();

            paymentcard.Ad = "Gizem";
            paymentcard.Soyad = "Cakan";
            paymentcard.Tc = "1234567";
            Kontrol kontrol = new Kontrol();
            //Prop doldurmasak null hatası verir 
            kontrol.Ode= new Paymentbycard();
            kontrol.Ekle();

            kontrol.Ode = new ShippingPayment();
            kontrol.Ekle();

            //kontrol.KontrolEt(paymentcard );


        }
       

    }
}
