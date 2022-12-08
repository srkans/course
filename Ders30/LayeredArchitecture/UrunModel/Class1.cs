using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunModel
{
    public class Urun
    {
        public int UrunID { get; set; }

        public string UrunAdi { get; set; }

        public double BirimMaliyet { get; set; }

        public short KarOrani { get; set; }

        public byte KDVOrani { get; set; }

        public double KDVliFiyat { get; set; }
    }
}
