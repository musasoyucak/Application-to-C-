using System;

namespace Hesapla
{
    /* Farkli çözüm
     * 
     * internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen için 1, Dikdörtgen için 2, Kare için 3 e basınız");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a==1)
            {
                hesapla ucg = new ucgen();
                ucg.cevre();
            }
            else if (a==2)
            {
                hesapla dik = new dikdortgen();
                dik.cevre();
            }
            else if (a==3)
            {
                hesapla kr = new kare();
                kr.cevre();
            }
            else
            {
                hesapla hsp= new hesapla();
                hsp.cevre();
            }

            Console.ReadLine();
        }
[20:00]
class hesapla
        {
            public virtual void cevre()
            {
                int cevre = 0;
                Console.WriteLine("Çevresi ="+cevre);
            }
        }
        class ucgen : hesapla
        {
            public override void cevre()
            {
                Console.WriteLine("3 Kenarın Uzunluğunu Giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                int cevre = a + b + c;
                Console.WriteLine("Çevresi ="+cevre);
            }
        }
        class dikdortgen : hesapla
        {
            public override void cevre()
            {
                Console.WriteLine("Uzun ve Kısa Kenarın Uzunluğunu Giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int cevre = 2(a + b);
                Console.WriteLine("Çevresi =" + cevre);
            }
        }
        class kare : hesapla
        {
            public override void cevre()
            {
                Console.WriteLine("Bir Kenarın Uzunluğunu Giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                int cevre = 4a;
                Console.WriteLine("Çevresi =" + cevre);
            }
        }
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen  dik= new Dikdortgen();
            Ucgen uc= new Ucgen();
            HesapMakinesi hes = new Dikdortgen();

            dik.hesap();
            Console.WriteLine("*****************");
            uc.hesap();
            Console.WriteLine("*****************");
            hes.hesap();
            Console.WriteLine("*****************");
            Console.ReadKey();
        }
    }
}
