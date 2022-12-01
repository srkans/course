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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            radioButton1.Checked = true;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "@C:/......";//dosya yolu yazılcak
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if(radioButton4.Checked == true)
            {
                button4.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = comboBox1.SelectedItem.ToString();

            comboBox2.Items.Clear();

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Istanbul":
                    comboBox2.Items.Add("Kadıköy");
                    comboBox2.Items.Add("Kartal");
                    comboBox2.Items.Add("Maltepe");
                    break;
                case "Ankara":
                    comboBox2.Items.Add("A.Ayrancı");
                    comboBox2.Items.Add("Y.Ayrancı");
                    break;
                case "Zonguldak":
                    comboBox2.Items.Add("Ereğli");
                    break;
            }
        }
    }
}
