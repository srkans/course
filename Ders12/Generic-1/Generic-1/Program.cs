using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_1
{
    class Program
    {
        static void wtoScreen(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }

        static void wtoScreen(double[] array)
        {
            foreach(double d in array)
            {
                Console.WriteLine(d);
            }
        }

        static void wtoScreen(string[] array)
        {
            foreach(string s in array)
            {
                Console.WriteLine(s);
            }
        }

        static void Write<T>(T[] array) 
        {
            foreach(T s in array)
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 66, 44, 55, 22, 33, 11 };
            double[] prices = { 3.23, 12.08, 25.66, 909.102, 1.85 };
            string[] names = { "ahmet", "mehmet", "okkes","beste" };

            Array.Sort(numbers);
            wtoScreen(numbers);

            Array.Sort(prices);
            wtoScreen(prices);

            Array.Sort(names);
            wtoScreen(names);

            //Write(numbers);
            Write<int>(numbers);

            //Write(prices);
            Write<double>(prices);

            //Write(names);
            Write<string>(names);
        }
    }
}
