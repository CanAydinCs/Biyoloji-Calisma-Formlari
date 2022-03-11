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
    public partial class Kollenkima : Form
    {
        public Kollenkima()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Tanım:\n-Büyümekte ve gelişmekte olan bitkilerin genç gövdelerinde, yaprağın orta damarında, çiçek ve yaprak saplarında bulunur.\n-Eğilme, bükülme ve çarpmaya karşı bitkiye mekanik destek sağlayan, çeperi kalınlaşmış hücrelerden oluşan dokudur.\n-Kalınlaşma hücre çeperlerinde selüloz ve pektin birikmesiyle oluşur.\n-Sitoplazma ve çekirdekleri bulunur.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "A) Köşe kollenkiması:\nÇeper kalınlaşması hücrenin köşelerinde olmuştur.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "B) Levha kollenkiması:\nKalınlaşma hücre çeperine paralel olarak ortaya çıkmıştır.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
