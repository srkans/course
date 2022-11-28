using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage s = new Storage();
            s.isFull += D_isFull;

            Product p = new Product();

            p.id = 123;
            p.name = "Paper";

            for(int i = 0; i<12; i++)
            {
                s.addProduct(p);
            }
        }

        private static void D_isFull()
        {
            Console.WriteLine("storage is full...");
        }
    }
}
