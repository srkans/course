using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_practice
{
    class Program
    {
        public delegate void delPro();

        public static void Write()
        {
            Console.WriteLine("WRITE");
        }

        public static void Message()
        {
            Console.WriteLine("MESSAGE");
        }

        public static void List(string str)
        {
            Console.WriteLine("LISTELE");
        }
        static void Main(string[] args)
        {
            delPro d = new delPro(Write);

            d += Write;
            d -= Write;
            d += Message;

           // d += List; 

            d.Invoke();
            d();
        }
    }
}
