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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            richTextBox1.AppendText(openFileDialog1.FileName);           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            richTextBox1.Font = fontDialog1.Font;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified)
            {
                DialogResult dr = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                }
            }
        }
    }
}
