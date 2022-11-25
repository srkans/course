using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class A : IInterface
    {
        public void Deneme ()
        {
            Console.WriteLine("Class A");
        }
    }

    class B : IInterface
    {
        public void Deneme()
        {
            Console.WriteLine("Class B");
        }
    }

    interface IInterface
    {
        void Deneme();
    }
    //1-Arayuz icerisinde degisken tanımlaması yapılamaz
    //2-Arayuz icerisinde metodun tamamı olmaz
    //3-Arayuz icerisinde her sey public'tir erisim belirleyici yazılmaz.


    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Deneme();

            B b = new B();
            b.Deneme();
        }
    }
}
