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
    public partial class Kkcesit : Form
    {
        public Kkcesit()
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
            Resim("1. Saçak kök:\nGövdenin kökle birleştiği yerden hemen hemen aynı uzunlukta çok sayıda yan kökün oluşturduğu köklerdir. Ana kök iyi gelişmemiştir.\n-Tek çenekli bitkilerin kökleri saçak köktür.\n-Soğan, buğday, çuha çiçeği, mısır, çilek, arpa, pırasa gibi bitkilerin kökleri örnektir.\n-Erozyonun önlenmesinde etkilidir.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Resim("2. Kazık kök:\nAna kök iyi gelişmiş, kalınlaşmış ve toprağın içine doğru uzamıştır. Yan kökler ise ana köke bağlıdır ve az gelişmiştir.\n-Çift çenekli bitkilerin kökleri kazık köktür.\n-Ebegümeci, fasulye, havuç, lahana, bakla, bamya, gelincik ve odunsu bitki kökleri örnektir.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\Kk.png";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
