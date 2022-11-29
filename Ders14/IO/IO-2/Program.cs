using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Serkan\Desktop\course\Ders14\data.txt");

            //  Console.WriteLine(sr.ReadToEnd());

            string row;
            int count = 1;

            do
            {
                row = sr.ReadLine();
                if (count %2 == 1)
                {
                    if(row != null)
                    {
                        Console.WriteLine(count + "-" + row);
                    }
                }
                count++;
            } while (row != null);

            sr.Close();
        }
    }
}
