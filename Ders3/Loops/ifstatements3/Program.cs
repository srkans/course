using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifstatements3
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseSalary, totalSales, bonus = 0;

            Console.Write("Enter the base salary : ");
            baseSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter monthly sales value : ");
            totalSales = Convert.ToDouble(Console.ReadLine());

            if (totalSales < 10000)
                bonus = totalSales * 0.02;
            else if (totalSales > 10000 && totalSales < 20000)
                bonus = totalSales * 0.03;
            else if (totalSales >= 20000)
                bonus = totalSales * 0.05;

            Console.WriteLine("Monthly Salary : {0}", baseSalary + bonus);
        
        }
    }
}
