using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Fotoperyodizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "-Bitkilerin gün uzunluğuna bağlı olarak gelişim göstermesi olayına fotoperiyodizm denir.\n-Bitkilerin gelişim gösterdikleri evreye ise fotoperiyot denir.\n-Fotoperiyot bitkilerde büyüme, gelişme, çiçeklenme, yaprakların dökülmesi ve durgunluk döneminin başlaması gibi fizyolojik olayları etkilemektedir.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nTomurcuklar çiçekleri oluşturur; ancak, fotoperiyodu yapraklar saptar. Çiçeklenme için gerekli fotoperiyot sağlandığında, yaprakların çiçek oluşturmaları için tomurcuklara bir sinyal göbndermeleri gerekir. Yaprakların tümü koparılırsa, bitki fotoperiyoda karşı körleşir.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Sayfalar.Uzun x = new Sayfalar.Uzun();
            x.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text = "2) Kısa gün (uzun-gece) bitkileri:\nGecenin gündüzden daha uzun olduğu mevsimlerde çiçek açıp gelişen bitkilerdir\n-Kışa doğru çiçek açarlar.\n-Örnek çilek, sütleğen, kazayağı, soya fasulyesi, patates uzun-gece bitkilerine örnek olarak verilebilir.";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Sayfalar.Bitki x = new Sayfalar.Bitki();
            x.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Sayfalar.Sorular x = new Sayfalar.Sorular();
            x.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
