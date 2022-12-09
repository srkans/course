using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Personel> personeller;
        private void Form2_Load(object sender, EventArgs e)
        {
            personeller = new List<Personel>() {
                new Personel() {  PerID = 111,PerAd = "Selami Kurt", Maas = 2000 },
                new Personel() { PerID = 112, PerAd = "Cevdet Korkmaz", Maas = 2500 },
                new Personel() { PerID = 113, PerAd = "Dursun Durmasın", Maas = 2500 },
                new Personel() { PerID = 115, PerAd = "Kemal Kendir", Maas = 2200 }
                                               };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //1-Geleneksel Yöntemle
            foreach (Personel pers in personeller)
            {
                if (pers.Maas == 2500)
                {
                    listBox1.Items.Add(pers.PerID + " " + pers.PerAd + " " + pers.Maas);
                }
            }

            //2-LINQ ile

            //var sonuc = from s in personeller
            //            where s.Maas==2500
            //            select s;

            var sonuc = personeller.Where(p => p.Maas == 2500); //yukarıdaki yada bu sekilde sorgu yapılabilir.burada lambda expression kullanıldı.

            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // var sonuc = (from p in personeller orderby p.Maas descending select p).Take(3);

            var sonuc = personeller.OrderByDescending(p => p.Maas).Take(3);

            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //dataGridView1.DataSource = db.AdvUrunlers.ToList();

            // var sonuc = db.AdvUrunlers.Where(u => u.BirimFiyat > 500).OrderByDescending(u => u.BirimFiyat);

            var sonuc = from u in db.AdvUrunlers
                        where u.Renk == "Black"
                        select new { u.ÜrünID, u.ÜrünAdi, u.Renk };

            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext db = new DataClasses2DataContext();

            if(!db.DatabaseExists())
            {
                db.CreateDatabase();
            }

            db.Albums.InsertOnSubmit(new Album() { AlbumID = 116, AlbumAdi = "Denemeler", Sanatci = "Mogollar", Tur = "Rock", Fiyat = 12 });

            db.SubmitChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //var sonuc = from u in db.AdvUrunlers
            //            group u by u.Renk into grp
            //            select grp;

            var sonuc = db.AdvUrunlers.GroupBy(u => u.Renk);

            //lambda expression kullanmayı tercih et.

            dataGridView1.DataSource = sonuc.ToList();
        }
    }
}
