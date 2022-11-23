using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    class Employee
    {
        private string _name;
        private string _lastName;
        private string _address;
        private int _id;
        private double _salary;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int id
        {
        get { return _id; }
        set { _id = value; }
        }

        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string showEmployeeInfo()
        {
            return string.Format("{0} {1} {2} {3} {4}", _name, _lastName, _address, _id, _salary);
        }
    }
}
