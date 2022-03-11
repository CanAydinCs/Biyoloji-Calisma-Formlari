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
    public partial class Halka : Form
    {
        public Halka()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bitkilerde Büyüme Halkaları (YAŞ Halkaları):\n-Ilıman bölgelerde yaşayan ağaçların gövdesinden enine kesit alındığında iç içe birçok halka görülür. Bu halkaların her biri bir yıl içinde meydana gelen ksilem dokudur ve bunlara büyüme (yaş) halkaları denir.\n-Gövdenin içinde merkeze yakın olan halkalar yaşlı, kabuğun altındaki halkalar ise gençtir.\n-Ilıman bölgelerde ağaçlar genel olarak ilkbaharda büyümeye başlar ve büyüme sonbaharda durur. Bu süreye büyüme mevsimi denir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Soru: İlkbahar odununun açık renkli, sonbahar odununun ise koyu renkli halkalar şeklinde görülmesinin nedeni nedir?\n-Büyüme mevsiminin erken döneminde oluşan ilkbahar odununun hücreleri büyük ve hücre duvarları ince; yaz süresince kullanılabilir su azaldığından bitki gelişimi de yavaşlar ve kalın çeperli, ince hücrelerden oluşan dar ve koyu renkli yaz odunu gelişir. Bu nedenle ilkbahar odununun yoğunluğu sonbahar odununun yoğunluğundan daha azdır. Bu yoğunluk farkı ilkbahar odununun açık renkli, sonbahar odununun ise koyu renkli halkalar şeklinde görülmesine neden olur.\nAynı yıl oluşan açık ve koyu halka ağacın bir yaşını gösterir. Ağacın yıllık halka genişliği o yılki iklimle ilişkilidir. Sıcaklık, ışık ve yağış ağacın gelişmesi için uygunsa oluşan yaş halkası geniş, uygun değilse dar olmaktadır. Buna dayanarak bilim insanları çok yaşlı ağaçların odun halkalarına bakarak eski dönemlerden günümüze iklim değişiklikleriyle ilgili ipuçları elde edebilmektedir.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nTropik bölgelerde yaşayan ağaçlarda böyle mevsimsel bir büyüme gözlenmediğinden yaş halkaları oluşmaz.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
