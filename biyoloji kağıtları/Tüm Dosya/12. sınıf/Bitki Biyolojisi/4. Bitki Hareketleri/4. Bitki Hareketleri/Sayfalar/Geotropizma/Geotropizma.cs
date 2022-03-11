using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Bitki_Hareketleri.Sayfalar.Geotropizma
{
    public partial class Geotropizma : Form
    {
        public Geotropizma()
        {
            InitializeComponent();
        }

        void Gster(string resim_yol,int width,int height)
        {
            pictureBox1.Show();
            pictureBox1.ImageLocation = resim_yol;
            pictureBox1.Width = width;
            pictureBox1.Height = height;

            label1.Text = "";
        }

        void Gizle(string yazi)
        {
            pictureBox1.Hide();
            label1.Text = yazi;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Gizle("b) Geotropizma:\nBitkilerin kök ve gövdelerinin yer çekimine karşı gösterdikleri yönelim hareketidir. Bitkilerin kökleri yer çekimine karşı pozitif geotropizma hareketi gösterirken gövdeleri negatif geotropizma gösterir.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gster("Resimler\\nepogeotropizma.png", 888, 502);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Gster("Resimler\\jeotropizma.png", 769, 389);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gster("Resimler\\yanbitki.png", 1034, 396);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Gster("Resimler\\masabitkisi.png", 1034, 396);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
