using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Emplyoee
    {
        public int empID { get; set; }
        public string name { get; set; }

        protected void Trial()
        {
            ;
        }
    }

    class Manager:Emplyoee
    {
        public string carID { get; set; }

        public void Greet()
        {
            ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emplyoee ece = new Emplyoee();
            Manager ali = new Manager();

            //inheritance 
        }
    }
}
