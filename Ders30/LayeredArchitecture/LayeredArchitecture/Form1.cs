using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunModel;

namespace LayeredArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") {


                BusinessLayer.BusinessUrun u = new BusinessLayer.BusinessUrun();

                Urun urun = u.UrunBul(int.Parse(textBox1.Text));

                dataGridView1.DataSource = null;
                //dataGridView1.Rows.Clear();

                List<Urun> gridUrun = new List<Urun>();

                gridUrun.Add(urun);

                dataGridView1.DataSource = gridUrun;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                BusinessLayer.BusinessUrun u = new BusinessLayer.BusinessUrun();

                DialogResult dr = MessageBox.Show("UYARI", "Emin misiniz?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    u.UrunSil(int.Parse(textBox1.Text));
                }
            }
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            //Tum Urunler
            BusinessLayer.BusinessUrun u = new BusinessLayer.BusinessUrun();

            dataGridView1.DataSource = u.TumUrunler();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessLayer.BusinessUrun u = new BusinessLayer.BusinessUrun();
            u.UrunEkle(textBox2.Text, double.Parse(textBox3.Text), short.Parse(textBox4.Text), byte.Parse(textBox5.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //katmanlı mimari ile yazılmadı..(saklı prosedür kullanımı)

            SqlConnection conn = new SqlConnection("data source = SERKAN;initial catalog = Calisma;integrated security = true;");

            conn.Open();

            SqlCommand cmd = new SqlCommand("UrunAdet", conn); //execute yazmaya gerek yok direkt saklı prosedürün ismi yazılıyor.

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();

            cmd.Parameters.Add("@Adet", SqlDbType.Int);

            cmd.Parameters["@Adet"].Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();

            MessageBox.Show(cmd.Parameters["@Adet"].Value.ToString());
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //katmanlı mimari ile yazılmadı..(saklı prosedür kullanımı)

            SqlConnection conn = new SqlConnection("data source = SERKAN;initial catalog = Calisma;integrated security = true;");

            conn.Open();

            SqlCommand cmd = new SqlCommand("UrunAdiGetir", conn); //execute yazmaya gerek yok direkt saklı prosedürün ismi yazılıyor.

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@UrunID", int.Parse(textBox1.Text));

            cmd.Parameters.Add("@UrunAdi", SqlDbType.VarChar, 100);

            cmd.Parameters["@UrunAdi"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            MessageBox.Show(cmd.Parameters["@UrunAdi"].Value.ToString());
            conn.Close();
        }
    }
}
