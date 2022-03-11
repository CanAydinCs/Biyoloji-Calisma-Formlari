using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitoz_Bölünme.sorular
{
    public partial class srkısım1 : Form
    {
        public srkısım1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Soru 1")
                pictureBox1.ImageLocation = "Soru\\sr1.png";
            else if (comboBox1.Text == "Soru 2")
                pictureBox1.ImageLocation = "Soru\\sr2.png";
            else if (comboBox1.Text == "Soru 3")
                pictureBox1.ImageLocation = "Soru\\sr3.png";
            else if (comboBox1.Text == "Soru 4")
                pictureBox1.ImageLocation = "Soru\\sr4.png";
            else if (comboBox1.Text == "Soru 5")
                pictureBox1.ImageLocation = "Soru\\sr5.png";
            else if (comboBox1.Text == "Soru 6")
                pictureBox1.ImageLocation = "Soru\\sr6.png";
            else if (comboBox1.Text == "Soru 7")
                pictureBox1.ImageLocation = "Soru\\sr7.png";
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            if (radioButton1.Checked)
            {switch (comboBox1.Text)
                {
                    case "Soru 1":
                        pictureBox2.ImageLocation = "Soru\\cvp1.png";
                        break;
                    case "Soru 2":
                        pictureBox2.ImageLocation = "Soru\\cvp2.png";
                        break;
                    case "Soru 3":
                        pictureBox2.ImageLocation = "Soru\\cvp3.png";
                        break;
                    case "Soru 4":
                        pictureBox2.ImageLocation = "Soru\\cvp4.png";
                        break;
                    case "Soru 5":
                        pictureBox2.ImageLocation = "Soru\\cvp5.png";
                        break;
                    case "Soru 6":
                        pictureBox2.ImageLocation = "Soru\\cvp6.png";
                        break;
                    case "Soru 7":
                        pictureBox2.ImageLocation = "Soru\\cvp7.png";
                        break;
                }
            }
            else if (radioButton2.Checked)
            {
                switch (comboBox2.Text)
                {
                    case "Soru 1":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp1.png";
                        break;
                    case "Soru 2":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp2.png";
                        break;
                    case "Soru 3":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp3.png";
                        break;
                    case "Soru 4":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp4.png";
                        break;
                    case "Soru 5":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp5.png";
                        break;
                    case "Soru 6":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp6.png";
                        break;
                    case "Soru 7":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp7.png";
                        break;
                    case "Soru 8":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp8.png";
                        break;
                    case "Soru 9":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp9.png";
                        break;
                    case "Soru 10":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp10.png";
                        break;
                    case "Soru 11":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp11.png";
                        break;
                    case "Soru 12":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp12.png";
                        break;
                    case "Soru 13":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp13.png";
                        break;
                    case "Soru 14":
                        pictureBox2.ImageLocation = "Soru\\ks2cvp14.png";
                        break;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = false;
                comboBox2.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
                comboBox1.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Soru 1" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr1.png";
            else if (comboBox2.Text == "Soru 2" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr2.png";
            else if (comboBox2.Text == "Soru 3" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr3.png";
            else if (comboBox2.Text == "Soru 4" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr4.png";
            else if (comboBox2.Text == "Soru 5" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr5.png";
            else if (comboBox2.Text == "Soru 6" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr6.png";
            else if (comboBox2.Text == "Soru 7" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr7.png";
            else if (comboBox2.Text == "Soru 8" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr8.png";
            else if (comboBox2.Text == "Soru 9" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr9.png";
            else if (comboBox2.Text == "Soru 10" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr10.png";
            else if (comboBox2.Text == "Soru 11" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr11.png";
            else if (comboBox2.Text == "Soru 12" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr12.png";
            else if (comboBox2.Text == "Soru 13" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr13.png";
            else if (comboBox2.Text == "Soru 14" && radioButton2.Checked)
                pictureBox1.ImageLocation = "Soru\\ks2sr14.png";
            pictureBox2.Visible = false;
        }

        private void srkısım1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
    }
}
