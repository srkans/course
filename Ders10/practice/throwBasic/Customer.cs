using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throwBasic
{
    class Customer
    {
        private int id;

        public Customer()
        {
            throw new System.NotImplementedException();
        }

        ~Customer()
        {
            throw new System.NotImplementedException();
        }

        public int cusID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                ;
            }
        }

        public string showInfo(string a)
        {
            return " ";
        }
    }
}
