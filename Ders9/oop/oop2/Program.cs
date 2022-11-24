using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Personel
    {
        public int PerID { get; set; }
        public string Ad { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList personeller = new ArrayList();

            Personel p1 = new Personel();
            Personel p2 = new Personel();
            p1.PerID = 123;
            p1.Ad = "Cevdet";
            p2.PerID = 222;
            p2.Ad = "Selami";
            personeller.Add(p1);
            personeller.Add(p2);

            foreach (Personel p in personeller)
                Console.WriteLine("ID:{0} Ad:{1}", p.PerID, p.Ad);
        }
    }
}
