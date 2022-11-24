using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    class Car
    {
        public virtual void Write()
        {
            Console.WriteLine("Car Class");
        }
    }

    class Ferrari:Car
    {
        public override void Write()
        {
            Console.WriteLine("Ferrari Class");
        }
    }

    class Murat124:Car
    {
        public override void Write()
        {
            Console.WriteLine("Haci Murat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Car f = new Ferrari();
            Car m = new Murat124();

            c.Write();
            f.Write();
            m.Write();

            //polymorphism
            //baseclass'ta virtual olarak tanımlanan method'u türetilen sınıflarda override ettik
        }
    }
}
