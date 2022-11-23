using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Merhaba Dünya";

            Console.WriteLine(str.Contains("er"));
            Console.WriteLine(str.Contains("z"));

            Console.WriteLine(str.IndexOf("ba"));
            Console.WriteLine(str.Insert(0, "Deneme "));

            Console.WriteLine(str.LastIndexOf('a'));
            Console.WriteLine(str.Remove(7)); // belirtilen indexten sonrasını sil
            Console.WriteLine(str.Remove(7, 1)); //belirtilen indexten sonra belirtildiği kadar karakter sil.

            Console.WriteLine(str.Replace("Dünya", "Mars"));
            Console.WriteLine(str.Replace('a', 'e'));


            //foreach (string s in str.Split('a'))
            //{
            //    Console.WriteLine(s);
            //}


            foreach (string s in str.Split('a', 'b'))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(str.Substring(8, 3));

            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());

            string mesaj = "         aaa    bbbb   ";
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj.Trim());
        }
    }
}
