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
    public partial class Sklerankima : Form
    {
        public Sklerankima()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Tanım:\n-İlk oluştuklarında canlı olan bu hücreler, zamanla çeper kalınlaşması ve buna bağlı madde alışverişi yapamamasından dolayı ölür.\n-Sitoplazma ve çekirdekleri yoktur.\n-Hücrelerinin çeperleri selüloz ve lignin (odun özü) gibi maddelerin birikimi ile kalınlaşmıştır.\n-Genellikle sklerankima lifleri hariç serttir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "a) Sklerankima lifleri: Sivri uçlu dar ve uzu hücrelerdir.\n-Sarımsak, keten, kenevir gibi bitkilerde bulunur.\n-Bu lifler demetler halinde bulunur ve bitkiye destek sağlar.\n-Ketenden elde edilen lifler işlenerek elbise yapımında, kenevir lifleri ise halat yapımında kullanılır.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "b) Taş hücreleri: Taş hücrelerinin yaklaşık olarak üç boyutu eşittir.\n-Taş hücreleri ceviz ve fındık gibi sert kabuklu meyvelerin kabuğunda, tohum kabuklarında, şeftali gibi meyvelerin çekirdeklerinde, ayva, armut gibi meyvelerin kabuk ve yenen etli kısımlarında bulunur.";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
