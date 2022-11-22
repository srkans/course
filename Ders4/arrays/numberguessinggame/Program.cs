using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, guess;
            Random number = new Random();
            a = number.Next(0, 10);

            for(int i=0; i<3; i++)
            {
                Console.Write("Guess that number : ");
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess>a)
                {
                    Console.WriteLine("Down");
                }
                else if (guess < a)
                {
                    Console.WriteLine("Up");
                }
                else if (guess == a)
                {
                    Console.WriteLine("Congragulations!!!");
                    Console.WriteLine("You have found it at {0} and the correct number is {1}", i + 1, a);
                    break;
                }
                if(i>=2)
                {
                    Console.WriteLine("You couldn't make it :( the number was : {0}",a);
                }
            }

        }
    }
}
