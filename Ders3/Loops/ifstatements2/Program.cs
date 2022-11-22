using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifstatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, odd = 0, even = 0;

            Console.WriteLine("Enter 10 numbers");

            for(int i= 0; i<10; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }


            }

            Console.WriteLine("You have entered {0} odd numbers", odd);
            Console.WriteLine("You have entered {0} even numbers", even);

        }
    }
}
