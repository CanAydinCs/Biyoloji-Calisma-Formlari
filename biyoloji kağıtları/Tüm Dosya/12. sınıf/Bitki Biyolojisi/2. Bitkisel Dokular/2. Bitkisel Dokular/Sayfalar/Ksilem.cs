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
    public partial class Ksilem : Form
    {
        public Ksilem()
        {
            InitializeComponent();
        }

        public void Gstr(string x)
        {
            pictureBox1.Visible = false;
            label1.Text = x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Gstr("Görevleri:\nKökten emici tüylerle alınan su ve suda çözünmüş minerallerin bitkinin gövde ve yapraklarına taşınmasını sağlar.\nAyrıca bitkiye mekanik destek de sağlar.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gstr("Oluşması:\nKsilem, meristem doku hücrelerinin üst üste gelerek zamanla çekirdek ve sitoplazmalarını kaybetmesi sonucu oluşur. Daha sonra hücre duvarı, üzerinde lignin birikimi sonucu kalınlaşır. Hücrelerin uc uca geldiği bölümdeki çeper eriyerek kaybolur ve hücre ölür. Böylece ince kılcal borular halini alır.\n-Ksilemi oluşturan hücreler kısa ve geniş ise trake, ince ve uzun ise trakeit olarak isimlendirilir. Bitkinin odun kısmını meydana getirir.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\ksilem.png";
            label1.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gstr("Odun borularının genel özellikleri:\n-Su ve suda erimiş mineralleri taşır.\n-Madde taşınması kökten yapraklara doğru, tek yönlüdür.\n-Ölü hücrelerden oluşur.\n-Taşıma hızlıdır. (Pasif taşıma kuralları etkilidir)\n-Bitki gövdesinde kambiyumun iç kısmında bulunur.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Gstr("NOT: Odun borularının hücreleri cansız olduğu için madde alışverişi gerçekleşmez. Bu yüzden taşıma hızlıdır.");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Gstr("İletimimin hızlı olmasında ayrıca;\n-İletimin tek yönlü olması\n-İletim sırasında ATP harcanmaması\n-Enine çeperlerin tamamen erimiş olması da rol oynar.");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
