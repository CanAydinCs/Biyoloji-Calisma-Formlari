using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitoz_Bölünme.evre
{
    public partial class Telofaz : Form
    {
        public Telofaz()
        {
            InitializeComponent();
        }
        

        private void Telofaz_Load(object sender, EventArgs e)
        {
            label1.Text = "-Bir nevi profaz evresinin tersi olayların gerçekleştiği evredir.\n-İğ iplikleri kaybolur.\n-Kromozomlar kromatin iplik haline gelir.\n-Çekirdek zarı ve çekirdekçik yeniden oluşur.\n-Bitki hücresinde sitokinez başlar.";
            pictureBox1.ImageLocation = "Resimler\\tlfz.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "-Bir nevi profaz evresinin tersi olayların gerçekleştiği evredir.\n-İğ iplikleri kaybolur.\n-Kromozomlar kromatin iplik haline gelir.\n-Çekirdek zarı ve çekirdekçik yeniden oluşur.\n-Bitki hücresinde sitokinez başlar.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not: Mitoz sonucu oluşan hücrelerin kromozom sayısının ve yapısının aynı kalmasının sebebi bu evredeki kardeş kromatit ayrılmasıdır.";
        }
    }
}
