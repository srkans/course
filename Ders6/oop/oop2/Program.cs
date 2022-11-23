using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Room
    {
        private int number;
        string message;

        public void setMessage(string s)
        {
            message = s;
        }

        public string getMessage()
        {
            return message;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Room serkan = new Room();
            Room betul = new Room();

            serkan.setMessage("naber");
            Console.WriteLine(serkan.getMessage());
        }
    }
}
