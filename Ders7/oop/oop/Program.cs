using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("welcome c");

            c.number = -99999;
            c.showInfo();
        }
    }
}
