using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Book
    {
        private int _id;
        private string _bookName;
        private string _authorName;
        private double _price;

        public Book()
        {

        }

        public Book(int number, string str)
        {
            id = number;
            bookName = str;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string bookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        public string authorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string showInfo()
        {
            return string.Format("{0} {1} {2} {3}", _id, _bookName, _authorName, _price);
        }
    }
}