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

            ht[1] = new object();
            ht[2] = new object();

            ht.Add(3, new object());

           Console.WriteLine(ht[3]);
        }
    }
}
