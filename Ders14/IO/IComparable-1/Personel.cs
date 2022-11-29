using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_1
{
    class Personel : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public int CompareTo(object obj)
        {
            int result = 0;
            Personel p = (Personel)obj;

            if(Employees.order == Order.id)
            {
                result = this.id > p.id ? 1 : -1;
            }
            else if(Employees.order == Order.name)
            {
                result = this.name.CompareTo(p.name);
            }
            else if (Employees.order == Order.salary)
            {
                result = this.salary > p.salary ? 1 : -1;
            }

            return result;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", id, name, salary);
        }
    }

    public enum Order { id, name, salary}

    class Employees
    {
        List<Personel> employees = new List<Personel>();

        public static Order order;

        public void addEmployee(Personel prs)
        {
            employees.Add(prs);
        }

        public void List()
        {
            foreach(Personel p in employees)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("----------");
        }

        public List<Personel> toOrder(Order xorder)
        {
            order = xorder;
            employees.Sort();
            return employees;
        }
    }
}
