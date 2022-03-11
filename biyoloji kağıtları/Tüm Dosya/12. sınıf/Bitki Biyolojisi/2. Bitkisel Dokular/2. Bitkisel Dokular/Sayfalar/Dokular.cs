using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Bitkisel_Dokular.Sayfalar
{
    public partial class Dokular : Form
    {
        public Dokular()
        {
            InitializeComponent();
        }

        public void Resim(int s1, int s2, string x)
        {
            pictureBox1.ImageLocation = "Resimler\\" + x + ".png";
            pictureBox1.Visible = true;
            pictureBox1.Width = s1;
            pictureBox1.Height = s2;
            label1.Text = "";
        }

        public void Gstr(string x)
        {
            pictureBox1.Visible = false;
            label1.Text = x;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Gstr("Dokular; aynı görevi yapmak üzere özelleşmiş hücre topluluklarıdır.\n-Yüksek yapılı bitkilerde bulunan dokular üstlendikleri görevlere göre meristem, temel, iletim ve örtü doku olmak üzere dört gruba ayrılır.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Resim(1061, 616, "doku");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Meristem x = new Meristem();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Temel x = new Temel();
            x.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Koruyucu x = new Koruyucu();
            x.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Iletim x = new Iletim();
            x.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Resim(1132, 616, "bitki");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
