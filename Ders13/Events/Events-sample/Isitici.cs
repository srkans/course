using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_sample
{
    public delegate void olayYakalayici();
    class Isitici
    {
        public int sicaklik { get; set; }

        public event olayYakalayici Kabarciklan;
        public event olayYakalayici sesCikar;
        public event olayYakalayici fokurda;

        public void Isıt()
        {
            sicaklik++;

            if(Kabarciklan!=null && sicaklik>=20)
            {
                Kabarciklan();
            }
            if(sesCikar!=null && sicaklik >= 40)
            {
                sesCikar();
            }
            if(fokurda!=null && sicaklik>=100)
            {
                fokurda();
            }
        }
    }
}
