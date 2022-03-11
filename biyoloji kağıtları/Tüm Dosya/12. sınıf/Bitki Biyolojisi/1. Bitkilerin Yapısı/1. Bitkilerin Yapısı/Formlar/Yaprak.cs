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
    public partial class Yaprak : Form
    {
        public Yaprak()
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
            Resim("Yaprağın temel görevleri:\n-Fotosentez ile besin üretme\n-Stomalardan gaz değişimini sağlama\n-Terleme ve damlama yoluyla fazla su ve minerallerin atılmasını sağlama\n-Yaprak dökümü ile zararlı maddelerin bitkiden uzaklaştırılmasını sağlama\n-Ayrıca birçok bitkide böcekleri çekme, besin ve su depo etme, bitkiyi hayvanlardan koruma (ısırgan otu gibi), böcekleri yakalama (böcekçil bitkiler gibi) işlevleri de vardır.\n-Yapraklar, yaprak ayası ve yaprak sapı olmak üzere iki kısımdan oluşur.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Resim("Yaprak ayası:\nYaprağın yassılaşmış, genişlemiş, ince ve yeşil kısmıdır. Çölde yaşayan bitkilerde yapraklar küçülmüş veya dikene dönüşmüştür. Böyle durumlarda yaprağın görevlerini özümleme parankiması içeren gövde üstlenmiştir.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Gstr("Resimler\\Aya.png", 825, 632);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Resim("Yaprak sapı:\nGövdenin yapısına benzer. Yaprak ayasını gövdeye bağlar ve yaprak ayasının ışıktan verimli şekilde yararlanmasını sağlar. Yaprak sapının gövdeyle birleştiği yer yaprak kını olarak adlandırılır. Birçok tek çenekli bitkide ve bazı çift çenekli bitkilerde yaprak sapı bulunmaz.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Resim("Paralel damarlanma:\nBu damarlanmada orta bölgede belirgin olarak ana damar bulunur. Yan damarlar ana damara paralel olarak uzanır. Buğday, süsen, mısır gibi tek çeneklilerde görülür.");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Resim("Ağsı damarlanma:\nAna damar belirgin olarak kalındır. Ana damardan ince kollar halinde yan damarlar çıkar. Bu kollar daha ince kollara ayrılır. Fasulye, asma, çınar, gül, at kestanesi gibi çift çeneklilerde görülür.");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Gstr("Resimler\\damar.png", 825, 632);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Resim("Yapraklar basit ve bileşik yaprak olmak üzere ikiye ayrılır.\nEğer yaprak, tek bir yaprak ayasından oluşuyorsa basit yaprak, çok sayıda küçük yaprakçıktan oluşuyorsa bileşik yaprak olarak adlandırılır.");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Gstr("Resimler\\yaprak.png", 991, 632);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            YaprakEnine x = new YaprakEnine();
            x.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Resim("Kurak bölge bitkilerinin yaprak özellikleri\n1. Kutikula tabakası kalındır\n2. Yaprak ayası küçüktür. Kaktüs gibi bitkilerde diken şeklini almıştır.\n3. Güneşten koruyan tüyler yoğun olarak bulunur.\n4. Stomalar küçük az sayıdadır. Epidermisin derinliklerine gömülmüştür.\n5. Mezofil tabakası kalındır.\n6. Palizat parankimaı sünger parankimasından gelişmiş, hatta bazılarında mezofil tabakası sadece palizat parankiması içerir.\n7. Hücreler arası boşluk küçük, damarlar belirgindir.");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
