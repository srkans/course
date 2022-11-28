using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_2
{
    public delegate void delSerkan(string s); 
    class Program
    {
        static void Main(string[] args)
        {
            delSerkan d1 = delegate (string str)
            {
                Console.WriteLine("anonymous method : " + str);
            };

            d1.Invoke("HeyHeyHey");
        }
    }
}
