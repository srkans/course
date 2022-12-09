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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            var sayi = 10;
            var mesaj = "Deneme 123";
            var maas = 1900.99;
            var kontrol = true;
            var harf = 'a';

            //tip runtime a cıkıncaya kadar belli değil uygulama calıstıgı anda tip belli oluyor ve baska bir tip almıyor. var olarak tanımlayınca ..

            dynamic deneme = 99;
            deneme = "Merhaba Dünya "; //dynamic runtime da farklı tipler alabiliyor.

        }

        private void btnObjInit_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();

            p.PerID = 123;
            p.PerAd = "Serkan";
            p.Maas = 123.45;

            Personel oi = new Personel() { PerID = 124, PerAd = "Betul", Maas = 234.56 }; //object initializer c#4.0
        }

        private void btnColInı_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>() { "ali", "veli", "ahmet", "mehmet" }; //collection initializer
        }

        private void btnAnonymous_Click(object sender, EventArgs e)
        {
            var Musteri = new { MusID = 123, MusAdi = "Ahmet", Adres = "Kadıköy" };
            //anonymous type geçici bir class'a benziyor

            MessageBox.Show(Musteri.MusAdi);
            //bu sayede ayrı olarak bir class oluşturulmadan burada musteri nesnesi olusturuldu.
        }

        private void btnExtension_Click(object sender, EventArgs e)
        {
            int sayi = 12;
            string mesaj = "Deneme";

            //extension method ile var olan sınıflara yapıyı bozmadan yeni metodlar eklenebiliyor.

            //1-extension için yazılan class static olmak zorunda.

            MessageBox.Show(sayi.KareAl().Bol(2).Carp(3).ToString()); //expression tree, özellikle extension metodlar bu şekilde peş peşe kullanılabiliyorlar. 

            MessageBox.Show(mesaj.TersCevir());

        }

        public bool TekSayiMi(int sayi)
        {
            return sayi % 2 == 1 ? true : false;
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 33, 44, 55, 66, 88, 77, 55, 21 };
            listBox1.Items.Clear();

            //1.yöntem

            //for (int i = 0; i<sayilar.Count;i++)
            //{
            //    listBox1.Items.Add(sayilar[i]);
            //}

            //2.Yontem predicate delegate 

            //foreach(var s in sayilar.FindAll(TekSayiMi))
            //{
            //    listBox1.Items.Add(s);
            //}

            //3.Yontem Metod içine method yazarak

            foreach (var s in sayilar.FindAll(delegate (int sayi) { return sayi % 2 == 1 ? true : false; }))
            {
                listBox1.Items.Add(s);
            }

            //4.Yontem Lambda Expression

            foreach (var s in sayilar.FindAll(s => s % 2 == 1 ? true : false))
            {
                listBox1.Items.Add(s);
            }

            //her lambda expression bir delegedir.
        }
    }
}
