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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Right)
            {
                label1.Left += 5;
            }
            if (e.KeyData == Keys.Left)
            {
                label1.Left -= 5;
            }
            if (e.KeyData == Keys.Up)
            {
                label1.Top -= 5;
            }
            if (e.KeyData == Keys.Down)
            {
                label1.Top += 5;
            }

        }
    }
}
