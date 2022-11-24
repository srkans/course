using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    class Personel
    {
        public int perID { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return perID + " " + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.perID = 46;
            p.name = "Abuzittin";

            Console.WriteLine(p.ToString());
        }
    }
}
