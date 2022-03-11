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
    public partial class YaprakEnine : Form
    {
        public YaprakEnine()
        {
            InitializeComponent();
        }

        public void Resim(string x)
        {
            pictureBox1.Visible = false;
            label1.Text = x;
        }

        public void Gstr(string x,int s1,int s2)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = x;
            pictureBox1.Width = s1;
            pictureBox1.Height = s2;
            label1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Resim("Tanım:\nYaprak enine kesitinde, epidermis, iletim dokusu ve mezofil tabakası olmak üzere üç ana bölüm bulunur.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Resim("Üst ve alt epidermis:\nTek sıralı bir hücre katmanı hâlinde koruyucu bir dokudur. Epidermis hücreleri kloroplast taşımaz, fotosentez yapmaz. Epidermis hücrelerinin farklılaşması ile oluşan, epidermis hücreleri arasında terleme ve gaz alışverişini sağlayan stomalar bulunur. Stomalarda kloroplast bulunur. Dolayısı ile fotosentez gerçekleşir.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Resim("İletim dokusu:\nBitkilerde su, mineral ve besin maddelerinin taşındığı yapılardır. Fotosentez gerçekleştirmezler.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gstr("Resimler\\iletim.png", 1100, 506);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Resim("Mezofil tabakası:\nYapraklarda kloroplast içeren hücreler, yaprağın iç kısmındaki mezofil tabakasında bulunur. Bu bölüm palizat ve sünger parankiması olmak üzere ikiye ayrılır. Yapraklarda en fazla kloroplast palizat parankiması hücrelerinde bulunur. Dolayısı ile en fazla fotosentez de burada gerçekleşir.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Gstr("Resimler\\yaprakenine.png", 910, 524);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
