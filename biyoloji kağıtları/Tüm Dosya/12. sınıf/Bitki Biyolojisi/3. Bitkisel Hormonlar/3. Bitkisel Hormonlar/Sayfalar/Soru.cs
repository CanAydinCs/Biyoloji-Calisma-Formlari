using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bitkisel_Hormonlar.Sayfalar
{
    public partial class Soru : Form
    {
        public Soru()
        {
            InitializeComponent();
        }

        public void Gstr(int s,int s1,int s2,bool x)
        {
            if (x)
            {
                pictureBox1.ImageLocation = "Sorular\\sr" + s + ".png";
                pictureBox1.Width = s1;
                pictureBox1.Height = s2;
            }
            else
            {
                pictureBox2.ImageLocation = "Sorular\\cv" + s + ".png";
                pictureBox2.Width = s1;
                pictureBox2.Height = s2;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            switch (comboBox1.Text[0].ToString())
            {
                case "1":
                    Gstr(1, 533, 562, true); break;
                case "2":
                    Gstr(2, 460, 635, true);
                    pictureBox3.Visible = true;
                    pictureBox3.ImageLocation = "Sorular\\sr21.png";
                    break;
                case "3":
                    Gstr(3, 602, 382, true); break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            switch (comboBox1.Text[0].ToString())
            {
                case "1":
                    Gstr(1, 339, 161, false); break;
                case "2":
                    Gstr(2, 339, 452, false); break;
                case "3":
                    Gstr(3, 339, 150, false); break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
