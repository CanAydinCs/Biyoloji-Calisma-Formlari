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
    public partial class Ksyf1 : Form
    {
        public Ksyf1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "-Genellikle karasal ortam bitkilerinde bulunan bitkiyi toprağa bağlayan organdır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Kökün 5 temel görevi vardır:\n1. Bitkiyi toprağa bağlama\n2. Topraktan su ve mineral alma\n3. Alınan su ve minerallerin gövdeye doğru taşınmasını sağlama\n4. Bitki için gerekli bazı bitkisel hormon (sitokinin ve giberellin) ve diğer organik bileşikleri sentezleme\n5. Birçok bitkide organik besinlerin depolanmasını sağlama";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "-Bir bitki tohumunun çimlenme sürecinde embriyonik kökten gelişen ilk köke ana kök (birincil = primer kök) adı verilir.\n-Ana kök, yerçekimi doğrultusunda gelişerek bitkinin toprağa bağlanmasını ve topraktan su ve suda çözünmüş mineralleri almasını sağlar.\n-Ana kökün topraktan faydalanma yüzeyini artırmak için dallanması sonucu yan kökler (ikincil = sekonder kök) meydana gelir.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "-Boyuna Kök; kaliptra, hücre bölünme bölgesi, uzama bölgesi ve olgunlaşma bölgesi olmak üzere dört bölümde incelenir.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "1. Kaliptra (Yüksük=Kök başlığı):\nKök ucunu örten koni şekilli yapıdır. Hücreleri jelatinimsi bir madde üretir. Bu madde kök ucunun toprak içinde kolayca ilerlemesini sağlar.";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "2. Hücre bölünme bölgesi:\nKök ucunun merkezinde bulunan uç meristem hücrelerinden oluşmuştur. Bu hücreler sürekli olarak bölünür. Bu bölgenin uç kısmına büyüme konisi denir.";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "3. Uzama bölgesi:\nUç meristem hücrelerinin bölünerek oluşturduğu yeni hücreler hızla dikey yönde büyür. Böylece kökün uzaması gerçekleşir. Ayrıca bazı hücrelerde farklılaşma meydana gelir ve köke ait diğer dokular oluşturulur.";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "4. Olgunlaşma bölgesi (Kök emici tüy bölgesi):\nUzama bölgesinin üzerinde bulunur. Bu bölgede yoğun olarak kök emici tüyleri yer alır. Emici tüyler suyun ve suda çözünmüş minerallerin topraktan emilmesini sağlar.";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\Kkboyuna.png";

            label1.Text = "";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Enine x = new Enine();
            x.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Kkcesit x = new Kkcesit();
            x.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
