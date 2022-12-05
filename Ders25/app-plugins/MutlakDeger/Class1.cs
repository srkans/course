using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mathShopSDK;

namespace MutlakDeger
{
    public class MutlakDeger : ISDK
    {
        public string islemAdi
        {
            get
            {
                return "MutlakDeger";
            }
        }

        public int islem(int s)
        {
            return s > 0 ? s : s * -1;
        }
    }
}
