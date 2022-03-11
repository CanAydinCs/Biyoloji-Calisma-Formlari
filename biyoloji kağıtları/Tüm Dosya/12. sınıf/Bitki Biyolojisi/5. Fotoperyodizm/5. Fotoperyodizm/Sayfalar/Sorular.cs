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
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        void Soru(int soru_no, bool cevap, int width, int height)
        {
            if (cevap)
            {
                pictureBox1.ImageLocation = "Sorular\\sr" + soru_no + ".png";
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                pictureBox2.Hide();
            }
            else
            {
                pictureBox2.ImageLocation = "Sorular\\cv" + soru_no + ".png";
                pictureBox2.Width = width;
                pictureBox2.Height = height;
                pictureBox2.Show();
            }
        }

        private void Sorular_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                comboBox1.Items.Add(i + ". Soru");
            }
            pictureBox3.ImageLocation = "Sorular\\sr22.png";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            switch (comboBox1.Text[0].ToString())
            {
                case "1":
                    Soru(1, true, 497, 682); break;
                case "2":
                    Soru(2, true, 497, 682); pictureBox3.Show(); break;
                case "3":
                    Soru(3, true, 497, 682); break;
                case "4":
                    Soru(4, true, 497, 323); break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text[0].ToString())
            {
                case "1":
                    Soru(1, false, 445, 245); break;
                case "2":
                    Soru(2, false, 445, 245); break;
                case "3":
                    Soru(3, false, 445, 245); break;
                case "4":
                    Soru(4, false, 445, 206); break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
