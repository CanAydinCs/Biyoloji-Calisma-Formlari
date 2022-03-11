using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitoz_Bölünme
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "İnterfaz evresi: İki mitoz arasında gerçekleşen, bölünmeye hazırlık evresidir. Bölünme evresi değildir. Bölünme evresi interfazdan sonra başlar. Bu evrede daha sonraki evreler için gerekli olan maddeler sentezlenir.\n-İnterfaz, ökaryot hücrelerde döngünün yaklaşık %90’ını kapsar.\nÖrneğin insanın deri hücresinde döngü 24 saat sürer ve bunun neredeyse 22 saati interfazda geçer.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.Visible = true;
            else
                pictureBox1.Visible = false;
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            pictureBox1.ImageLocation = "Resimler\\mtztablo.png";
            pictureBox2.ImageLocation = "Resimler\\interhyvn.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-Mitokondri ve ribozom gibi organellerin sayısı artırılır.\n-DNA molekülü kendi eşler (replikasyon). DNA ile bir araya gelen histon proteinleri kromatin adını alır ve kromatinlerin miktarı da iki katına çıkmış olur.\n-Varsa sentrozom eşlenmesi gerçekleşir.\n-ATP, RNA ve protein sentezi de hızlanır.\n-Hızlanan metabolizmayı kontrol etmesi için enzimler sentezlenir.\n-Bu olayların gerçekleşmesi sonucunda hücrenin sitoplazma miktarı artar ve hücrenin büyüdüğü gözlenir. Sitoplazma miktarının bu kadar artması sonucunda hücre zarı sitoplazmanın ihtiyaçlarını karşılayamaz hâle gelir.\n-Çekirdek bölünme emrini verir.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "-Hayır. Erişkin hayvanlarda bazı hücrelerin (örneğin sinir, sperm, yumurta ve kas hücreleri) bölünmesi tümüyle durmuştur. Karaciğer gibi bazı iç organların hücreleri de sadece yaralanma ya da hücre ölümü sonucu kaybedilen hücrelerin yenilenmesi gerektiğinde bölünürler.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nİnterfaz evresindeki bir hücre dinlenme durumunda değildir. Embriyonik hücre döngüsünün interfazında DNA eşlenmesi görülürken hücrelerde büyüme görülmez. Kısa sürede ve hızla çoğalırlar.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nİnterfazdaki DNA eşlenmesi ile hücrenin DNA miktarı iki katına çıkar. Bunun sonucunda tek kromatitli bir kromozom iki kromatitli bir kromozom haline gelir. Yani kromozom sayısı değişmez.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nİnterfaz evresindeki bir hücre dinlenme durumunda değildir. Embriyonik hücre döngüsünün interfazında DNA eşlenmesi görülürken hücrelerde büyüme görülmez. Kısa sürede ve hızla çoğalırlar.";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                pictureBox2.Visible = true;
            else
                pictureBox2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
