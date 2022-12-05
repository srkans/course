using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mathShopSDK;

namespace Kare
{
    public class Kare : ISDK
    {
        public string islemAdi
        {
            get
            {
                return "KareAl";
            }
        }

        public int islem(int s)
        {
            return s * s;
        }
    }
}
