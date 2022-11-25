using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Customer
    {
        public string customerName { get; set; }

        public override string ToString()
        {
            return "Customer name : " + customerName;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            c.customerName = "Betul Altu";

            Console.WriteLine(c);
        }
    }
}
