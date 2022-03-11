using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitoz_Bölünme.evre
{
    public partial class Kvrm : Form
    {
        public Kvrm()
        {
            InitializeComponent();
        }

        private void Kvrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Kromatin iplik: Ökaryot hücrelerde ince uzun ip yumağı şeklindeki DNA ve proteinden oluşan yapıdır.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Kromozom: Hücre bölünmesi sırasında kromatin ipliklerinin kısalıp kalınlaşması ile oluşan yapıdır";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Sentromer: Kromozomların yaklaşık orta kısmında bulunan ince bölüm. Kardeş kromatidlerin birbirleri ile bağlandığı bölgedir.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Vücut hücrelerinde görülür.\n•Sonuçta iki hücre oluşur.\n•Oluşan hücrelerin gen yapısı ana hücre ile aynıdır.\n•Tek hücrelilerde üremeyi, çok hücrelilerde yaraların onarılması ve büyümeyi sağlar.\n•Tek safhada gerçekleşir.\n•Bölünme esnasında meydana gelen mutasyon yavru bireye geçmez.\n•Haploid ve diploid hücrelerde görülür.\n•Krossing-over oluşmaz. Çeşitlilik görülmez.\n•Oluşan hücrenin çekirdeği ana hücrenin çekirdeği kadardır.\n• Enerji harcanır.\n• Hem eşeyli hem eşeysiz üremede görülür.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Hücredeki kromozom sayısı “bağımsız sentromer sayısı” kadardır.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Diploit hücrelerde (2n) homolog kromozomlar bir arada bulunurken, haploit hücrelerde(n) homolog kromozomlar bir arada bulunmaz. Çünkü diploit hücrelerden mayoz bölünme ile haploit hücreler oluşurken homolog kromozomlar ayrılarak farklı hücrelere geçerler.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "Mitoz sonucu oluşan hücrelerde kalıtsal çeşitlilik oluşmuş ise bu durum mutasyon ile açıklanır.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "Bakteri, arke ve amip gibi tek hücreli organizmalarda mitoz veya mayoz bölünme görülmez. Çekirdeği olmayan prokaryotlarda hücreler, binary fisyon denilen bölünme yöntemiyle bölünürler.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Kinetekor: Sentromerlerde bulunan iğ ipliklerinin bağlandığı özel proteinlerdir.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Homolog kromozom: Biri anneden diğeri babadan gelen aynı özelliğin genlerini taşıyan büyüklük ve şekilleri aynı olan kromozomlardır.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Haploit hücre (n): Homolog kromozom çiftlerinden sadece birini taşıyan hücredir.\nÖrnek: Üreme hücreleri (yumurta ve sperm hücreleri), Erkek arı hücreleri, bakteriler haploit hücrelerdir.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Diploit hücre (2n): Homolog kromozom çiftlerini taşıyan hücrelerdir.\nÖrnek: Tüm vücut hücreleri (somatik hücreler), Zigot, embriyo, eşey ANA üreme hücreleri diploit hücrelerdir.";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\kntkr.png";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\krd.png";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\hapdip.png";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "Mitoz bölünme ile canlılarda gerçekleşen olaylar:\na. Bir hücrelilerde üremeyi (eşeysiz çoğalmayı) sağlar.\nb. Çok hücreli canlılarda;\n-Büyüme (canlının boy ve ağırlık olarak artması)\n-Gelişme (organların hücre sayısını arttırarak olgunlaşması)\n-Rejenerasyonu (yenilenmeyi) sağlar.\n-Bazı çok hücrelilerde eşeysiz üremeyi (bitkilerde vejetatif üremeyi) sağlar.";
        }
    }
}
