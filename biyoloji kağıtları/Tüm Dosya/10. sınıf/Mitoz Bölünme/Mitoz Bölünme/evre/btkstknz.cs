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
    public partial class btkstknz : Form
    {
        public btkstknz()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Bitki hücresinde sitokinez: Hücre zarında bulunan selüloz sentez kompleks proteinleri tarafından sentezlenen selüloz liflerinin golgi tarafından düzenlenmesi ile hücre plağı tamamlanır. Sonuçta ana hücre ile kromozom sayısı, DNA miktarı ve genetik yapısı aynı olan iki yeni hücre oluşur.";
        }

        private void btkstknz_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\bitkisito.png";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Not: Bitki hücrelerindeki hücre duvarı, sitokinezin boğumlanma ile gerçekleşmesini engeller.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
