using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{

    class wc2022
    {
        public int number;
        string message;
    }
    class Program
    {
        static void Main(string[] args)
        {
            wc2022 japan = new wc2022();

            japan.number = 0;

            Console.WriteLine(japan.number);

            wc2022 germany = new wc2022();

            germany.number = 4;

            Console.WriteLine(germany.number);
        }
    }
}
