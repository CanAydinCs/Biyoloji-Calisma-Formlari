using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Bitkilerin_Yapısı.Formlar
{
    public partial class A : Form
    {
        public A()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "-Bitkilerin toprak üstü organ sistemine sürgün sistem, toprak altı organ sistemine kök sistem denir.\n-Kök sistemi, bitkiyi toprağa bağlayıp su ve minerallerin alınmasını sağlayan kısımdır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "-Kök sisteminin temel görevleri;\n-Bitkiyi toprağa bağlama, emme (su ve mineral), taşıma, büyüme, hormon üretmedir.\n-Sürgün sistemini, toprak üstü gövde ve dallar oluşturur. Gövdenin dalları üzerinde yapraklar, çiçekler, tomurcuklar ve meyveler bulunur. Tomurcuklar yeni dalları, yaprakları ve çiçekleri oluşturur.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "-Sürgün sisteminin temel görevleri;\n-Büyüme, depolama, üreme, fotosentez, taşıma, hormon üretmedir.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Ksyf1 x = new Ksyf1();
            x.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Gvde x = new Gvde();
            x.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Yaprak x = new Yaprak();
            x.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\tekve.png";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Kök, gövde ve yapraklarından yararlanılan bitkiler:\n1. Kökünden yararlandığımız bitkiler: Bunların başında havuç, turp, şalgam, kereviz, pancar gelir. Bunlardan havuç, turp, şalgam, kereviz sebze olarak kullanılır. Pancarın da sebze olarak kullanılan türleri vardır. Şeker pancarından ise şeker yapılır.\n2. Gövdesinden yararlandığımız bitkiler: En önemlisi patatestir. Yaprakları, sürgünleri acıdır; zehirlileri bile vardır. Patatesin yenen yeri toprak altındaki yumrularıdır. Bu yumrular, nişasta bakımından çok zengin oldukları için, önemli bir besin maddesidir.\n3. Yapraklarından yararlandığımız bitkiler: Lahana, ıspanak, kıvırcık salata, marul, semizotu, pazı, ebegümeci, tütün, nane, dereotu, tere bunların başlıcalarıdır. Lahana, ıspanak, yeşil salata, marul, semizotu, pazı, ebegümecinden sebze olarak yararlanırız. Nane, dereotu, tere ise, yiyeceklere, içeceklere koku katmakta kullanılır. Bundan dolayı bunlara kokulu bitkiler denir.";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
