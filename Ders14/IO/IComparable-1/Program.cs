using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();

            employees.addEmployee(new Personel() { id = 12, name = "Cevdet", salary = 2000 });

            employees.addEmployee(new Personel() { id = 9, name = "Hasan", salary = 2100 });

            employees.addEmployee(new Personel() { id = 15, name = "Salih", salary = 1900 });

            employees.addEmployee(new Personel() { id = 6, name = "Mustafa", salary = 1700 });

            employees.List();

            foreach(Personel p in employees.toOrder(Order.name))
            {
                Console.WriteLine(p);
            }

            foreach (Personel p in employees.toOrder(Order.id))
            {
                Console.WriteLine(p);
            }

            foreach (Personel p in employees.toOrder(Order.salary))
            {
                Console.WriteLine(p);
            }

        }
    }
}
