using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    interface IBoyanabilir
    {
        string boyaRengi { get; set; }
    }

    class Boyahane
    {
        public void Boya(IBoyanabilir arac,ConsoleColor yeniRenk)
        {
            arac.boyaRengi = yeniRenk.ToString();
            Console.ForegroundColor = yeniRenk;
        }

    }


    class Tasit
        {
            public string ad { get; set; }
            public int hiz { get; set; }
            public byte tekerlekSayisi { get; set; }
            public string renk { get; set; }
        }

        class Ferrari : Tasit,IBoyanabilir
        {
            public string boyaRengi
            {
                get
                {
                    return this.renk;
                }
                set
                {
                    this.renk = value;
                }
            }
        }

    class Serce:Tasit,IBoyanabilir
    {
        public string boyaRengi
        {
            get
            {
                return this.renk;
            }
            set
            {
                this.renk = value;
            }
        }
    }

    class BMX : Tasit
    {
        
    }
}
