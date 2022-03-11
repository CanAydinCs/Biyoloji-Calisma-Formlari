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
    public partial class Hyvnstknz : Form
    {
        public Hyvnstknz()
        {
            InitializeComponent();
        }

        private void Hyvnstknz_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\hayvansito.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hayvan hücresinde sitokinez: Mikroflamentlerden oluşan protein iplikçikler, halka oluşturup sitoplazmanın daralarak boğumlanmasını sağlar.\n-Sonuçta ana hücre ile kromozom sayısı, DNA miktarı ve genetik yapısı aynı olan iki yeni hücre oluşur.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\n-Mitoz sonucu oluşan hücrelerin organel sayısı, sitoplazma miktarı ve büyüklükleri farklı olabilir.";
        }
    }
}
