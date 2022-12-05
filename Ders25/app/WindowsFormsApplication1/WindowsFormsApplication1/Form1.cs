using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mathShopSDK;
using System.Reflection;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            plugins = new Dictionary<string, ISDK>();
        }
        Dictionary<string, ISDK> plugins;

        private void button1_Click(object sender, EventArgs e)
        {
            //1-Listbox ile secilen plugini bul
            //2-plugin'in islem metodunu cağırarak gerekli islemleri yap

            ISDK plg = plugins[listBox1.Text];
            label1.Text = plg.islem(int.Parse(textBox1.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1-App MathShopDSK ekle
            //2-Dictonary tanımla
            //3-Directory nesnesi ile dll'lere ulas
            //4-Assembly nesnesi ile dll yukle
            //5-Assemly içersindeki sınıfları öğren
            //6-Eger class ise Activator nesnesi ile somut örneklemesini al..
            //7-plugins kolleksiyonuna ekle
            //8-Listbox'a plugin'in ismini ekle

            foreach(string dllPath in Directory.GetFiles(@"C:\Users\Serkan\Desktop\course\Ders25\plugins"))
            {
                Assembly asm = Assembly.LoadFile(dllPath);

                foreach(Type t in asm.GetTypes())
                {
                    if (t.IsClass)
                    {
                        ISDK plugin = (ISDK)Activator.CreateInstance(t);
                        plugins.Add(plugin.islemAdi, plugin);
                        listBox1.Items.Add(plugin.islemAdi);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string s in Directory.GetDirectories(@"C:\Users\Serkan\Desktop\course\","*", SearchOption.TopDirectoryOnly))
            {
                DirectoryInfo di = new DirectoryInfo(s);
                listBox2.Items.Add(di.Name);
            }
           
        }
    }
}
