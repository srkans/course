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

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "Color='" + textBox1.Text + "'";
            dataGridView1.DataSource = dt.DefaultView.ToTable();
        }

        DataTable dt;

        private void Form5_Load(object sender, EventArgs e)
        {
            string strConn = "data source=SERKAN;initial catalog=AdventureWorks2016CTP3;integrated security=true;";

            SqlDataAdapter da = new SqlDataAdapter("select ProductID,Name,Color,ListPrice from Production.Product", strConn);

            dt = new DataTable("Product");
            //DataSet dt = new DataSet();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
