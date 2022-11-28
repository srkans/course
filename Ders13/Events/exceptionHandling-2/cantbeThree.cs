using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling_2
{
    class cantbeThree:Exception //we have generated our exception
    {
        public override string Message
        {
            get
            {
                return "Value can't be three...";
            }
        }
    }
}
