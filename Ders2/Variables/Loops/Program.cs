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
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("{0} square is {1}", i, i * i);
            }

            int j=10;
            while(j<20)
            {
                Console.WriteLine("{0} square is {1}", j, j * j);
                j++;
            }

            int k = 20;
            do  //do 1 time without looking condition 
            {
                Console.WriteLine("{0} square is {1}", k, k * k);
                k++;

            } while (k < 30);
        }
    }
}
