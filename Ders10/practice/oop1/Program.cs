using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car regular = new Car();
            Car ferrari = new Ferrari();
            Car tofas = new Murat124();

            regular.Drive();

            ferrari.Drive();

            tofas.Drive();
        }
    }
}
