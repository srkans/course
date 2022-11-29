using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_indexers
{
    class Deneme
    {
        int[] numbers = new int[10];
        string[] names = new string[10];

        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }

        public int this[string name]
        {
            get
            {
                return numbers[Array.IndexOf(names, name)];
            }
            set
            {
                numbers[Array.IndexOf(names, name)] = value;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Deneme d = new Deneme();
            d[0] = 1;

            //ADO.NET
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader dr = cmd.ExecuteReader();
            //Indexer özel tanımlı bir property'dir ve sadece class içerisinde tanımlanabilir. Tanımlandığı class'a indexlenebilir özelliği kazandırır.

        }
    }
}
