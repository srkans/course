using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addNumbersLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 

            for(int i=1; i<=10; i++)
            {
                int number;
                Console.Write("Enter number {0} : ", i);
                number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number; 
            }

            Console.WriteLine("Sum is : {0}", sum);
        }
    }
}
