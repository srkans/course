using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] student = new int[50];
            Random score = new Random();
            int[] scores = new int[11];

            for(int i = 0; i<student.Length; i++)
            {
                student[i] = score.Next(0, 11);
                scores[student[i]] = scores[student[i]] + 1;

                Console.WriteLine("{0}. student's score is : {1}", i + 1, student[i]);
            }

            for(int i = 0; i<scores.Length; i++)
            {
                Console.WriteLine("\n {0} : {1}", i, scores[i]);
            }
        }
    }
}
