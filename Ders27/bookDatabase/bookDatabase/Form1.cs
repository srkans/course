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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            Database db = new Database();

            db.listBooks(dataGridView1, txtSearchBook.Text);
        
        }

        public int bookID { get; set; }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("UPDATE");
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            db.listBooks(dataGridView1, "");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2("SAVE");
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Emin misiniz?", "UYARI", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Database db = new Database();
                db.deleteBook(bookID);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            Database db = new Database();

            db.listBooks(dataGridView1, "");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                bookID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                MessageBox.Show(bookID.ToString());

            }
        }
    }
}
