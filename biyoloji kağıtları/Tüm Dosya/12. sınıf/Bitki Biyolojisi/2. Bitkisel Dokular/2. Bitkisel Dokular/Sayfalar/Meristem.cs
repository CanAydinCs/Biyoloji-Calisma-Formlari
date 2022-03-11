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
    public partial class Meristem : Form
    {
        public Meristem()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "-Bitkilerin büyüme bölgelerinde bulunur.\n-Canlı kaldığı sürece sürekli bölünebilme yeteneğine sahip hücrelerden oluşur. Meydana gelen yeni hücreler farklılaşarak çeşitli dokuları, dokular da organları meydana getirir. Böylece bitki büyür ve gelişir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\n-Bütün bitkisel yapılar meristem hücrelerinin farklılaşması ile oluşur. Bu sebepten dolayı meristem hücrelerine \"bitkisel kök hücre\" de diyebiliriz.\n-Meristem hücrelerinin sürekli bölünebilme özelliğine sahip olması, bitkilerde büyümenin sınırsız olmasını sağlar.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Meristem doku hücrelerinin özellikleri:\n-Hücreleri sürekli mitozla bölünme özelliğine sahiptir.\n-Hücreleri canlı, küçük, ince çeperli, bol sitoplazmalı, genellikle kofulları yok ya da çok küçüktür, büyük çekirdekli ve çekirdekler ortadadır.\n-Hücreler arasında boşluk yoktur, sıkı dizilmişlerdir.\n-Hormon da üretirler.\n-Metabolizmaları (yapım ve yıkım olayları) hızlıdır.\n-Plastidleri bulunmaz. Dolayısı ile fotosentez yapamazlar. Ancak plastidleri oluşturacak öncül yapılar (proplastid) bulunur.\n-Bitkide enine ve boyuna büyümeyi, gelişme ve farklılaşmayı sağlar.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "1) Uç (Apikal) Meristem:\n-Kök ve gövdenin uç kısımlarında (büyüme noktalarında) bulunur.\n-Bitkinin boyuna büyümesini sağlar.\n-Kökenlerine göre birincil meristeme karşılık gelir.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text = "2) Yanal (Lateral) Meristem:\n-Kök ve gövdenin yapısında bulunur.\n-Bitkinin enine büyümesini ve kalınlaşmasını sağlar.\n-Kökenlerine göre ikincil meristeme karşılık gelir.";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.Text = "1) Birincil (Primer) Meristem:\n-Embriyonik dönemden beri bölünme yeteneklerini kaybetmemiş olan hücrelerden oluşur.\n-Kök ve gövdenin uç kısımlarında bulunur. Kök ve gövde uçlarındaki bu bölgelere \"büyüme noktası (konisi)\" denir ve bitkilerin boyca büyümesini sağlar.\n-Kök ucundaki birincil meristem kaliptra denilen yapı ile korunurken, gövde ucu birincil meristem kış aylarında tomurcuk yapraklar tarafından korunur.";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Text = "2) İkincil (sekonder) Meristem:\n-Bölünme yeteneğini kaybetmiş parankima hücrelerinin sonradan bölünme yeteneği kazanması ile meydana gelir. Kambiyum ve mantar kambiyumu (fellogen) ikincil meristemdir.";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Kambiyum;\nOdunsu ve bazı otsu bitkilerin kök ve gövdelerinde iletim demetlerinin oluşmasını böylece enine büyümeyi sağlayan dokudur. Her yıl biri ilkbahar diğeri sonbaharda iki defa mitoz geçirir ve yaş halkalarını oluşturur. Her yıl yeni iletim demetlerinin oluşumunu sağlar.";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Mantar kambiyumu:\nBitkilerde koruyucu doku olan mantar dokuyu (peridermisi) oluşturan dokudur. Bitki kalınlaştıkça mantar tabakanın en dışındaki hücre sıraları gerilime dayanamaz ve parçalanır. Mantar kambiyumu aktif bir şekilde bölünerek bu tabakayı devamlı yeniler.\n-Elverişsiz çevre koşullarına ve iç değişmelere karşı kök ve gövdeyi örterek korur.";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
