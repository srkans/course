using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;

            Console.Write("Enter 1st Number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 2nd Number:");
            b = Convert.ToInt32(Console.ReadLine());

            result = a + b;

            Console.WriteLine("\nResult:{0}", result);
        }
    }
}
