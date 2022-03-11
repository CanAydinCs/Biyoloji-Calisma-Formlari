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
    public partial class Parankima : Form
    {
        public Parankima()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "A) Parankima:\nBitkide bütün organların temel yapısını oluşturan doku çeşididir. Bitkinin her organında bulunur.\n-Parankima hücreleri genellikle canlı, ince çeperli ve bol sitoplazmalı, küçük kofulludur. Ancak zamanla canlılıklarını kaybettiği de görülür. (Ağaç kabuklarında olduğu gibi)\n\n-Görevlerine göre 4 çeşit parankima bulunur.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "1) Özümleme Parankiması:\nYaprağın mezofil tabakasında, otsu gövdede ve genç gövdelerde bulunur.\n-Özümleme parankimasını palizat ve sünger parankiması hücreleri oluşturur.\n-Bol kloroplastlıdır. Işıklı ortamda fotosentez yapar. Bitkinin organik besin ihtiyacını karşılar.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "2) İletim parankiması:\nÖzümleme yapan dokularla iletim demetleri arasında bulunur. Bu iki doku arasında su ve besin taşınmasını sağlar. Hücrelerinde kloroplastları yoktur.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "3) Depo parankiması:\nFotosentez ile üretilen besinin fazlasının depolandığı dokudur. Kök, gövde, meyve ve tohumlarda bulunur. Su ve besin depolar.\nÖrneğin; patateste nişasta, fasulyede protein, fındıkta yağ, kaktüste su depolar.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text = "4) Havalandırma parankiması:\nSu ve bataklık bitkilerinde bulunur. Hücreler arası boşluğun fazla olduğu parankima çeşididir. Dışarıdan alınan gazları hücreler arası boşluklarda depo eder. Bitkinin gaz alışverişini kolaylaştırır.";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
