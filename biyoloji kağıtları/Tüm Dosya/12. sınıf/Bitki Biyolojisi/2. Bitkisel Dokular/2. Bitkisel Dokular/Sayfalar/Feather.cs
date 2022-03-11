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
    public partial class Feather : Form
    {
        public Feather()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "c) Tüyler:\nEpidermis hücrelerinin dışarıya doğru meydana getirdikleri uzantılardır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Koruma:\nBitkiyi aşırı ısınma ve su kaybından korur.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Savunma:\nTüylerin uç kısımlarında silis ve kalker birikmesi ile sert ve batıcı bir özellik kazanırlar. Hayvanlar bu bitkileri yemekten çekinir. Isırgan otunda ise kofullarında asidik hücre özsuyu bulunur, hayvanlara zarar verir.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Tutunma:\nSarmaşık gibi bazı sarılıcı ve tırmanıcı bitkilerde tutunmayı sağlar.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Emme:\nKök emici tüyleri topraktaki su ve suda çözünmüş mineralleri emer.";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Salgı yapma:\nFarklı kimyasal özellikte salgı üretebilen tüylerdir.";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
