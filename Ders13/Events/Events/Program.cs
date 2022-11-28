using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Button b = new Button();

            //b.Click += new delButton(D_Click);

            b.Click += D_Click;

            b.Run();

        }

        private static void D_Click()
        {
            Console.WriteLine("Button object has been clicked");
        }
    }
}
