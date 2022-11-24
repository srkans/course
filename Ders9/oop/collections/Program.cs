using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList(5);
            string[] sehirler = { "edirne", "antep", "mugla" };

            liste.Add("istanbul");
            liste.Add("ankara");
            liste.Add("bursa");
            liste.Add("van");
            liste.Add("adana");
            liste.Add("rize");
            liste.Add("artvin");
            liste.Add("antalya");
            liste.Add("izmir");
            liste.AddRange(sehirler);

            Console.WriteLine("Adet:{0} Kapasite:{1}", liste.Count, liste.Capacity);

            if (!liste.Contains("eregli"))
                liste.Add("eregli");

            Console.WriteLine(liste[4]);


            liste.Remove("bursa");
            liste.RemoveAt(0);
            liste.RemoveRange(1, 3);

            Console.WriteLine("Adet:{0} Kapasite:{1}", liste.Count, liste.Capacity);

            //Antalyadan bir önceki degeri sil
            liste.RemoveAt(liste.IndexOf("antalya") - 1);
            //Antalyadan itibaren 2 tane sil
            liste.RemoveRange(liste.IndexOf("antalya"), 2);

            liste.Insert(0, "eskisehir");
            foreach (string sehir in liste)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}
