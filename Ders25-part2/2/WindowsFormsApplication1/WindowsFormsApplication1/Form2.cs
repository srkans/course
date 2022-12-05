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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int sayac = 1;
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1-MDI olarak olusturulacak formun "IsMdiContainer" özelliği true yapılacak
            //2-Parent'a bağlanacak formun "MdiParent" özelliğine form atanacak.


            Form1 frm = new Form1();
            frm.MdiParent = this; //oluşturulan formun parent'ının burası olduğu belirtildi.
            frm.Text = "Dokuman " + sayac;
            sayac += 1;
            frm.Show();
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void merdivenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
