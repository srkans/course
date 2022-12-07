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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = "data source=SERKAN;initial catalog=AdventureWorks2016CTP3;integrated security=true;";

            SqlDataAdapter da = new SqlDataAdapter("select ProductID,Name,Color,ListPrice from Production.Product", strConn);

            //DataTable dt = new DataTable("Product");
            DataSet dt = new DataSet();

            da.Fill(dt);

            //dataGridView1.DataSource = dt;

            dt.WriteXml("product.xml");
            dt.WriteXmlSchema("product.xsd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            DataSet dt = new DataSet();

            //dt.ReadXmlSchema("product.xsd");
            dt.ReadXml("product.xml");

            dataGridView1.DataSource = dt.Tables[0];
        }
    }
}
