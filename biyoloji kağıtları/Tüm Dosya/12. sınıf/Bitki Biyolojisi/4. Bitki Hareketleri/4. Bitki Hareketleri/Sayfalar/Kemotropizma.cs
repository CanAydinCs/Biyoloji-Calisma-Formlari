using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Bitki_Hareketleri.Sayfalar
{
    public partial class Kemotropizma : Form
    {
        public Kemotropizma()
        {
            InitializeComponent();
        }

        private void Kemotropizma_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\kemotropizma.png";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label1.Text = "d) Kemotropizma:\nBitki köklerinin toprakta bulunan çeşitli kimyasal maddelere karşı gösterdiği tropizma hareketleridir.\n-Bitkinin kökleri gübre ve besin maddelerine pozitif, tuza, kirece karşı negatif kemotropizma gösterir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            label1.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
