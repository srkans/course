using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, min = 100, max = 0;
            double average = 0;

            Random rnd = new Random();

            for(int i = 0; i<10;i++)
            {


                int temp = rnd.Next(0, 101);

                Console.Write("{0}  ", temp);

                if(temp<min)
                {
                    min = temp;
                }

                if (temp > max)
                {
                    max = temp;
                }

                sum = sum + temp;
            }

            average =Convert.ToDouble(sum/10.0);

            Console.WriteLine("");
            Console.WriteLine("maximum is {0}", max);
            Console.WriteLine("minimum is {0}", min);
            Console.WriteLine("sum is {0}", sum);
            Console.WriteLine("average is {0}", average);
        }
    }
}
