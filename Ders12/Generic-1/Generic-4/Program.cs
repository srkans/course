using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Performance

            ArrayList list1 = new ArrayList();

            DateTime first, last;

            first = DateTime.Now;

            for(int i=0;i<99999999; i++)
            {
                list1.Add(i);
            }

            last = DateTime.Now;

            TimeSpan diff1 = last - first;

            Console.WriteLine("ArrayList : {0}", diff1.TotalMilliseconds);

            //generic make it possible to avoid boxing-unboxing 

            List<int> list2 = new List<int>();

            first = DateTime.Now;

            for (int i = 0; i < 99999999; i++)
            {
                list2.Add(i);
            }

            last = DateTime.Now;


            TimeSpan diff2 = last - first;

            Console.WriteLine("List<>: {0}", diff2.TotalMilliseconds);

        }
    }
}
