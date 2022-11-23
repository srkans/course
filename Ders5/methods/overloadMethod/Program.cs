using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadMethod
{
    class Program
    {
        static void Yaz()
        {
            Console.WriteLine("deneme");
        }

        static void Yaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        static void Main(string[] args)
        {
            Yaz();
            Yaz("Biseyleryaz");
        }
    }
}
