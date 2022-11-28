using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_3
{
    class Program
    {
        static void Main(string[] args)
        {        
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(21);
            list.Add(963);
          //  list.Add("serkan");  

            int sum = 0;

            foreach(int i in list) //there is an error because of the serkan 
            {
                sum += i; 
            }

            Console.WriteLine("toplam = {0}", sum);

            //Type Safety

            List<int> list2 = new List<int>();

            list2.Add(12);
            //list2.Add("serkan"); //doesn't allowed

        }
    }
}
