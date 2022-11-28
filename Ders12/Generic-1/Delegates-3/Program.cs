using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_3
{
    class Program
    {
        static bool oddNumber(int s)
        {
            return s % 2 == 1 ? true : false;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(12);
            numbers.Add(31);
            numbers.Add(9);
            numbers.Add(6);
            numbers.Add(3);
            numbers.Add(369);

            foreach(int i in numbers.FindAll(oddNumber))
            {
                Console.WriteLine(i);
            }

            foreach(int i in numbers.FindAll(delegate (int i) { return i % 2 == 1 ? true : false; } ))
            {
                Console.WriteLine(i);
            }

            foreach(int i in numbers.FindAll(i=> i % 2 == 1 ? true:false))
            {
                Console.WriteLine(i);
            }
        }
    }
}
