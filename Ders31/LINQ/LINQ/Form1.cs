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
    }
}
