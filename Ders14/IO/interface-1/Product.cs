using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_1
{
    abstract class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
    }

    interface IPerishable
    {
        DateTime skt { get; set; }
    }

    class Milk: Product, IPerishable
    {
        private DateTime _skt;

        public DateTime skt
        {
            get
            {
                return _skt;
            }
            set
            {
                _skt = value;
            }
        }
    }

    class Ball : Product
    {

    }
}
