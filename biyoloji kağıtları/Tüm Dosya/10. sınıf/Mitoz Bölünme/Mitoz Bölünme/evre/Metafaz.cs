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
    public partial class Metafaz : Form
    {
        public Metafaz()
        {
            InitializeComponent();
        }

        private void Metafaz_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\mtfz.png";
            label1.Text = "Kinetokorlarından iğ ipliklerine tutunmuş kromozomlar hücreninekvator düzlemine dizilir.\n-Kromozomların mikroskopta en belirgin görüldüğü evredir.\n-Kromozomların fotoğrafı çekilerek karyotip oluşturulabilir.\nNot: Karyotip; kromozomların uzunluk, sentromer konumu gibi özelliklerine göre sınıflandırılıp dizilmesidir. Bu yolla anormal kromozom sayıları tespit edilebilir.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
