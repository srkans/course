using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mathShopSDK;

namespace Kup
{
    public class Kup : ISDK
    {
        public string islemAdi
        {
            get
            {
                return "KupAl";
            }
        }

        public int islem(int s)
        {
            return s * s * s;
        }
    }
}
