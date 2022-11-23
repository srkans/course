using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Serkan = new Employee();

            Serkan.name = "Serkan";
            Serkan.lastName = "Sacma";
            Serkan.address = "Istanbul";
            Serkan.id = 963;
            Serkan.salary = 999999999.9;

            Console.WriteLine(Serkan.showEmployeeInfo());
        }
    }
}
