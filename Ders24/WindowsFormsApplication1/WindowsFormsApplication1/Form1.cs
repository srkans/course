using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strData = "";

            strData += textBox1.Text + ";";
            strData += comboBox1.Text + ";";
            strData += textBox2.Text + ";";

            if (radioButton1.Checked)
            {
                strData += radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                strData += radioButton2.Text;
            }

            strData += ";";

            string strAksesuarlar = "";

            foreach (string s in listBox2.Items)
            {
                strAksesuarlar += s + ",";
            }

            strAksesuarlar = strAksesuarlar.Substring(0, strAksesuarlar.Length - 1);
            strData += strAksesuarlar + ";" + pictureBox1.ImageLocation;

            StreamWriter sw = new StreamWriter("araba.dat", true);
            sw.WriteLine(strData);
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("araba.dat"))
            {
                StreamReader sr = new StreamReader("araba.dat");

                string strData = sr.ReadLine();

                string[] bilgiler = strData.Split(';');

                textBox1.Text = bilgiler[0];
                comboBox1.Text = bilgiler[1];
                textBox2.Text = bilgiler[2];

                if (bilgiler[3] == "Binek")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

                //aksesuarlar
                listBox2.Items.AddRange(bilgiler[4].Split(','));

                pictureBox1.ImageLocation = bilgiler[5];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
