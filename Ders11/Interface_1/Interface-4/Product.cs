using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_4
{
    class Product : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public int CompareTo(object obj)
        {
            int result;

            if (id > ((Product)obj).id)
                result = 1;
            else if (id < ((Product)obj).id)
                result = -1;
            else
                result = 0;

            return result;
        }

        public override string ToString()
        {
            return id + " " + name + " " + price;
        }
    }
}
