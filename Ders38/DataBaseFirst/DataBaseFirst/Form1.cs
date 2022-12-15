using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calismaEntities db = new calismaEntities();

            var sonuc = from p in db.Personel where p.PerAd.Contains(txtName.Text) select p;

            dataGridView1.DataSource = sonuc.ToList();
        }
    }
}
