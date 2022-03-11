using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Bitki_Hareketleri.Sayfalar.Tropizma
{
    public partial class Tablo : Form
    {
        public Tablo()
        {
            InitializeComponent();
        }

        public void Resim(int s, int height)
        {
            pictureBox1.ImageLocation = "Resimler\\fototablo" + s + ".png";
            pictureBox1.Width = 1076;
            pictureBox1.Height = height;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Resim(1,670);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Resim(2, 463);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Resim(3, 675);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
