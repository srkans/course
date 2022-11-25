using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    class Products : IEnumerable
    {
        string[] products = { "Kitap", "Defter", "Kalem" };

        public IEnumerator GetEnumerator() //IEnumerable implemented for using foreach loop
        {
            return products.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Products p = new Products();

            ArrayList list = new ArrayList(); //IEnumerable  contains
            list.Add("Cam");
            list.Add("Tahta");
            list.Add("Demir");

            foreach(string s in list) 
            {
                Console.WriteLine(s);
            }

            foreach(string s in p)
            {
                Console.WriteLine(s);
            }
        }
    }
}
