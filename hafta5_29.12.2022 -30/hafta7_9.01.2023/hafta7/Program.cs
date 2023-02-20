using System;

namespace hafta7
{
    internal class Program
    {
        /*
         try
        catch
        blogu
        ör---------------------------------------------
         try
            {
                Console.WriteLine("Bir sayi giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bir sayi giriniz");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + b);

            }
            catch (Exception)
            {
                Console.WriteLine("Bir hata oluştu");
                
            }
           finally { Console.WriteLine("Hata olabilir!"); } 
        ---------------------------------------------------
        exception
         byte x;
            try
            {
                Console.WriteLine("0-255 deger giriniz");
                x = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Dogru deger giriniz");

            }
            catch (Exception e)
            {
                Console.WriteLine("Yanlış deger girdiniz");
                Console.WriteLine("Bir hata oluştu :{0}", e);
                
            }
            finally { Console.WriteLine("Hata olabilir!"); } 
            Console.ReadKey();
        }

         */
        static void Main(string[] args)
        {
            Kisi k= new Kisi();
            Kisi ogrenci = new Ogrenci();
            Kisi ogretmen = new Ogretmen();
            
        }
    }
}
