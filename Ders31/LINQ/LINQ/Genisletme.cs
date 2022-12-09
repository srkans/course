using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    static class Genisletme
    {
        public static int KareAl(this int sayi) //hangi sınıfın içerisine eklenecekse this ile o yazılıyor başlangıçta.
        {
            return sayi * sayi;
        }

        public static int Bol(this int sayi, int bolen) //1.den sonra parametreler tanımlanıyor.
        {
            return sayi / bolen;
        }

        public static int Carp(this int sayi, int carpan)
        {
            return sayi * carpan;
        }

        public static string TersCevir(this string mesaj)
        {
            string yeniStr = "";

            for (int i = mesaj.Length - 1; i > -1; i--)
            {
                yeniStr += mesaj[i].ToString();


            }

            return yeniStr;
        }
    }
}
