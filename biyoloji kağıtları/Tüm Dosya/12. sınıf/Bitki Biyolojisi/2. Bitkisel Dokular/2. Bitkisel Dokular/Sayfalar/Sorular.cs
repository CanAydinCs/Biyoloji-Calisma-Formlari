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
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        public void Soru(int s,int s1,int s2)
        {
            pictureBox1.ImageLocation = "Sorular\\sr" + s + ".png";
            pictureBox1.Width = s1;
            pictureBox1.Height = s2;
        }

        public void Cevap(int s,int s1,int s2)
        {
            pictureBox2.ImageLocation = "Sorular\\cv" + s + ".png";
            pictureBox2.Width = s1;
            pictureBox2.Height = s2;
        }

        private void Sorular_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 20; i++)
            {
                comboBox1.Items.Add(i + ". soru");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            string x = comboBox1.Text[0].ToString() + comboBox1.Text[1].ToString();
            switch (x)
            {
                case "1.":
                    Soru(1, 712, 656); break;
                case "2.":
                    Soru(2, 712, 500); break;
                case "3.":
                    Soru(3, 712, 615); break;
                case "4.":
                    Soru(4, 547, 661); break;
                case "5.":
                    Soru(5, 547, 661); break;
                case "6.":
                    Soru(6, 731, 434); break;
                case "7.":
                    Soru(7, 731, 483); break;
                case "8.":
                    Soru(8, 731, 705); break;
                case "9.":
                    Soru(9, 731, 597); break;
                case "10":
                    Soru(10, 731, 342); break;
                case "11":
                    Soru(11, 731, 606); break;
                case "12":
                    Soru(12, 731, 465); break;
                case "13":
                    Soru(13, 731, 674); break;
                case "14":
                    Soru(14, 731, 509); break;
                case "15":
                    Soru(15, 731, 509); break;
                case "16":
                    Soru(16, 731, 543); break;
                case "17":
                    Soru(17, 731, 586); break;
                case "18":
                    Soru(18, 731, 586); break;
                case "19":
                    Soru(19, 731, 677); break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            string x = comboBox1.Text[0].ToString() + comboBox1.Text[1].ToString();
            switch (x)
            {
                case "1.":
                    Cevap(1, 527, 202); break;
                case "2.":
                    Cevap(2, 527, 202); break;
                case "3.":
                    Cevap(3, 527, 252); break;
                case "4.":
                    Cevap(4, 527, 300); break;
                case "5.":
                    Cevap(5, 527, 202); break;
                case "6.":
                    Cevap(6, 527, 202); break;
                case "7.":
                    Cevap(7, 527, 322); break;
                case "8.":
                    Cevap(8, 527, 217); break;
                case "9.":
                    Cevap(9, 527, 159); break;
                case "10":
                    Cevap(10, 527, 135); break;
                case "11":
                    Cevap(11, 527, 404); break;
                case "12":
                    Cevap(12, 527, 123); break;
                case "13":
                    Cevap(13, 527, 350); break;
                case "14":
                    Cevap(14, 527, 135); break;
                case "15":
                    Cevap(15, 527, 391); break;
                case "16":
                    Cevap(16, 527, 300); break;
                case "17":
                    Cevap(17, 527, 300); break;
                case "18":
                    Cevap(18, 527, 177); break;
                case "19":
                    Cevap(19, 527, 397); break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
