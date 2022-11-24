using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Bank
    {
        public void Deposit(Customer c, double amount)
        {
            c.balance += amount;
        }

        public string Withdraw(Customer c, double amount)
        {
            string message = "Completed...";

            if(c.balance>=amount)
            {
                c.balance -= amount; 
            }
            else
            {
                message = "insufficient balance...";
            }
            return message;
        }

        public string showBalance(Customer c)
        {
            return c.name + " Balance : " + c.balance; 
        }

        public string Transfer(Customer wfrom, Customer wto, double amount)
        {
            string message = "Completed...";

            if(wfrom.balance >= amount)
            {
                wfrom.balance -= amount;
                wto.balance += amount;
            }
            else
            {
                message = "insufficient balance...";
            }
            return message;
        }
    }
}
