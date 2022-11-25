using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack:LIFO

            Stack s = new Stack();

            s.Push("ferrari");
            s.Push("porsche");
            s.Push("mercedes");

            Console.WriteLine("Top is : " + s.Peek());

            Console.WriteLine("Remove from stack : " + s.Pop());

            Console.WriteLine(s.Peek());
            
        }
    }
}
