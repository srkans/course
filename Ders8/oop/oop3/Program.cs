using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    class Circle
    {
        public int r { get; set; }

        public double calcArea()
        {
            return Math.PI * r * r;
        }
    }

    class Cylinder:Circle
    {
        public int h { get; set; }

        public double cylVolume()
        {
            return calcArea() * h;
        }
    }

    class Cone:Cylinder
    {
        public double coneVolume()
        {
            return cylVolume()*0.333;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.r = 4;
            Console.WriteLine(c.calcArea());

            Cylinder cyl = new Cylinder();
            cyl.r = 3;
            cyl.h = 4;
            Console.WriteLine(cyl.cylVolume());

            Cone con = new Cone();
            con.r = 3;
            con.h = 4;
            Console.WriteLine(con.coneVolume());
          
        }
    }
}
