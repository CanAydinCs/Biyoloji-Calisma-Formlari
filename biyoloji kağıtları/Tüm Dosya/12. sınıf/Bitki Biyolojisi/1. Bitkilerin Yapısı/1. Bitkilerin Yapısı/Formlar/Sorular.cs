using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Bitkilerin_Yapısı.Formlar
{
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        public void Soru(int s1,int s2,int s3)
        {
            pictureBox1.ImageLocation = "Sorular\\sr" + s1 + ".png";
            pictureBox1.Width = s2;
            pictureBox1.Height = s3;
        }

        public void Cevap(int s1,int s2,int s3)
        {
            pictureBox2.ImageLocation = "Sorular\\cv" + s1 + ".png";
            pictureBox2.Width = s2;
            pictureBox2.Height = s3;
        }

        private void Sorular_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 16; i++)
            {
                comboBox1.Items.Add(i + ". soru");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "1. soru":
                    Soru(1, 447, 690); break;
                case "2. soru":
                    Soru(2, 636, 690); break;
                case "3. soru":
                    Soru(3, 636, 690); break;
                case "4. soru":
                    Soru(4, 636, 690); break;
                case "5. soru":
                    Soru(5, 834, 690); break;
                case "6. soru":
                    Soru(6, 834, 556); break;
                case "7. soru":
                    Soru(7, 629, 696); break;
                case "8. soru":
                    Soru(8, 626, 532); break;
                case "9. soru":
                    Soru(9, 626, 532); break;
                case "10. soru":
                    Soru(10, 626, 532); break;
                case "11. soru":
                    Soru(11, 569, 662); break;
                case "12. soru":
                    Soru(12, 522, 662); break;
                case "13. soru":
                    Soru(13, 672, 662); break;
                case "14. soru":
                    Soru(14, 672, 662); break;
                case "15. soru":
                    Soru(15, 837, 413); break;
            }
            pictureBox2.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            switch (comboBox1.Text)
            {
                case "1. soru":
                    Cevap(1, 457, 346); break;
                case "2. soru":
                    Cevap(2, 457, 235); break;
                case "3. soru":
                    Cevap(3, 457, 491); break;
                case "4. soru":
                    Cevap(4, 457, 230); break;
                case "5. soru":
                    Cevap(5, 457, 298); break;
                case "6. soru":
                    Cevap(6, 457, 211); break;
                case "7. soru":
                    Cevap(7, 457, 290); break;
                case "8. soru":
                    Cevap(8, 457, 290); break;
                case "9. soru":
                    Cevap(9, 457, 375); break;
                case "10. soru":
                    Cevap(10, 457, 142); break;
                case "11. soru":
                    Cevap(11, 457, 117); break;
                case "12. soru":
                    Cevap(12, 457, 289); break;
                case "13. soru":
                    Cevap(13, 457, 398); break;
                case "14. soru":
                    Cevap(14, 457, 133); break;
                case "15. soru":
                    Cevap(15, 457, 133); break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
