using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void delButton();
    class Button
    {
        public event delButton Click;

        public void Run()
        {
            Click();
        }
    }
}
