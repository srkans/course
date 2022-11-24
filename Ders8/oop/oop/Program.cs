using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            Book book2 = new Book(999, Console.ReadLine());
            Console.WriteLine(book2.showInfo());
            book2.id = 963;
            book2.bookName = "Olasılıksız";
            book2.authorName = "Adam Fever";
            book2.price = 36;

            Console.WriteLine(book2.showInfo());


        }
    }
}
