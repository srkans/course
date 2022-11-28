using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3; 

            if(number ==3)
            {
                throw new cantbeThree();
            }
        }
    }
}
