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
    public partial class Pridermis : Form
    {
        public Pridermis()
        {
            InitializeComponent();
        }

        public void Gstr(string x)
        {
            pictureBox1.Visible = false;
            label1.Text = x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Gstr("-Çok yıllık bitkilerin kök ve gövdelerinde bulunur.\n-Epidermisin parçalanması ve mantar meristemi ile oluşur.\n-Hücreleri ölüdür.\n-Hücrelerinin içi su geçirmeyecek şekilde hava ile doludur.\n-Hücrelerinin çeperleri süberin (mantar) birikimi le kalınlaşır.\n-Bitkiyi sıcak, soğuk, su kaybı ve mekanik etkilerden korur.\n-Mantar dokuda stoma bulunmaz.\n-Peridermis üzerinde lentisel (kovucuk) denilen açıklıklar bulunur.\n-Lentiseller, gövde içinde bulunan canlı hücreler ile dış ortam arasındaki gaz alışverişini sağlar.\n-Lentiseller, epidermiste bulunan stomalara karşılık gelirler.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gstr("-İkisi de gaz alışverişini sağlar.\n-İkisi de koruyucu dokuda bulunur.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\pridermistablo.png";
            label1.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gstr("Bitkilerde Salgı Elemanları ve Salgı Maddeleri\n-Bitkinin metobolizma ürünlerini bitkiye zarar vermeyecek şekilde kimyasal dönüşüme uğratıp depolar ve dışarı verir.\n-Hücre toplulukları, tüyler, cepler ve kanallar salgı elemanlarını oluşturur.\n-Salgı hücreleri; canlı, bol sitoplazmalı, büyük çekirdekli ve golgi organeli bakımından zengindir.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Gstr("Bitkilerde Salgı Maddelerinin görevleri\n-Bitkilerde belirli hücreler tarafından salgılanan hormonlar büyüme, gelişme, çiçek açma, tohumun çimlenmesi gibi olayları düzenler.\n-Reçine ve tanenli salgılar bitkileri zararlı mikroorganizmalar ve hayvanlardan korur.\n-Isırgan otunda salgı üreten yakıcı tüyler bitkinin korunmasını sağlar\n-Çiçeklerde bulunan koku ve bal özü salgısı böcekleri çekerek bitkinin tozlaşmasına yardımcı olur.\n-Böcekçil bitkilerin yaprakları tarafından salgılanan sıvılar böceklerin sindirilmesinde etkilidir.");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
