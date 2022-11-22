using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            float r;
            Console.WriteLine("This program calculates circle circumferences and area\n");
            Console.Write("Enter the radius:");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("Circle's circumferences is : {0}\n", 2 * 3.14 * r);
            Console.WriteLine("Circle's area is : {0}", 3.14 * r * r);

        }
    }
}
