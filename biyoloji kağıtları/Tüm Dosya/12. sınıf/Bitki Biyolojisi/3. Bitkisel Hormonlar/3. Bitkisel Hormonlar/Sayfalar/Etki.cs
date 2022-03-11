using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bitkisel_Hormonlar.Sayfalar
{
    public partial class Etki : Form
    {
        public Etki()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "-Bitkisel hormonlar, aktif büyüme gösteren kök ve gövde uçlarında, meyvelerde ve genç yapraklarda yer alan hücreler tarafından sentezlenir.\n-Bitkisel hormonlar belirli hedef hücrelere taşınır. Hedef hücrelerin hücre zarlarında alıcı (reseptör) moleküller olarak bilinen kimyasallar vardır.\n-Uygun bir hormon hedef hücrelere geldiği zaman bu alıcı moleküller hormonu tanır ve hedef hücrelerin yanıt vermesi sağlanır.\n-Hormonların bir kısmı üretildiği dokuda etkili olurken bir kısmı bitkinin farklı bölgelerinde etkilidir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\tablo.png";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
