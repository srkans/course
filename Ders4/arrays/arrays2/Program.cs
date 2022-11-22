using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int[] scores = { 1, 8, 13, 22, 25, 9, 76, 17, 1 };

            numbers[3] = 12;
            numbers[5] = 7;

            for (int i = 0; i<numbers.Length; i++)
            {
                Console.Write("{0}  ", numbers[i]);
            }

            Console.WriteLine("\n");

            foreach(int s in scores) //foreach is read-only so you can not change any value on array with this way
            {
                Console.Write("{0}  ", s);
            }
        }
    }
}
