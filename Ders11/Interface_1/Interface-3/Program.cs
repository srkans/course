using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boyahane b = new Boyahane();

            Ferrari f = new Ferrari();
            Serce s = new Serce();
            BMX bmx = new BMX();

            b.Boya(f, ConsoleColor.Blue);
            Console.WriteLine(f.boyaRengi);

            b.Boya(s, ConsoleColor.DarkGreen);
            Console.WriteLine(s.boyaRengi);

            //bmx IBoyanabilir arayuzunu uygulamadığı için çalışmayacaktır...
            //b.Boya(bmx, ConsoleColor.Red);

            IBoyanabilir b1 = new Ferrari();
            IBoyanabilir b2 = new Serce();
            //IBoyanabilir b3 = new Bmx();

            //((Ferrari)b1).Ad;
        }
    }
}
