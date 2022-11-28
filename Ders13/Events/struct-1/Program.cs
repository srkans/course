using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_1
{
    struct point2D //if the data is less then 16byte then use struct
    {
        public int X;
        public int Y;

        public point2D(int x, int y) 
        {
            this.X = x;
            this.Y = y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            point2D point;

            point.X = 20;
            point.Y = 12;

            int number = new int(); //sample
            Console.WriteLine(number);


        }
    }
}
