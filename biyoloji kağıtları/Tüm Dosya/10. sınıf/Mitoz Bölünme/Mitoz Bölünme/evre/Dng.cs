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
    public partial class Dng : Form
    {
        public Dng()
        {
            InitializeComponent();
        }
        
        private void Dng_Load(object sender, EventArgs e)
        {
            label3.Text = "Hücre Döngüsü:\n-Bir hücrenin bölünmeye başlamasından itibaren onu takip eden diğer hücre bölünmesine kadar geçen zaman aralığına hücre döngüsü denir.\n-Hücre döngüsü interfaz ve mitotik (M) evreden oluşur.\n\n\n";
            pictureBox1.ImageLocation = "Resimler\\dngtablo.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Interfaz x = new Interfaz();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profaz x = new Profaz();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Metafaz x = new Metafaz();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anafaz x = new Anafaz();
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Telofaz x = new Telofaz();
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btkstknz x = new btkstknz();
            x.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hyvnstknz x = new Hyvnstknz();
            x.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tablo x = new Tablo();
            x.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            aendomitoz x = new aendomitoz();
            x.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kontrol x = new kontrol();
            x.Show();
        }
    }
}
