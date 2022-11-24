using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTypes
{

    abstract class absClass 
    {
        public int number { get; set; }
    }

    class Generated : absClass
    {
        public string name { get; set}
    }

    sealed class sealClass : Generated
    {

    }

    static class staClass
    {
        public static void Deneme()
        {

        }

           
    }
   

}
