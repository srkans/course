using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzelKontrol
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        Random rnd;
        int deger;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        public void Baslat()
        {
            timer1.Enabled = true;
        }

        public void Durdur()
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            deger = rnd.Next(1, 101);

            progressBar1.Value = deger;
            progressBar2.Value = deger;
            progressBar3.Value = deger;

        }
    }
}
