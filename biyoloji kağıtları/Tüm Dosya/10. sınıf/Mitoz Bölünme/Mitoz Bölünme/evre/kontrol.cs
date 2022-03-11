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
    public partial class kontrol : Form
    {
        public kontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "-Hücre döngüsünde bir hücrenin yaşam sürecindeki olaylar genlerin kontrolü altındadır.\n- Hücre döngüsünün farklı evreleri arasındaki düzeni sağlayan G1, G2 ve M kontrol noktaları vardır. Bu noktalardaki “dur” ve “devam et” sinyalleri döngüyü düzenler.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "-G1 kontrol noktası:\nHücre yeterli büyüklüğe ulaşmışsa, ortamda yeterli besin ve büyüme faktörleri varsa, DNA’da hasar yoksa “devam et” sinyali verilir.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "-G2 kontrol noktası:\nDNA eşlenirken hata veya hasar oluşmuş ise bu durumlar düzeltilinceye kadar “dur” sinyali verilir.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "M kontrol noktası:\nKromozomların iğ ipliklerine tutunup tutunmadığı kontrol edilir. Kinetekorlar iğ ipliğine tutunmazsa anafaz başlamaz. Bu kontrol, oluşacak yavru hücrelerdeki kromozom sayısının eşit olmasını sağlar.\n-Hücre döngüsünün kontrolünün bozulması kansere neden olur. Kanser hücreleri hücre döngüsünün kontrolünü sağlayan sinyallere cevap vermeyen ve devamlı çoğalan hücrelerdir.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Tipik bir memeli hücresi, laboratuvar ortamında 20-50 kez bölünebilirken kanserli hücrelerin uygun besin ortamında hiç durmadan bölündükleri gözlenmiştir. Bu durum kanserli hücrelerin ölümsüz olduğunu gösterebilir. Çok hücreli bir canlı vücudu, farklı özelliklere sahip bir hücreyi bağışıklık sistemiyle yok etmeye çalışır ancak yok edemezse büyüyen bu doku tümör hâlini alır.\n-Bir tümörün başlangıçtaki durumu iyi huyludur. Bu tümörler vücuttan alınarak sorun çözümlenebilir.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "-Organların işlevlerini bozan kötü huylu tümörler bireyin kanser olduğunu gösterir. Kanserli hücreler, kan ve lenf dolaşımına katılıp bütün vücudu dolaşarak, bazı dokularda yeniden yayılabilirler. Bu hücrelerin tümör oluşturdukları ilk dokudan daha uzak dokulara sıçramasına, yayılım göstermesine metastaz denir.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "Kanser hastalığının nedenleri arasında kalıtsal yolla aktarılan iç faktörlerin dışında sigara ve alkol kullanımı, sağlıksız ve aynı tip beslenme, radyasyon, güneş ışınlarının uzun süreli etkisi ve virüsler gibi pek çok çevresel faktör vardır.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
