using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int result = 1;

            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i=number ; i>1; i--)
            {
                result = result * i;
            }

            Console.WriteLine("Factoriel is : {0}", result);
        }
    }
}
