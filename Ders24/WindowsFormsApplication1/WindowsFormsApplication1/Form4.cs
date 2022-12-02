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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }

        Form3 _frm;
        public Form4(string str, Form3 frm)
        {
            InitializeComponent();
            textBox1.Text = str;
            _frm = frm;
        }

        public string Metin
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(e.Start.ToLongDateString());
            _frm.getDate(e.Start.ToLongDateString());
            this.Close();
        }
    }
}
