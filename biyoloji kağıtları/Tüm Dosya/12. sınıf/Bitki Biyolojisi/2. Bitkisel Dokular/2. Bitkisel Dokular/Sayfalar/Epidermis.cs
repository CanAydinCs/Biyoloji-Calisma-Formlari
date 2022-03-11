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
    public partial class Epidermis : Form
    {
        public Epidermis()
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
            Gstr("Tanım:\nTek sıra hücrelerden oluşan bitkinin yaprak, genç gövde ve kök gibi yapıların üzerini örten en dış tabakadır.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Text = "";
            pictureBox1.ImageLocation = "Resimler\\epidermis.png";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gstr("Özellikleri:\n-Hücreleri büyük kofullu, az sitoplazmalıdır.\n-Kloroplast bulunmaz, fotosentez yapmaz.\n-Hücrelerinin arasında boşluk bulunmaz.\n-Genellikle tek sıra halinde dizilir.");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gstr("-Epidermis hücrelerinin dışarıya bakan yüzeyinde su kaybını önleyen mumsu yapıda kutin denilen madde birikimi ile oluşan kutikula tabakası bulunur.\n-Kütükula tabakası bitkiyi su kaybından ve mekanik etkilerden korur.\n-Nemli ortam bitkilerinin kutikulası ince, kurak ortam bitkilerinin ise kalındır.\n\nNOT: Bitkinin toprak altı organlarında (kök sisteminde) kütikula tabakası bulunmaz. Stoma oluşturmaz.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Stoma x = new Stoma();
            x.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Hidatot x = new Hidatot();
            x.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Feather x = new Feather();
            x.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Emergens x = new Emergens();
            x.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
