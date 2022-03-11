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
    public partial class Stoma : Form
    {
        public Stoma()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Genellikle bitkilerin yeşil kısımlarında, özellikle yaprak ve gövde epidermisinde bulunur.\n-Bitkinin çevreyle gaz alışverişini sağlar.\n-Kloroplast taşıdığı için fotosentez yapar.\n-Açılıp kanabilen canlı hücrelerdir.\n-Terlemeyi sağlar. (Terleme ile sadece su atılır).";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nBitkilerin toprak altı organlarında ve tamamen suya gömülü yaşayan su bitkilerinde stoma bulunmaz.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
