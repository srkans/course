using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    class Trial
    {
        private int x = 11, y = 22, z = 33; // we will use "ref-out" for transferring these values
        
        public void rtrnValue (ref int x, ref int y, ref int z)
        {
            x = this.x;
            y = this.y; //class icerisindeki y degiskeninini al--burada tanımlanan y degiskeni icine ata 
            z = this.z; //this --> class'a ait ...
        } 

        public void rtValue(out int x, out int y, out int z)
        {
            x = this.x;
            y = this.y;
            z = this.z;
        }

        //ref ve out ifadeleri değişkenlerin adreslerini eşleştiriyor.ref ilk değer ataması beklerken out beklemiyor.
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trial d = new Trial();
            int a = 10, b = 20, c = 30;
            int e, f, g;

            d.rtrnValue(ref a, ref b, ref c);

            d.rtValue(out e, out f, out g);

            Console.WriteLine("{0},{1},{2} ", a, b, c);

            Console.WriteLine("{0},{1},{2} ", e, f, g); //class içersindeki private değerleri sonuç olarak döndürüyor.
        }
    }
}
