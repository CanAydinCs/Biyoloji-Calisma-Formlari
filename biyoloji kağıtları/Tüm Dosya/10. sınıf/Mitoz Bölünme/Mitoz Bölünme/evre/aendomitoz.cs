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
    public partial class aendomitoz : Form
    {
        public aendomitoz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Amitoz:\nÇekirdek zarı erimeden boğumlanarak ikiye bölünmesinden sonra sitoplazmanın da boğumlanarak ikiye ayılması şeklinde gerçekleşen bölünme şeklidir.\nÖrnek: Amip, öglena, gibi, ökaryot bir hücrelilerin bölünmesi, bira mayasının tomurcuklanması.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Amitoz Not:\nÇekirdeği olmayan prokaryotlarda hücreler, binary fisyon denilen bölünme yöntemiyle ikiye bölünme diyebileceğimiz en basit bölünme şekli ile çoğalırlar.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Endomitoz:\nİnterfaz ve çekirdek bölünmesi (karyokinez) olurken, sitoplazma bölünmesinin gerçekleşmediği bölünmedir. Böylece çok çekirdekli hücreler oluşur.\nÖrnek: Bazı cıvık mantarlarda ve polen oluşumunda görülür."; 
        }

        private void aendomitoz_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\endomtz.png";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Endomitoz Not:\nÇizgili kaslarımızdaki çok çekirdeklilik endomitoz ile değil, hücre kaynaşması ile oluşur.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Endomitoz Not:\nEndomitoz, amitoz gibi hücre iç ritmini aksatmadan hücrelerin daha fazla metabolik aktiviteye sahip olmasını sağlar.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
