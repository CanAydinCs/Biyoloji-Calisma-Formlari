using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Bitki_Hareketleri.Sayfalar
{
    public partial class Nasti : Form
    {
        public Nasti()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "2) Nasti Hareketleri:\nBitkilerin uyaranın yönüne bağlı olmaksızın gerçekleştirdikleri harekete denir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\n-Nasti hareketleri turgır basıncının değişimleri ile sağlanır.\n-Nastide, uyartı hangi yönden gelirse gelsin bitki bütün kısımları ile uyarana tepki gösterir. Bunun için nastide (+),(-) durumları yoktur.\n-Nasti hareketlerine neden olan uyaranlar ısı, ışık, sarsılma, dokunma gibi dış çevre faktörleridir.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "a) Fotonasti:\nÇiçeklerin ortamdaki ışık şiddetine bağlı olarak açılıp kapanmasıdır. Örneğin akşamsefasının çiçekleri gündüz ışık şiddetine bağlı olarak kapanıp karanlıkta açılması.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "b) Termonasti:\nBitkilerde sıcaklık değişmelerinin sebep olduğu nasti hareketidir. Bu hareketler çiçeklerde sık görülür.\n-Henüz tam açılmamış olan bir lale bulunduğu ortamdan 10-15 0C daha sıcak bir ortama konulursa birkaç dakika içinde çiçek tam açılır. Eğer aynı lale tekrar önceki ortamına alınırsa düşük sıcaklığın etkisiyle lalenin taç yaprakları kapanır.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text = "c) Sismonasti:\nBitkide sarsıntı ve dokunma ile meydana gelen turgor değişimleri sonucu ortaya çıkan hareketlerdir.\n-Küstüm otunun (Mimoza pudica) yapraklarının kapanması, Böcekçil bitkinin yapraklarının böceğin yaprağa dokunmasıyla kapanması örnek verilebilir.";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
