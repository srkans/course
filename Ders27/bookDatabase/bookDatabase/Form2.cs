using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookDatabase
{
    public partial class Form2 : Form
    {
        public Form2(string strIslem)
        {
            InitializeComponent();
            button1.Text = strIslem;

            Database db = new Database();

            cmbYazar.ValueMember = "id"; //arka planda olan
            cmbYazar.DisplayMember = "name"; //ön planda gösterdiği

            cmbYazar.DataSource = db.allAuthors();
        }

        Form1 frm = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(frm.bookID.ToString());

            if (button1.Text == "UPDATE")
            {
                txtKitapID.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "SAVE")
            {
                Database db = new Database();
                

                db.addBook(int.Parse(txtISBN.Text), txtKitapAdi.Text, int.Parse(txtNoP.Text), txtSummary.Text, double.Parse(txtPrice.Text), ((Author)cmbYazar.SelectedItem).id);

                this.Close();
            }

            if (button1.Text == "UPDATE")
            {

                Database db = new Database();

                db.updateBook(int.Parse(txtKitapID.Text), int.Parse(txtISBN.Text), txtKitapAdi.Text, int.Parse(txtNoP.Text), txtSummary.Text, double.Parse(txtPrice.Text), ((Author)cmbYazar.SelectedItem).id);

                this.Close();
            }
        }
    }
}
