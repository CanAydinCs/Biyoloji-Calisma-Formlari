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
    public partial class Gvde : Form
    {
        public Gvde()
        {
            InitializeComponent();
        }

        public void Resim(string x)
        {
            pictureBox1.Visible = false;
            label1.Text = x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Resim("-Yaprak ve üreme organlarını taşıyan, genellikle toprak üstünde bulunan bitki eksenidir.");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Resim("Gövdenin temel görevleri:\n-Bitkide boy, yüzey alanı ve kütle artışına imkan sağlar.\n-Madde iletimini sağlar.\n-Bazı gövdeler besin depo eder ve fotosentez de yapabilir.\n-Bitkiye diklik ve desteklik sağlar.\n-Vejetatif üremeyi sağlar.\n-Gelişmiş bitkilerde gövde tipleri otsu ve odunsu olmak üzere ikiye ayrılır. Otsu gövdelere daha çok tek yıllık bitkilerde, odunsu gövdelere ise çok yıllık bitkilerde rastlanır.\n-Otsu gövdeler odun ve kabuk içermeyen narin, yeşil gövdelerdir. Odunsu gövdeler ise daha kalındır ve koruyucu bir kabuğa sahiptir.\n-Tek çenekli bitkiler genellikle otsu bitkilerdir. Bu bitkilerde en dışta koruyucu doku olan epidermis tabakası görülür. Epidermisin altında kloroplastlı parankima hücreleri yer alır. Floem ve ksilemden oluşan iletim demetleri parankima dokusu içinde düzensiz dağılmıştır. Bu demetlerde floem dışta, ksilem içte bulunur.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Resim("Not:\nTek çenekli otsu bitkilerde kambiyum bulunmadığı için enine büyüme görülmez. İletim demetleri arasında kambiyum yoksa kapalı demet denir. Ayrıca korteks tabakası ve öz bulunmaz.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Resim("-Çift çenekli bitkiler otsu ve odunsu yapıdadır. Koruyucu epidermis tabakası gövdeyi dış etkilerden korur. Epidermis ile merkezi silindir arasında korteks bulunur. Korteksi parankima ve destek hücreleri (kollenkima ve sklerankima hücreleri) doldurur. Merkezi silindirdeki iletim demetleri (ksilem ve floem) çoğunlukla halka şeklinde sıralanmıştır. Floem ile ksilem arasında kambiyum bulunur. Bunun için açık iletim demetine sahiptir. Merkezi silindirin ortasında kalan kısım öz olarak adlandırılır.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\gvd.png";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Resim("Not:\nTek çenekli bitki gövdelerinde çift çeneklilerden farklı olarak korteks tabakası, kambiyum ve öz bölgesi bulunmaz. İletim demetleri dağınık dizilmiştir (Kapalı İletim Demeti). Çift çeneklilerde iletim demetleri halka şeklinde ve aralarında kambiyum bulunur. (Açık İletim Demeti.)");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Resim("Kök ve gövdede primer büyüme:\n-Bitkinin boyca uzamasıdır. Genç sürgünleri oluşturur. Kök ve gövde ucunda bulunan uç meristem tarafından sağlanır. Açık ve kapalı tohumlu bitkilerin tümünde görülür. Bitkilerde sınırsız büyümeyi sağlar.");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Sek x = new Sek();
            x.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
