using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Product p1 = new Product();
            p1.id = 1;
            p1.name = "Pen";

            for (int i = 0; i<13; i++)
            {
                Console.WriteLine(s.addProduct(p1));
            }

            s.removeProduct(p1);

            foreach(Product p in s.List())
            {
                Console.WriteLine(p.id + " " + p.name);
            }
        }
    }
}
