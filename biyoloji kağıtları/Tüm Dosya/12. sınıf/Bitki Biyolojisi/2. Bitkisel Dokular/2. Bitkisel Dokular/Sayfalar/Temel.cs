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
    public partial class Temel : Form
    {
        public Temel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Text = "Tanım:\n-Birincil ve ikincil meristem doku hücrelerinin farklılaşmasıyla ve bölünme özelliklerini yitirmesi ile oluşur.\n-Temel dokuyu, parankima, kollenkima ve sklerankima adı verilen hücreler oluşturur.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Parankima parankima = new Parankima();
            parankima.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Kollenkima x = new Kollenkima();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Sklerankima x = new Sklerankima();
            x.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\KollenkimaTablo.png";
            label1.Text = "";
        }
    }
}
