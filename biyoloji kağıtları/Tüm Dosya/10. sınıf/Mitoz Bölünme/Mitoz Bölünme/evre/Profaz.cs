using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitoz_Bölünme.evre
{
    public partial class Profaz : Form
    {
        public Profaz()
        {
            InitializeComponent();
        }

        private void Profaz_Load(object sender, EventArgs e)
        {
            label1.Text= "Tanım:\n-Kromatin iplikleri kısalıp kalınlaşarak kromozom halini alır.\n-Çekirdek zarı ve çekirdekçik eriyerek kaybolur.\n-Hayvan hücrelerinde bulunan ve interfaz evresinde eşlenmiş olan sentrozomlar (sentriyoller) ayrı kutuplara doğru giderken, aralarında iğ iplikleri oluşur. İğ iplikleri iki sentrozomdan uzanan mikrotübüllerdir.\n-Bitki hücrelerinde sentrozom bulunmaz iğ ipliklerini sitoplazmada bulunan özel proteinler (mikrotübüller) oluşturur. Oluşan iğ ipliklerinin bir kısmı kinekorlara bağlanır.";
            pictureBox1.ImageLocation = "Resimler\\prfz.png";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
