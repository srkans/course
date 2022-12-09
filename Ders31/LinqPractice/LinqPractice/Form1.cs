using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> personeller;

        List<Bolum> bolumler;

        private void Form1_Load(object sender, EventArgs e)
        {
            bolumler = new List<Bolum>()
            {
                new Bolum() {BolumID=1,BolumAdi="Muhasebe" },
                new Bolum() {BolumID=2,BolumAdi="Satış" },
                new Bolum() {BolumID=3,BolumAdi="IK" },
            };

            personeller = new List<Personel>()
            {
                new Personel {PerID=123,PerAdi="Cevdet",Maas=3000,BolumID=1 },
                new Personel {PerID=124,PerAdi="Selami",Maas=2500,BolumID=2 },
                new Personel {PerID=125,PerAdi="Dursun",Maas=2000,BolumID=2 },
                new Personel {PerID=126,PerAdi="Ali",   Maas=3000,BolumID=3 },
                new Personel {PerID=127,PerAdi="Veli",  Maas=1900,BolumID=2 },
                new Personel {PerID=128,PerAdi="Kemal", Maas=5000,BolumID=1 },
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.kullanım

            //var sonuc = from p in personeller
            //            group p by p.BolumID into grp
            //            select grp;

            //2.Kullanım

            //var sonuc = from p in personeller
            //            group p by p.BolumID into grp
            //            select new { BolumID = grp.Key, KisiSayisi = grp.Count() };

            //1.kullanım

            //var sonuc = personeller.GroupBy(p => p.BolumID);


            //2.Kullanım

            //var sonuc = personeller.GroupBy(p => p.BolumID).Select(p => new { BolumID = p.Key, Sayi = p.Count() });

            //Her grupta çalışan personellerin toplam maaşları

            var sonuc = personeller.GroupBy(p => p.BolumID).Select(p => new { BolumID = p.Key, MaasToplam = p.Sum(prs => prs.Maas) });

            dataGridView1.DataSource = sonuc.ToList();

            //bir yerde func beklediğini görüyorsan orada lambda expression bekliyordur.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var sonuc = from p in personeller
            //            join b in bolumler
            //            on p.BolumID equals b.BolumID
            //            select new { p.PerID, p.PerAdi, p.Maas, b.BolumAdi };

            var sonuc = personeller.Join(bolumler, p => p.BolumID, b => b.BolumID, (p, b) => new { ID = p.PerID,Isim= p.PerAdi, p.Maas, b.BolumAdi }); //basına ID= yazıp sütunu adlandırdık

            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //linq sorguları deferred sorgulardır. yazıldığı yerde değil sonucun kullanıldığı yerde olusturulur-calısır.

            int id = 123;

            var sonuc = (from p in personeller
                         where p.PerID == id
                         select p).ToList();


            id = 128;

            dataGridView1.DataSource = sonuc;

            //ToList() i sonuc'un yanında değil sorgunun sonunda kullanırsam orada calısır ..
        }
    }
}
