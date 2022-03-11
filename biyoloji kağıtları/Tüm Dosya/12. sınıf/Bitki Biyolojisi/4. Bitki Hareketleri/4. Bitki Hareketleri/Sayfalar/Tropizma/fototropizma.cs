using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Bitki_Hareketleri.Sayfalar.Tropizma
{
    public partial class fototropizma : Form
    {
        public fototropizma()
        {
            InitializeComponent();
        }

        public void Gizle(string x)
        {
            pictureBox1.Visible = false;
            label1.Text = x;
        }

        private void Fototropizma_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\fototropizma.png";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Gizle("a) Fototropizma:\nBitkinin ışığa karşı gösterdiği yönelme hareketidir. Örneğin pencere önüne konan bir bitkinin güneşe doğru yönelmesi pozitif fototropizmadır.\n-Bitkide büyümeyi sağlayan oksin hormonu Işık alan tarafta az, ışık almayan tarafta daha fazla bulunur. Bu nedenle ışık almayan taraftaki hücreler daha hızlı çoğalır, daha büyüktür. Bu da bitki gövdesinin güneşe doğru yönelmesine neden olur.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Gizle("-Fototropizma hakkında bilinenlerin pek çoğu, özellikle yulaflar olmak üzere, çimen fidelerinin üzerinde yapılan çalışmalardan elde edilmiştir. Koleoptil ucu kesildğinde veya ışık geçirmeyen bir başlık ile kapatıldığında, koleoptil ışığa doğru yönelmez. Buna karşılık koleoptil uç açık bırakıldığında ya da ışığı geçiren bir başlık ile kapatıldığında ışığa doğru yönelir. Bu durum ışığın algılanmasında koleoptil ucunun sorumlu olduğu ve uç kısımdan kıvrımın oluşacağı alt kısımlara bazı sinyaller gönderildiği göstermektedir.\n-Daha sonra yapılan çalışmalar ile sinyalin hareketli bir kimyasal madde olduğunu göstermiştir. Araştırmacı, koleoptil ucunu, hücreler arasındaki teması kesen fakat kimyasalların geçişine izin veren jelatin bir blokla koleoptilin diğer kısımlarından ayırmıştır. Bu fideler, ışığa doğru kıvrılarak yönelmişlerdir. Koleoptil ucu, alt kısmından geçirimsiz bir engelle (mika ile) ayrıldığında koleoptillerde yönelim olmamıştır.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gizle("Not:\nKeloptilin ışığa doğru büyümesinde oksin hormonunun asimetrik dağılımı (doğrudan ışık gelen taraf azi ışık gelmeyen tarafta çok olması) rol oynamaktadır. Oksin, kleoptilin ucunda büyüme bölgesinde taşınmakta ve ışık almayan taraftaki hücrelerin daha hızlı büyümesini sağlayarak asimetrik büyüme ile oşoğa yönelim gerçekleşmektedir.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Tablo x = new Tablo();
            x.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
