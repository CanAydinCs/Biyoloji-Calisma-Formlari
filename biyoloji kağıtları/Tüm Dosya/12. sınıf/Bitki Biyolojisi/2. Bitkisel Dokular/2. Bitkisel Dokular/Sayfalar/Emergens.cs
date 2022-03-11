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
    public partial class Emergens : Form
    {
        public Emergens()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "d) Emergensler (dikenler):\nBitkinin hayvanlara karşı korunmasında etkili olan yapılardır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nBitkilerde diken diye bilinen yapılar 3 farklı tiptedir. Akasya bitkisinde görülen dikenler dalın farklılaşmasıyla oluşur (yani gövdeden farklılaşmış); kaktüslerde gözlenen dikenler, yaprağın farklılaşması ile oluşmuş (yani yapraktan farklılaşmıştır). Bu iki yapının her ikisinde de iletim demetleri bulunur. Ancak tipik olarak gül bitkisinde görülen dikenler (emergensler) korteks ve epidermisten gelişir; bu nedenle iletim demeti içermez.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
