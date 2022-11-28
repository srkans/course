using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_5
{
    class Storage<T> where T:class //where T:class is constraint
    {
        List<T> products = new List<T>(10);

        public void addProduct(T product)
        {
            if(products.Count<10)
            {
                products.Add(product);
            }
            else
            {
                Console.WriteLine("Storage is full...");
            }
        }

        public void removeProduct(T product)
        {
            products.Remove(product);
        }

        public void showProducts()
        {
            Console.WriteLine("-------------");

            foreach(T product in products)
            {
                Console.WriteLine("products {0}", product);
            }
        }
    }
}
