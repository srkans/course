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

        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text)).ToString());
        }


        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (textBox1.Text.Contains("abc"))
                {
                    MessageBox.Show("abc iceriyor...");
                }
            }

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Left -= 10;
            button1.Top -= 10;
        }
    }
}
