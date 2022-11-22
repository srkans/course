using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifcondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number<10)
            {
                Console.WriteLine("Your number {0} is less than 10", number);
            }

            else if (number>10)
            {
                Console.WriteLine("Your number {0} is greater than 10", number);
            }
            else
            {
                Console.WriteLine("Your number {0} is equal to 10", number);
            }
        }
    }
}
