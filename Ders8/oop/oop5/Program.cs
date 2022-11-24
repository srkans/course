using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    class Circle
    {
        public int r { get; set; }

        public virtual double Calculate()
        {
            return Math.PI * r * r;
        }
    }

    class Cylinder : Circle
    {
        public int h { get; set; }
        public override double Calculate()
        {
            return base.Calculate() * h;
        }
    }

    class Cone : Cylinder
    {
        public override double Calculate()
        {
            return base.Calculate() * 0.333;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.r = 3;
            Console.WriteLine(c.Calculate());

            Cylinder cyl = new Cylinder();
            cyl.r = 4;
            cyl.h = 5;
            Console.WriteLine(cyl.Calculate());

            Cone con = new Cone();
            con.r = 4;
            con.h = 4;
            Console.WriteLine(con.Calculate());
        }
    }
}
