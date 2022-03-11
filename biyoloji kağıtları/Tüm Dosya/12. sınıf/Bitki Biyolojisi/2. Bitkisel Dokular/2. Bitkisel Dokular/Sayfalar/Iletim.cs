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
    public partial class Iletim : Form
    {
        public Iletim()
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
            Gstr("Tanım:\n-Bitkilerde köklerle alınan su ve mineralleri, yaprak ve diğer organlara, fotosentezle üretilen organik maddeleri de yapraklardan bitkinin diğer organlarına taşıyan dokudur.\n-Ksilem (odun boruları) ve floem (soymuk boruları) olmak üzere iki çeşittir.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ksilem x = new Ksilem();
            x.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Floem x = new Floem();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.ImageLocation = "Resimler\\ksilemvefloem.png";
            label1.Text = "";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
