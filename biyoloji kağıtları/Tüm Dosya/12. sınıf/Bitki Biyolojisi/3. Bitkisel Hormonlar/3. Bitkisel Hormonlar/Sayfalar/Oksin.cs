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
    public partial class Oksin : Form
    {
        public Oksin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "-Bitkinin sürgün uçlarında, genç yapraklarda, gelişmekte olan meyve ve tohumlarda sentezlenir.\n-Büyüme ve gelişmeyi etkileyen en önemli hormondur.\n-Hücre bölünmesini hızlandırır. Hücrelerin uzamasına neden olur.\n-Fototropizma ve jeotropizma olaylarında etkilidir.\n-Yapraklanma ve çiçek açmada, meyve oluşumunda görev yapar.\n-Doku kültürü ile bitki üretiminde de bu hormondan yararlanılır.\n-Bitkinin köklenmesinde ve köklerin farklılaşmasında etkilidir.\n-Fazla salgılanması etilen üretimini uyardığı için büyümeyi engeller.\n-Az salgılanması yaprakların dökülmesine neden olur.\n-Yabani otların yok edilmesinde kullanılır.\n-İletim dokusunun farklılaşmasını uyarır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nEn yaygın ot öldürücü sentetik bir oksindir. Bu sentetik oksin bitkinin büyümesini düzenleyen hormonların dengesini bozarak onları öldürür.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
