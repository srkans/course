using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_1
{
    public enum KDV { Gida = 1, Icecek, Giyim = 8, Diger = 18, Luks = 25 }

    public enum Days :byte { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Serkannnn");

            for(int i = 0; i<16; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("Serkannnn");
            }

            Console.WriteLine((int)KDV.Luks);

            Console.WriteLine((int)Days.Thursday);
        }
    }
}
