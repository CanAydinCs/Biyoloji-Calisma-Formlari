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
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        void Gster(int soru, bool ilk, int width, int heigh)
        {
            if (ilk)
            {
                pictureBox1.ImageLocation = "Sorular\\sr" + soru + ".png";
                pictureBox1.Width = width;
                pictureBox1.Height = heigh;
                pictureBox2.Hide();
            }
            else
            {
                pictureBox2.ImageLocation = "Sorular\\cv" + soru + ".png";
                pictureBox2.Width = width;
                pictureBox2.Height = heigh;
                pictureBox2.Show();
            }
        }

        private void Sorular_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
            {
                comboBox1.Items.Add(i + ". Soru");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text[0].ToString())
            {
                case "1":
                    Gster(1, true, 675, 542); break;
                case "2":
                    Gster(2, true, 527, 660); break;
                case "3":
                    Gster(3, true, 451, 660); break;
                case "4":
                    Gster(4, true, 674, 600); break;
                case "5":
                    Gster(5, true, 477, 696); break;
                case "6":
                    Gster(6, true, 477, 696); break;
                case "7":
                    Gster(7, true, 642, 443); break;
                case "8":
                    Gster(8, true, 642, 621); break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text[0].ToString())
            {
                case "1":
                    Gster(1, false, 354, 187); break;
                case "2":
                    Gster(2, false, 354, 187); break;
                case "3":
                    Gster(3, false, 354, 200); break;
                case "4":
                    Gster(4, false, 354, 292); break;
                case "5":
                    Gster(5, false, 354, 218); break;
                case "6":
                    Gster(6, false, 354, 153); break;
                case "7":
                    Gster(7, false, 354, 215); break;
                case "8":
                    Gster(8, false, 354, 74); break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
