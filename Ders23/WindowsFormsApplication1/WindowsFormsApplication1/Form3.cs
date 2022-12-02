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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        List<string> picFiles;

        private void Form3_Load(object sender, EventArgs e)
        {
            picFiles = new List<string>();

            foreach (string file in Directory.GetFiles(@"F:\Serkan\Foto\2010"))
            {
                FileInfo fi = new FileInfo(file);
                if(fi.Extension == ".jpg")
                {
                    picFiles.Add(file);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        int count = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = picFiles[count++ % picFiles.Count];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
