using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "şuşu minnak cik cik";
            string[] subStr = new string[4];
            int i = 0;
           
            foreach(string array in str.Split(' '))
            {
                
                Console.WriteLine(array);
                subStr[i] = array;
                i++;
            }

            string[] auxStr = new string[4];

            for (int j=0; j<subStr.Length; j++)
            {
               auxStr[j] = subStr[j].Substring(0, 1).ToUpper();
                Console.WriteLine(auxStr[j]);
            }
         
            for(int k = 0; k<auxStr.Length;k++)
            {
                Console.Write(auxStr[k] + subStr[k].Remove(0, 1) + ' ');
            }
       
        }
    }
}
