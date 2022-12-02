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
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            string strPath = folderBrowserDialog1.SelectedPath;

            foreach (string file in Directory.GetFiles(strPath))
            {
                FileInfo fi = new FileInfo(file);
                if(fi.Extension == ".jpg")
                {
                    listBox1.Items.Add(fi.Name);
                }
            } 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = folderBrowserDialog1.SelectedPath + @"\" + listBox1.SelectedItem;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
