using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("Drive car");
        }
    }

    class Ferrari : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Drive Ferrari");
        }
    }

    class Murat124 : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Drive Haci Murat");
        }
    }
}
