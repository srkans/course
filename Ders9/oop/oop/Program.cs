using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Buton
    {
        static int sayac = 0;

        public Buton()
        {
            //sayac++;
            Console.WriteLine(++sayac);
        }

        ~Buton()
        {
            Console.WriteLine(--sayac);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Buton b1 = new Buton();
            Buton b2 = new Buton();
            Buton b3 = new Buton();
            Console.ReadLine();
        }
    }
}
