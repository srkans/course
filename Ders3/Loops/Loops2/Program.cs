using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int sonuc = 1;

            Console.WriteLine("Faktöryeli bulunacak sayıyı giriniz..");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi > 0)
            {
                for (int i = sayi; i > 0; i--)
                {
                    sonuc = sonuc * i;
                }

                Console.WriteLine("Sonuc={0}", sonuc);

                sonuc = 1;
                Console.WriteLine("Faktöryeli bulunacak sayıyı giriniz..");

                sayi = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
