using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar", strConn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow row = dt.NewRow();

            row[0] = 963;
            row[1] = 369;
            row[2] = "House of Dragon";

            dt.Rows.Add(row);

            dataGridView1.DataSource = dt;

            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            StreamWriter sw = new StreamWriter("data.txt");

            foreach(DataRow r in dt.Rows)
            {
                sw.WriteLine(r[2].ToString() + " " + row.RowState);
            }

            sw.Close();

            da.Update(dt);
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlDataAdapter da = new SqlDataAdapter("Select * from Kitaplar", strConn);

            DataTable dt = new DataTable("Kitap"); //verileri xml dosyasına yazarken isim vermek gerekiyor.

            da.Fill(dt);

            dt.WriteXml("data.xml");  
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar ; SELECT * FROM Yazarlar", strConn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0]; //Tables-->Kitaplar ve Yazarlar
        }

        private void btnConBuilder_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

            csb.DataSource = "SERKAN";
            csb.InitialCatalog = "Calisma";
            csb.IntegratedSecurity = true;

            MessageBox.Show(csb.ToString());


        }

        private void btnAppConfig_Click(object sender, EventArgs e)
        {
            // SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["StrConnCalisma"].ConnectionString);

            SqlConnection conn = new SqlConnection("Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True");

            conn.Open();

            MessageBox.Show(conn.State.ToString());

            conn.Close();  
                
        }

        private void btnMultiQuery_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True");

            conn.Open();

            SqlCommand cmd = new SqlCommand("select*from Kitaplar;select * from Yazarlar", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            int index = 2;

            do
            {
                while (dr.Read())
                {
                    MessageBox.Show(dr[index].ToString());
                }

                index = 1;
            } while (dr.NextResult());


            //bağlantılı yöntemde birden fazla sorguyu çalıştırmak için next result kullanılıyor.

            conn.Close();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True");

            conn.Open();

            SqlCommand cmd = new SqlCommand("select KitapID,KitapAdi,isNull(Fiyat,'0.0') as Fiyat from Kitaplar", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            List<Kitap> kitaplar = new List<Kitap>();

            while (dr.Read())
            {
                Kitap ktp = new Kitap();

                ktp.KitapID = Convert.ToInt32(dr[0]);
                ktp.KitapAdi = dr[1].ToString();
                ktp.Fiyat = Convert.ToDouble(dr[2]);

                kitaplar.Add(ktp);
            }

            dataGridView1.DataSource = kitaplar;


            conn.Close();
        }
    }
}
