using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mathShopSDK;

namespace Faktoriyel
{
    public class Faktoriyel : ISDK
    {
        public string islemAdi
        {
            get
            {
                return "FaktöriyelAl";
            }
        }

        public int islem(int s)
        {
            int sonuc = 1;
            for (int i = s; i > 0; i--)
            {
                sonuc *= i;
            }
            return sonuc;
        }

    }
}
