using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();

            list.Add("serkan", "dfokgjfdop fgojdhgoıp *0ıewfpodfşl");
            list.Add("betul", "asdşlkdfşlo reyurtopı dşflkvmdflk sdşglfk");
            list.Add("susu", "sdfşsdğ sdfsdf 3w4e sdfsdf weer3");

            foreach(object obj in list.Keys)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(list["betul"]);
        }
    }
}
