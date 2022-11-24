using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            Customer c = new Customer();

            c.customerID = 123;
            c.name = "Serkan";
            c.lastName = "Sacma";
            c.balance = 5000;

            Customer c1 = new Customer();

            c1.customerID = 125;
            c1.name = "Betul";
            c1.lastName = "Cikcik";
            c1.balance = 44444;

            Console.WriteLine(b.showBalance(c));
            Console.WriteLine(b.showBalance(c1));
            Console.WriteLine("-----------------");

            double amount = Convert.ToDouble(Console.ReadLine());
            b.Deposit(c, amount);
            Console.WriteLine(b.showBalance(c));
            Console.WriteLine(b.Withdraw(c1, 50000));
            Console.WriteLine(b.showBalance(c1));

            Console.WriteLine(b.Transfer(c1, c, 4444));
            Console.WriteLine(b.showBalance(c));
            Console.WriteLine(b.showBalance(c1));
        }
    }
}
