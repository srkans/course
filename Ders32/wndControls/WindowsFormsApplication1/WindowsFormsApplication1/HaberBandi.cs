using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public enum AkisYonu { SoldanSaga =1, SagdanSola=2 }
    public partial class HaberBandi : UserControl
    {
        public HaberBandi()
        {
            InitializeComponent();
        }

        public string Mesaj {
             get { return label1.Text; }
             set { label1.Text=value; }
        }

        public Color YazıRengi {
            get { return label1.ForeColor; }
            set { label1.ForeColor = value; }
        }

        public AkisYonu AkisYonu { get; set; }

        public int AkisHızı {
            get { return timer1.Interval; }
            set { timer1.Interval = value; }
        }

        public void Baslat()
        {
            timer1.Enabled = true;
        }
        public void Durdur()
        {
            timer1.Enabled = false;
        }
        private void HaberBandi_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (AkisYonu == AkisYonu.SoldanSaga)
            {
                label1.Left += 5;
                if(label1.Left>100)
                {
                    label1.Left = 0;
                }
            }
            else
            {
                label1.Left -= 5;
                if(label1.Left<-100)
                {
                    label1.Left = 600;
                }
            }

        }
    }
}
