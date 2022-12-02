using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = e.X + "," + e.Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bbbToolStripMenuItem.Enabled)
                bbbToolStripMenuItem.Enabled = false;
            else
                bbbToolStripMenuItem.Enabled = true;


            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
                toolStripProgressBar1.Value = i * 10;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }
    }
}
