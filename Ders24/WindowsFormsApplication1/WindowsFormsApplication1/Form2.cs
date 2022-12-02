using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int akisYonu;
        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            akisYonu = rnd.Next(0, 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (akisYonu == 0)
            {
                label1.Left += 5;
                if (label1.Left > this.Width)
                    label1.Left = -label1.Width;
            }
            else
            {
                label1.Left -= 5;

                if (label1.Left + label1.Width < 0)
                    label1.Left = this.Width;
            }
        }
    }
}
