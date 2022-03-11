using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Fotoperyodizm.Sayfalar
{
    public partial class Uzun : Form
    {
        public Uzun()
        {
            InitializeComponent();
        }

        private void Uzun_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\uzun.png";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label1.Text = "1) Uzun gün (kısa-gece) bitkileri:\nGündüzün geceye oranla daha uzun olduğu günlerde genellikle ilkbaharda ve yazın çiçeklenen bitkilerdir.\n-Bu bitkilerin çiçeklenebilmesi için 12-14 saat ışık alma süresine ihtiyaç vardır.\n-Ekvator’dan uzak bölgelerde yaşayan bitkiler genellikle uzun gün bitkileridir.\n-Ülkemizdeki bitkiler genellikle uzun gün bitkisidir.\n-Örneğin ıspanak, gün uzunluğu 14 saat ya da daha fazla olunca çiçeklenir. Turp, marul, süsen ve arpa, buğday gibi pek çok tahıl çeşitleri de uzun gün bitkileridir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            label1.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
