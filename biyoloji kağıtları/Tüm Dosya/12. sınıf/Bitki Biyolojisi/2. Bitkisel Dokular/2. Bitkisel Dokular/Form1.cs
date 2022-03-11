using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Bitkisel_Dokular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sayfalar.Dokular x = new Sayfalar.Dokular();
            x.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sayfalar.Sorular x = new Sayfalar.Sorular();
            x.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
