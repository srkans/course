using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "ali, veli, deli");
            ht.Add(2, "ayse, fatma, hayriye");

            //ht.Remove(1);

            foreach(object o in ht.Keys)
            {
                Console.WriteLine(o.ToString());
            }

            Console.WriteLine(ht[1]);
        }
    }
}
