using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                //this.BackColor = colorDialog1.Color;
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
            label1.ForeColor = fontDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            label1.Text = saveFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Merhaba");
            // MessageBox.Show("Merhaba", "UYARI");
            // MessageBox.Show("Merhaba", "UYARI", MessageBoxButtons.YesNo);
            // MessageBox.Show("Merhaba", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            // MessageBox.Show("Merhaba", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
           // MessageBox.Show("Merhaba", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);

            DialogResult dr = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
