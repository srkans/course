using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraystring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your message : ");
            string userMessage = Console.ReadLine();

            for (int i=0; i<userMessage.Length; i++)
            {
                Console.WriteLine(userMessage[i]);
            }

            Console.WriteLine("******************");

            foreach(char c in userMessage)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("*******************");

            for(int i = userMessage.Length-1; i>=0; i--)
            {
                Console.WriteLine(userMessage[i]);
            }
        }
    }
}
