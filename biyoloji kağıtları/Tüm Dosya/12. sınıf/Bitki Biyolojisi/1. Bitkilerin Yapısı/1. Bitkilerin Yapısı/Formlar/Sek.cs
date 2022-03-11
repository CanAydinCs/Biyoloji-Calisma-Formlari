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
    public partial class Sek : Form
    {
        public Sek()
        {
            InitializeComponent();
        }

        public void Resim(string x)
        {
            pictureBox1.Visible = false;
            label1.Text = x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Resim("Kök ve gövdede sekonder büyüme:\n-Bitkinin enine büyümesini (kalınlaşmasını) sağlar. Yanal meristem (kambiyum) tarafından gerçekleştirilir. Açık tohumlu (kozalaklı) bitkilerle odunsu çift çenekli ve bazı otsu çift çenekli bitkilerde görülür. Bu büyümede damar (demet = vasküler) kambiyumu ve mantar kambiyumu olmak üzere iki çeşit yanal meristem görev yapar.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Resim("Not:\nDamar kambiyumu, kök ve gövdenin enine kalınlaşmasını sağlarken iletim doku elemanları olan ksilem (odun boruları) ve floemin (soymuk boruları) oluşmasında da görevlidir. Mantar kambiyumu, sekonder floemin dış kısmında bulunur ve mantar hücrelerini üretir.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Resim("Adım Adım sekonder büyüme olayları:\n-Floem ile ksilem arasında kalan bazı parankima hücreleri hormonların etkisi ile bölünme özelliği kazanarak demet (vasküler) kambiyumu oluşturur.\n-Demet kambiyumunun bölünmesi ile içe doğru sekonder ksilem, dışa doğru sekonder floem meydana gelir.\n-Bu durumda enine büyüme nedeniyle korteks ve epidermis gerilime dayanamayarak parçalanır.\n-Bunun sonucunda mantar kambiyumu meydana gelir.\n-Mantar kambiyumunun bölünmesi ile oluşan mantar doku hücreleri süberin adı verilen mumsu bir madde üreterek sertleşir ve ölür.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Resim("Not:\nBu ölü hücreler, sekonder büyüme sırasında parçalanan epidermis dokularının yerini alan koruyucu mantar dokunun oluşmasını sağlar. Ağacın dış kısmında yer alan mantar doku, bitkiyi mekanik etkilerden ve hastalık yapıcılardan korur. Mantar tabakası ve mantar kambiyumu, birlikte peridermi oluşturur. Periderm ile sekonder floem ise kabuk olarak adlandırılır.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\Sekonder.png";

            label1.Text = "";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Resim("Not:\nPeriderm = Mantar + Mantar Kambiyumu\nKabuk = Periderm + Sekonder Floem");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Halka x = new Halka();
            x.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
