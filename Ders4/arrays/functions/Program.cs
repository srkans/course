using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {

        static void PI()
        {
            Console.WriteLine(Math.PI);
        }

        static void Circumferences(int r)
        {
            Console.WriteLine(2 * Math.PI * r);
        }

        static int Square(int s)
        {
            return s * s;
        }

        static string changeCharacter(string a, char old, char newone)
          {
            string newString = "";

            for(int i = 0; i<a.Length ; i++)
            {
                if(a[i]==old)
                {
                    newString = newString + newone;
                }
                else
                {
                    newString = newString + a[i];
                }
            }

            return newString;
          }

        static void Main(string[] args)
        {
            PI();
            Circumferences(9);
            Console.WriteLine(Square(16));
            Console.WriteLine(changeCharacter("Kahramanmaras", 'a', 'o'));

        }
    }
}
