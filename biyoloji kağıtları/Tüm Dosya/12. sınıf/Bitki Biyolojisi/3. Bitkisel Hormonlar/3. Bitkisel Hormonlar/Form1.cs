using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bitkisel_Hormonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hormonlar;\nbitki tarafından çok düşük yoğunlukta üretilen ve üretildikleri yerden bitkinin diğer kısımlarına taşınan kimyasal habercilerdir.\n-Hormonlar bitkide doğal olarak sentezlendiği gibi laboratuvar ortamında sentetik olarak da üretilir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sayfalar.Etki x = new Sayfalar.Etki();
            x.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Sayfalar.Oksin x = new Sayfalar.Oksin();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Sayfalar.Sitokinin x = new Sayfalar.Sitokinin();
            x.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Sayfalar.Giberellinler x = new Sayfalar.Giberellinler();
            x.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Sayfalar.Etilen x = new Sayfalar.Etilen();
            x.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.Text = "-Hemen hemen tüm bitki dokuları absisik asit sentezleyebiir.\n-Büyüme ve gelişmeyi durdurur.\n-Tomurcuk ve tohumların uyku halinde kalmasını (dormansi) sağlar. Böylece uygun olmayan olumsuz şartlarda tohum çimlenmesini engeller.\n-Kuraklık stresi sırasında stomaların kapanmasına yol açar. Terlemeyi durdurarak su kaybını önler.";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Sayfalar.Soru x = new Sayfalar.Soru();
            x.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
