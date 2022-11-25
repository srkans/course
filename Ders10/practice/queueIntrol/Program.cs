using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueIntrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("betul");
            q.Enqueue("serkan");
            q.Enqueue("susu");

            Console.WriteLine(q.Peek());

            Console.WriteLine(q.Dequeue());

            Console.WriteLine(q.Peek());

            

        }
    }
}
