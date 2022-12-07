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
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMARS_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            string strConn = "data source=.;initial catalog=AdventureWorks2016CTP3;integrated security=true;MultipleActiveResultSets=true;";

            //aynı anda birden fazla bağlantı kullanılacaksa multiple...

            SqlConnection conn = new SqlConnection(strConn);

            conn.Open();

            SqlCommand cmd1 = new SqlCommand("select ProductCategoryID,Name from Production.ProductCategory", conn);

            SqlDataReader dr1 = cmd1.ExecuteReader();

            while(dr1.Read())
            {
               //treeView1.Nodes.Add(dr1[1].ToString());

                TreeNode node = new TreeNode(dr1[1].ToString());

               SqlCommand cmd2 = new SqlCommand("select ProductSubCategoryID,ProductCategoryID,Name from Production.ProductSubCategory  where ProductCategoryID=@ID", conn);

               cmd2.Parameters.Clear();

              cmd2.Parameters.AddWithValue("@ID", dr1[0]);

              SqlDataReader dr2 = cmd2.ExecuteReader();

               while(dr2.Read())
               {
                    node.Nodes.Add(dr2[2].ToString());
              }
               
                
                    treeView1.Nodes.Add(node);
                

                
            }

            conn.Close();
        }

        private void btnReadfromXML_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            XmlDocument xdoc = new XmlDocument();

            xdoc.Load("../../Urun.xml"); //2 level up from debug folder

            treeView1.Nodes.Add(xdoc.DocumentElement.Name);

            foreach(XmlNode node in xdoc.DocumentElement)
            {
                TreeNode urun = new TreeNode();

                urun.Text = node.Attributes["UrunID"].Value;

                foreach (XmlNode detay in node.ChildNodes)
                {

                    urun.Nodes.Add(detay.Name + ": " + detay.InnerText);

                }

                treeView1.Nodes[0].Nodes.Add(urun);
            }           
            
        }
    }
}
