using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1
{
    class Program
    {
        static void Degistir(int s)
        {
            s = -1;
        }
        static void Degistir(int[] s)
        {
            for (int i = 0; i < s.Length; i++)
                s[i] = -1;
        }
        static void Main(string[] args)
        {
            int sayi = 99;
            int[] sayilar = { 11, 22, 33 };

            Degistir(sayi); //value type 
            Degistir(sayilar); //reference type 

            Console.WriteLine(sayi);
                                        //search value - reference type
            foreach (int s in sayilar)
                Console.Write(s + " ");
        }
    }
}
