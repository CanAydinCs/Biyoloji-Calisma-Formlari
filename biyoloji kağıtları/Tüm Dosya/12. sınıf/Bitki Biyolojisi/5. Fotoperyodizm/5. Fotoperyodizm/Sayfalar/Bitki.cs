using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Fotoperyodizm.Sayfalar
{
    public partial class Bitki : Form
    {
        public Bitki()
        {
            InitializeComponent();
        }

        void Gstr(string y)
        {
            if(y == "1")
            {
                pictureBox1.ImageLocation = "Resimler\\kısa.png";
            }
            else
            {
                pictureBox1.ImageLocation = "Resimler\\light.png";
            }
            pictureBox1.Show();
            label1.Text = "";
        }

        void Gizle(string x)
        {
            pictureBox1.Hide();
            label1.Text = x;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Gizle("3) Nötr bitkiler\n-Gün uzunluğundan etkilenmeyen bitkilerdir. Bu bitki türleri fotoperiyottan etkilenmez. Bu nedenle bu bitkiler uzun gün ve kısa gün bitkilerinden daha avantajlıdır.\n-Pamuk, ayçiçeği, pirinç, domates ve karahindibalar nötr gün bitkilerine örnek olarak verilebilir.");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gizle("Not:\nBaşlangıçta botanikçiler bitkileri kısa gün bitkileri ve uzun gün bitkileri olarak isimlendirmişlerdir. Ancak artık bitkinin çiçeklenmesini etkileyen faktörün, gün uzunluğu değil gece uzunluğu olduğu tespit edilmiştir. Bundan dolayı kısa gece bitkileri, uzun gece bitkileri isimlendirmesi daha uygundur.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Gstr("1");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gizle("-Normalde uzun gecede çiçeklenmeyen bir uzun gün bitkisi, sürekli karanlık periyodonun birkaç dakikalık ışık verilerek bozulması halinde çiçeklenir. (A)\n-Normalde uzun gecede çiçeklenen bir kısa gün bitkisi, sürekli karanlık periyodonun birkaç dakikalık ışık verilerek bozulması halinde çiçeklenmez. (B)");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Gstr("0");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
