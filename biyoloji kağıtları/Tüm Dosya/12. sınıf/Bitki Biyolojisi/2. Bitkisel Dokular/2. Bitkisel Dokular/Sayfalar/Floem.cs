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
    public partial class Floem : Form
    {
        public Floem()
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
            Gstr("Görevi:\nYapraklarda fotosentez ile üretilen ve köklerden alınan organik maddeleri bitkinin diğer kısımlarına iletmektir.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gstr("Oluşması:\n-Tek sıra halinde uc uca dizilmiş canlı hücrelerden oluşan bu doku kalburlu hücre ve arkadaş hücresi olmak üzere iki tip hücreden oluşmuştur.\n-Kalburlu hücrelerin sitoplazmaları ve mitokondrileri vardır fakat çekirdek, merkezi koful ve ribozomlarını kaybederler.\n-Kalburlu hücrelerin birbirlerine komşu çeperlerinin yer yer erimesi ile delikli bir yapı oluşur. Bu yapıya kalburlu plak denir. Kalburlu plağa sahip hücrelerin üst üste dizilmesi ile oluşan boru şeklindeki yapıya da kalburlu borular denir.\n-Arkadaş hücreleri ise yoğun sitoplazmalı ve çekirdeklidir.\n-Çekirdeğe sahip arkadaş hücreleri fotosentez ürünlerinin depolanması ve iletilmesi işlemlerinde kalburlu hücrelerle birlikte çalışır.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Gstr("Soymuk borularının genel özellikleri\n-Fotosentez ürününü olan organik maddeleri köke, kökte üretilen aminoasitleri yaprak ve diğer organlara taşır.\n-Madde taşınması çift yönlüdür.\n-Canlı hücrelerden oluşur.\n-Hücreleri canlı olduğu için madde alışverişi gerçekleşir. Bu yüzden taşıma hızı odun borularından daha yavaştır.\n-İletimde hem aktif taşıma hem de pasif taşıma etkilidir.\n-Bitki gövdesinde kambiyumun dış kısmında bulunur.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gstr("NOT:\nBir kalburlu boruda madde taşınması aynı anda çift yönlü olarak gerçekleşmez.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\floem.png";
            label1.Text = "";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
