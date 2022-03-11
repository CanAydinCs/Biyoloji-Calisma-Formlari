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
    public partial class Hidatot : Form
    {
        public Hidatot()
        {
            InitializeComponent();
        }

        private void Hidatot_Load(object sender, EventArgs e)
        {
            label1.Text = "b. Hidatot (Su savağı):\nYaprak uçlarında ve kenarlarında bulunan açıklıklardır. Geceleri terlemenin olmadığı ya da havanın neme doyduğu zamanlarda alınan fazla suyun sıvı olarak atılmasını sağlar.\nKsilemle bağlantılıdır, stomalar gibi açılıp kapanma özellikleri yoktur.";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
