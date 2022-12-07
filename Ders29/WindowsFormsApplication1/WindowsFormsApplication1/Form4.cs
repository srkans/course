using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Serkan\Desktop\course\Ders29\Database1.mdb";

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Musteri", strConn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Serkan\Desktop\course\Ders29\Database1.mdb";

            OleDbConnection conn = new OleDbConnection(strConn);

            conn.Open();

            OleDbCommand cmd = new OleDbCommand("select * from Musteri", conn);

            OleDbDataReader dr = cmd.ExecuteReader();

            List<Musteri> musteriler = new List<Musteri>();

            while (dr.Read())
            {
                Musteri m = new Musteri();
                m.ID = Convert.ToInt32(dr[0]);
                m.MusteriAdi = dr[1].ToString();
                m.Adres = dr[2].ToString();
                m.Telefon = dr[3].ToString();

                musteriler.Add(m);
            }

            conn.Close();

            dataGridView1.DataSource = musteriler;
        }
    }
}
