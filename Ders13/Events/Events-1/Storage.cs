using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_1
{
    public delegate void delStorage();
    class Storage
    {
        public event delStorage isFull;

        List<Product> storage = new List<Product>();

        public void addProduct(Product p)
        {
            if(storage.Count<10)
            {
                storage.Add(p);
            }

            if(isFull != null && storage.Count == 10)
            {
                isFull();
            }
        }
    }
}
