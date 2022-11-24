using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Customer
    {
        public string code;
        private int _number;
        public int id { get; set; }

        public Customer()
        {
            Console.WriteLine("...object created...");
        }

        public Customer(string message)
        {
            Console.WriteLine("...." + message + "....");
        }

        public int number
        {
            get { return _number; }
            set { if(value<0)
                    {
                    _number = 0;
                    }
                   else
                {
                    _number = value;
                }
                }
        }

        public void showInfo()
        {
            Console.WriteLine(bringInfo());
        }

        private string bringInfo()
        {
            return "number : " + _number;
        }
    }
}
