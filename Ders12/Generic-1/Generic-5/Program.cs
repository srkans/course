using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage<Product> storage = new Storage<Product>();

            Product p = new Product();

            for(int i = 0; i<13; i++)
            {
                p.id = 96;
                p.name = "Soda";
                p.price = 963.93;

                storage.addProduct(p);
            }

            storage.showProducts();

            storage.removeProduct(p);

            storage.showProducts();
        }
    }
}
