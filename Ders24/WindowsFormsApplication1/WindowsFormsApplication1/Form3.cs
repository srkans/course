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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void getDate(string str)
        {
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form4 frm = new Form4();
            //frm.Text = textBox1.Text;
            //1-Access Modifier
            //frm.textBox1.Text = textBox1.Text;
            //2-Property
            //frm.Metin = textBox1.Text;
            //3-ctor
            //Form4 frm = new Form4(textBox1.Text);

            //Ters Yonde Veri Gonderme
            Form4 frm = new Form4(textBox1.Text, this);
            frm.Text = textBox1.Text;
            frm.ShowDialog();
        }
    }
}
