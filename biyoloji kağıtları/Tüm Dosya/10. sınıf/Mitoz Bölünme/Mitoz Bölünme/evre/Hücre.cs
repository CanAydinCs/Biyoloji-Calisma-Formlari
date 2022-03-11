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
    public partial class Hücre : Form
    {
        public Hücre()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-Belirli bir büyüklüğe ulaşmış hücreler bölünerek çoğalır.\n-Bir hücrenin bölünebilmesi için gerekli temel şart, belli bir büyüklüğe ulaşmasıdır.\n- Hücreye bölünme emri veren merkez çekirdektir.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hücreyi bölünmeye zorlayan sebepler:\n1.Hücre büyüdükçe, çekirdek hacmi/sitoplazma miktarı arasındaki oran azalır. Bu durum çekirdeğin hücreyi yönetmesini güçleştirir.\n2. Büyüme sırasında hücrenin hacmi yarı çapının küpüyle(r^3) büyürken, yüzeydeki büyüme yarı çapının karesi (r^2) ile olur. Bunun sonucunda hacim/yüzey oranı artar.\nBöylece hücrenin;\n-Madde alış verişi\n-Madde iletimi,\n-Artık madde atılması,\n-Gaz alış verişi,\n-Çekirdeğin hücredeki denetimi zorlaşır.\n-Bütün bu olumsuzlukları ortadan kaldırmak için hücre bölünerek yüzeyini genişletir.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "-Bir hücrelilerde üremeyi sağlarken çok hücrelilerde üreme ile birlikte büyümeyi, gelişmeyi, yaraların onarılmasını, ölen bazı hücrelerin yerine yenilerinin yapılmasını sağlar.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Bölünebilmesi için belirli bir büyüklüğe ulaşma şartı taşımayan hücreler vardır. Bunun en güzel embriyonik hücrelerdir. Bu hücreler, segmentasyon dediğimiz olay ile belli bir büyüklüğe ulaşma şartı olmaksızın sadece DNA eşlenerek hızlı mitoz bölünmeler ile sayılarını kısa sürede artırır.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Hücre bölünmesinin temel nedeni azalan yüzey/hacim oranını artırmaktır.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Bir hücrenin bölüneceğinin kesin kanıtı DNA’sının eşlenmiş olmasıdır.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Hücre büyümesi ile birlikte;\n-Hücrede yüzey/hacim oranı azalır.\n-Hücrede hacim/yüzey oranı artar.\n-Hücrede çekirdek /sitoplazma oranı azalır.\n-Hücrede sitoplazma/çekirdek / oranı artar.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
