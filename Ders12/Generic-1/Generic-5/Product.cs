using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_5
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return id + " " + name + " " + price;
        }
    }
}
