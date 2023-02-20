using System;

namespace SanalYapilar

{
    internal class Program
    {
        /*
         * Millet class
         * selam ver ccw yazıcak
         * Truk clası milleten miras alıcak oda merhaba diyecek
         * ingiliz seçilir 
         * rus
         * alman 
         * 
         */
        static void Main(string[] args)
        {
            Turk turk = new Turk();
            Ingiliz ıngiliz = new Ingiliz();
            Alman alman = new Alman();
            Millet trk=new Turk();
            Console.WriteLine(turk.SelamVer());
            Console.ReadKey();
        }
    }
}
