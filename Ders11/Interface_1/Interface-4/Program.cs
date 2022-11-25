using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList { 111, 77, 99, 172, 56 };
            list1.Sort();

            foreach(int i in list1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");

            ArrayList products = new ArrayList();
            Product p1 = new Product();
            p1.id = 2;
            p1.name = "Pen";
            p1.price = 9;

            Product p2 = new Product();
            p2.id = 1;
            p2.name = "Book";
            p2.price = 13;

            products.Add(p1);
            products.Add(p2);

            products.Sort();  //object must implement Icomparable !!!

            foreach(Product p in products)
            {
                Console.WriteLine(p);
            }

        }
    }
}
