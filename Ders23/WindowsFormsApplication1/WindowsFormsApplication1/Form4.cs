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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goToPage(comboBox1.Text);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data.txt");
            string satir;
            do
            {
                satir = sr.ReadLine();
                if (satir != null)
                    comboBox1.Items.Add(satir);
            } while (satir != null);

            sr.Close();
        }

        private void goToPage(string address)
        {
            webBrowser1.Navigate(address);

            webBrowser1.DocumentTitleChanged += WebBroser1_DocumentTitleChanged;

            if (!comboBox1.Items.Contains(address))
            {
                comboBox1.Items.Add(address);
            }
        }

        private void WebBroser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(webBrowser1.DocumentTitle + "aa");
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                goToPage(comboBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show(e.Url.ToString());
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("data.txt");

            foreach (string str in comboBox1.Items)
                sw.WriteLine(str);

            sw.Close();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.MaximumProgress;
            progressBar1.Value = (int)e.CurrentProgress;
        }
    }
}
