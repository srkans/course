using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());

            Directory.CreateDirectory(@"C:\Users\Serkan\Desktop\course\Ders14\denemeler");

            Directory.Delete(@"C:\Users\Serkan\Desktop\course\Ders14\denemeler");

            foreach(string directory in Directory.GetDirectories(@"c:\"))
            {
                Console.WriteLine(directory);
            }

            foreach(string directory in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                Console.WriteLine(directory);
            }

            foreach(string drive in Directory.GetLogicalDrives())
            {
                Console.WriteLine(drive);
            }

            //File
            DriveInfo di = new DriveInfo(@"C:\");
            Console.WriteLine("Size : " + di.TotalSize + "Free Space : " + di.TotalFreeSpace );

            Console.WriteLine(di.DriveFormat + " " + di.IsReady + " " + di.RootDirectory + " " + di.Name + " " + di.DriveType);

        }
    }
}
