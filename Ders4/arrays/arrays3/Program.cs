using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, min = 1000, max = 0;
            int[] numbers = new int[5];

            for(int i = 0; i<numbers.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Enter the 1st number : ");
                        break;
                    default:
                        Console.Write("Number {0} : ", i + 1);
                        break;
                }

                numbers[i] = Convert.ToInt32(Console.ReadLine());

                sum = sum + numbers[i];

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if(numbers[i]>max)
                {
                    max = numbers[i];
                }

            }

            Console.WriteLine("Array elements are {0} {1} {2} {3} {4}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);

            Array.Sort(numbers); //ascending order
            Console.WriteLine("Smallest is {0} and biggest is {1}", numbers[0], numbers[4]);
            Console.WriteLine("Smallest is {0} and biggest is {1}", min, max);

            Console.WriteLine("Sum of the array elements : {0}", sum);


        }
    }
}
