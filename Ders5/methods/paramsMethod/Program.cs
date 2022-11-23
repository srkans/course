using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsMethod
{
    class Program
    {
        static int Topla(int s1, int s2)
        {
            return s1 + s2;
        }

        static int Topla(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }

        static int Topla(int s1, int s2, int s3, int s4)
        {
            return s1 + s2 + s3 + s4;
        }

        static int Sum(params int[] sayilar)  //params istenildigi kadar parametre girilmesine olanak sagliyor
        {
            int sum = 0;

            for(int i = 0; i<sayilar.Length; i++)
            {
                sum += sayilar[i];
            }
            return sum;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Topla(1, 1, 1));

            Console.WriteLine(Sum(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
        }
    }
}
