using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
