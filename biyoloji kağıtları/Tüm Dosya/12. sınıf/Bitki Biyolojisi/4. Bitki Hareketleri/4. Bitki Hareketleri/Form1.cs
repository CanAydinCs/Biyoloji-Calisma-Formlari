using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Bitki_Hareketleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label1.Text = "Tanım:\nBitkiler toprağa bağlıdırlar. Bu nedenle bitkilerde yer değiştirme şeklinde bir hareket görülmez. Ancak bir uyarı olduğunda yönelme (tropizma) ve durum değiştirme (nasti) hareketi yapabilir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sayfalar.Tropizma.Temel x = new Sayfalar.Tropizma.Temel();
            x.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Sayfalar.Nasti x = new Sayfalar.Nasti();
            x.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\tropizmanastitablo.png";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Sayfalar.Sorular x = new Sayfalar.Sorular();
            x.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
