using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Isitici a = new Isitici();

            a.Kabarciklan += A_Kabarciklan;
            a.sesCikar += A_SesCikar;
            a.fokurda += A_Fokurda;

            for(int i = 0; i<110; i++)
            {
                Thread.Sleep(250);

                a.Isıt();
            }
        }

        private static void A_Fokurda()
        {
            Console.WriteLine("Fokurda...");
        }

        private static void A_SesCikar()
        {
            Console.WriteLine("ses cikar...");
        }

        private static void A_Kabarciklan()
        {
            Console.WriteLine("kabarcik...");
        }
    }
}
