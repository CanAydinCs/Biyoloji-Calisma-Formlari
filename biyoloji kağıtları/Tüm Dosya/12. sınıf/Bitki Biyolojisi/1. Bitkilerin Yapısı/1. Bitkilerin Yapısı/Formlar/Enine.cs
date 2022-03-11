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
    public partial class Enine : Form
    {
        public Enine()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Epidermis:\nGenç kökün en dış yüzeyinde bulunur ve kütikula tabakası içermez.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Korteks:\nEpidermis ile merkezi silindir arasında kalan kök bölgesidir. Klorofilsiz, ince çeperli korteks parankiması hücreleri bulunur. Çoğunlukla nişasta depo edilir.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Endodermis tabakası:\nTek sıralı hücrelerden oluşur. Korteks ile merkezi silindiri birbirinden ayırır. Emici tüylerin aldığı su ve minerallerin ksileme aktarılmasında etkilidir.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Merkezi silindir:\nKökün merkezinde iletim demetlerini kapsayan bölümdür. Çok yıllık bitkilerde merkezi silindirde ksilem yıldız şeklinde, floem yıldızın kolları arasında bulunur. Ksilemin yıldız şekline uymuş kambiyum halkası bulunur.\n-Kambiyum hücreleri bölünerek merkeze doğru ksilemi, dışa doğru floemi oluşturur. Her büyüme döneminde yeni ksilem ve floem oluşturulur. Bu şekilde sekonder büyüme (kökte enine kalınlaşma) ile kök enine büyür, kalınlaşır.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\Eninekst.png";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Not:\nTek çenekli ve çift çenekli bitki kökleri arasındaki en önemli fark merkezi silindirdeki dokuların düzenlenişidir.\n-Çift çenekli bitki köklerinde öz bulunmaz.\n-Tek çenekli bitki köklerinde kambiyum bulunmaz. İletim demetleri düzensiz dağılım gösterir. (Kapalı İletim Demeti)\n-Çift çenekli bitki kökünde kambiyum bulunur. İletim demetleri düzenli dağılım gösterir. (Açık İletim Demeti)";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
