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
    public partial class Temel : Form
    {
        public Temel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "1) Tropizma Hareketleri:\nBitkilerin çevreden gelen uyaranın yönüne bağlı olarak gerçekleştirdiği tepkidir.\n-Tropizma hareketleri, bitkilerin sadece büyüyen ve uzayan kısımlarında meydana gelir.\n-Eğer hareket uyarana doğru ise pozitif, zıt yönde ise negatif tropizma olarak adlandırılır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            fototropizma x = new fototropizma();
            x.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Geotropizma.Geotropizma x = new Geotropizma.Geotropizma();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "c) Haptotropizma:\nBitkilerin dokunmaya karşı gösterdikleri tepkilere denir. Özellikle sarılıcı bitkiler destek dokusu zayıf olduğu için dik duramaz ve destek arar.\n-Örneğin sarmaşıkların desteğe temas ettiğinde sarılması pozitif haptotropizmadır.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Kemotropizma x = new Kemotropizma();
            x.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Text = "e) Travmatropizma:\nBitki organlarının yaralanma nedeniyle gösterdikleri yönelme hareketlerine denir.\n-Özellikle köklerde görülür. Bitkinin kökü yaralanırsa yaralanan bölgeden bir çeşit hormon salgılanır. Salgılanan bu hormonun etkisiyle kök, yara yönünün tersine doğru yönelir. Yara yıkanırsa hormon kaybolduğundan böyle bir tropizma görülmez.\n-Genç bir bakla fidesi petri kutusunda ıslak filtre kâğıdı üzerine konur ve kök ucuna kızgın iğne dokundurularak yakılırsa yani orada bir yara oluşturulursa kökün yaradan uzaklaşarak aksi tarafa yöneldiği görülür. (Negatif travmatropizma)";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.Text = "f) Hidrotropizma:\nBitki köklerinin suya doğru yönelim göstermesine denir. Hidrotropizma her zaman pozitiftir.";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
