using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine("you have entered 1");
                    break;
                case 2:
                    Console.WriteLine("you have entered 2");
                    break;
                case 3:
                    Console.WriteLine("you have entered 3");
                    break;
                default:
                    Console.WriteLine("out of range");
                    break;
            }
        }
    }
}
