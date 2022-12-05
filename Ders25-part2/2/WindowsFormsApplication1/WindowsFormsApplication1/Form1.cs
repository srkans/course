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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        private void button1_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();

            g.DrawLine(Pens.Orange, 0, 0, 100, 100);
            g.DrawEllipse(Pens.Orchid, 100, 100, 50, 50);

            g.DrawString("Hello World", new Font("Verdana", 40), Brushes.BlueViolet, 100, 100);

        }

        Point start;
        bool control = false;

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();

            if (control == false)
            {
                start.X = e.X;
                start.Y = e.Y;
                control = true;
            }
            else
            {
                g.DrawLine(Pens.Blue, start, new Point(e.X, e.Y));
                control = false;
            }
        }
    }
}
