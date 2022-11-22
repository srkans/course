using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continueBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =0; i<10; i++) 
            {
                if(i==3) //sart saglandiginda yapacagin islem tek satırsa suslu parantez kullanmayabilirsin
                {
                    break;
                }

                Console.WriteLine(i);
            }

            for(int j = 0; j<10; j++)
            {
                if (j==3)
                {
                    continue;
                }

                Console.WriteLine(j);
            }
        }
    }
}
