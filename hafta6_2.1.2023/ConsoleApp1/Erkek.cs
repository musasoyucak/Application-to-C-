using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Erkek:Insan
    {
        public string Sakal { get; set; }
        public void erkek()
        {
            Console.WriteLine("Ev hanesinin erkek bilgisi"+Ad+""+Sakal+"" );
        }
    }
}
