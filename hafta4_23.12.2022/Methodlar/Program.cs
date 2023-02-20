using System;

namespace Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bir mesaj giriniz");
            string mesaj = Console.ReadLine();
            Console.WriteLine("adet giriniz");
            int adet = Convert.ToInt32(Console.ReadLine());
            tekrareden(mesaj ,adet);
        }
        static void tekrareden( string m,int a)
        {
            
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(m);
            }
        }

    }
}
