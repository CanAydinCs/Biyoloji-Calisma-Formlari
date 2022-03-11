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
    public partial class Tablo : Form
    {
        public Tablo()
        {
            InitializeComponent();
        }

        private void Tablo_Load(object sender, EventArgs e)
        {
            label1.Text = "İnterfazdaki DNA eşlenmesinden sonra profazda ve metafazda kromozomlar çift kromatitlidir. Anafazda kromatitler ayrılır. Dolayısı ile anafaz ve telofazda kromozomlar tek kromatitlidir.";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                pictureBox1.ImageLocation = "Resimler\\tablo1.png";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                pictureBox1.ImageLocation = "Resimler\\tablo2.png";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                pictureBox1.ImageLocation = "Resimler\\tablo3.png";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                pictureBox1.ImageLocation = "Resimler\\tablo4.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
