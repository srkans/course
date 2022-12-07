using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double? Fiyat { get; set; }  //? allow null

    }
}
