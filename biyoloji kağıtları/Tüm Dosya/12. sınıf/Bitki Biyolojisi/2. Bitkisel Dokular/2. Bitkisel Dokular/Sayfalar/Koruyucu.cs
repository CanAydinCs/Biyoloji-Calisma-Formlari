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
    public partial class Koruyucu : Form
    {
        public Koruyucu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Örtü doku; kök, gövde, yaprak ve meyvelerin üzerini örten dokudur. Epidermis ve peridermisten oluşur.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Epidermis x = new Epidermis();
            x.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Pridermis x = new Pridermis();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
