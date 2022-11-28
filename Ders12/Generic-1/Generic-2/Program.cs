using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_2
{
    class Betul<T>
    {
        T[] array;

        public Betul()
        {
            array = new T[10];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Betul<int> b = new Betul<int>();

            Betul<string> s = new Betul<string>();
        }
    }
}
