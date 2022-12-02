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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage();
            Button btn = new Button();
            btn.Text = "Deneme";
            btn.Dock = DockStyle.Fill;
            page.Controls.Add(btn);
            page.Text = "DENEME";
            tabControl1.TabPages.Add(page);
        }
    }
}
