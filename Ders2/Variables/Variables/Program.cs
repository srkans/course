using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            int age = 12;
            string name;
            name = Console.ReadLine();

            Console.Write("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());  // int.Parse(Console.ReadLine());

            Console.WriteLine("\n Welcome {0} your age is {1}", name, age);  //{0} {1} .. {n} , var1, var2 .. varn
        }
    }
}
