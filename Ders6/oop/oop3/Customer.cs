using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    class Customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string lastName { get; private set; } //private will not used 
        public string address { get; set; }

        public Customer() // constructor method
        {
            Console.WriteLine("Customer object has been created");
        }

        public Customer(int id) //constructor
        {
            this.ID = id;
            Console.WriteLine("Customer object has been created 2");
        }

        ~Customer() //destructor method 
        {
            Console.WriteLine("Customer object has been terminated");
        }
    }
}
