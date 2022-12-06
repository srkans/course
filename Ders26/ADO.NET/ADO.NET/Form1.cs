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

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = new SqlConnection(strConn);
            cmd.CommandText = "SELECT * FROM Bolum";

            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            listBox1.Items.Add(dr.GetName(0) + " " + dr.GetName(1));

            while(dr.Read())
            {
                //MessageBox.Show(dr["BolumID"] + " " + dr[1].ToString());
                listBox1.Items.Add(dr["BolumID"] + " " + dr[1].ToString());
            }
            cmd.Connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlConnection connection = new SqlConnection(strConn);

            connection.Open();

            // SqlCommand cmd = new SqlCommand("INSERT INTO Bolum VALUES('Yeni Bolum')",connection);

            //SqlCommand cmd = new SqlCommand("INSERT INTO Bolum VALUES('"+ textBox1.Text  +"')", connenction); // injection risk

            //use commands below

           // SqlCommand cmd = new SqlCommand("INSERT INTO Bolum VALUES(@ad)", connection);

           //nonquery
           SqlCommand cmd = new SqlCommand("if not exists(SELECT * FROM Bolum WHERE BolumAdi =@ad)INSERT INTO Bolum VALUES(@ad)", connection);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", txtAddNew.Text);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(BolumID) FROM Bolum", conn);

            int count = (int)cmd.ExecuteScalar(); //if only one value returns use executeScalar

            this.Text = "Kayit Sayisi : " + count;

            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Bolum WHERE BolumID=@id", conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", txtBolumID.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if(dr.HasRows)
            {
                txtBolumAdi.Text = dr["BolumAdi"].ToString();
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı...", "Uyarı", MessageBoxButtons.OK);
            }

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);

            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Bolum SET BolumAdi = @ad where BolumID = @id", conn);

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@id", txtBolumID.Text);
            cmd.Parameters.AddWithValue("@ad", txtBolumAdi.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Emin misiniz?", "UYARI", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                int ID = int.Parse(listBox1.Text.Substring(0, listBox1.Text.IndexOf(' ')));
                txtBolumID.Text = ID.ToString();

                string strConn = "Data Source = SERKAN; Initial Catalog = Calisma; Integrated Security = True";

                SqlConnection conn = new SqlConnection(strConn);

                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE Bolum WHERE BolumID = @id", conn);

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", txtBolumID.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }
    }
}
