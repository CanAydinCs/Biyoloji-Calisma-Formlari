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
    public partial class Anafaz : Form
    {
        public Anafaz()
        {
            InitializeComponent();
        }

        private void Anafaz_Load(object sender, EventArgs e)
        {
            label1.Text = "-Kromozomların sentromerleri bölünür. \n- Kardeş kromatitler birbirlerinden ayrılarak zıt kutuplara çekilirler. Bu hareket kinetokorlara bağlı mikrotübüllerin boylarının kısalmasıyla gerçekleşir.\n-Artık kromatitler kromozom olarak adlandırılır. Bunun için anafaz evresinde kromozom sayısı iki katına çıkmış olur. (4n)\n-Kinetekora bağlı olmayan mikrotübüllerin uzamasıyla da hücrenin boyu uzar.\n-Hayvan hücresinde sitokinez başlar.";
            pictureBox1.ImageLocation = "Resimler\\anafaz.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
