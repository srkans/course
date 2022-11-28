using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_1
{
    class Program
    {
        public delegate void delMare();

        static void Write()
        {
            Console.WriteLine("Write to screen");
        }

        static void Hello()
        {
            Console.WriteLine("Merhaba");
        }

        static void Hey()
        {
            Console.WriteLine("Selam");
        }

        static double Pi()
        {
            return 3.14;
        }

        static void whatsUp(string str)
        {
            Console.WriteLine("Naber " + str);
        }

        static void Main(string[] args)
        {
            delMare del1 = new delMare(Write);

            del1 = del1 + new delMare(Hello);

            del1 = del1 + new delMare(Hey);

           // del1.Invoke();

            foreach(Delegate del in del1.GetInvocationList())
            {
                Console.WriteLine(del.Method);

                if(del.Method.Name == "Write")
                {
                    del.DynamicInvoke();
                }
            }
        }
    }
}
