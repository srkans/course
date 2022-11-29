using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@"C:\Users\Serkan\Desktop\course\Ders14\deneme2.txt", true);
            StreamWriter sw = new StreamWriter(@"C:\Users\Serkan\Desktop\course\Ders14\deneme.txt",true);



            for (int i = 0; i < 11; i++)
            {
                sw.WriteLine("Sayi : {0}", i);
                tw.WriteLine("stream writer introduction");
            }

            sw.Close();
            tw.Close();
        }
    }
}
