using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Store
    {
        ArrayList store = new ArrayList(10);

        public string addProduct(Product p)
        {
            string str = "Store is full";
            if (store.Count<10)
            {
                store.Add(p);
                str = "Product added";
            }
            return str;
        }

        public void removeProduct(Product p)
        {
            store.Remove(p);
        }

        public ArrayList List()
        {
            return store;
        }
    }
}
