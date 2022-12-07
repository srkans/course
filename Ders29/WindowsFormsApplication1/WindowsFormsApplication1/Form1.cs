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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMARS_Click(object sender, EventArgs e)
        {
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
               if(treeView1.Nodes.Count <4)
                {
                    treeView1.Nodes.Add(node);
                }

                
            }

            conn.Close();
        }
    }
}
