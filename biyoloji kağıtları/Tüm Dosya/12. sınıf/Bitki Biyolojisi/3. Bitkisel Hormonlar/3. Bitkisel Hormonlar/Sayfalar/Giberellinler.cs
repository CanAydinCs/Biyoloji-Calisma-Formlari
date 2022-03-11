using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Bitkisel_Hormonlar.Sayfalar
{
    public partial class Giberellinler : Form
    {
        public Giberellinler()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Köklerde, genç yapraklarda ve bitkinin embriyolarında üretilir.\n-Hücre bölünmesi ve hücre büyümesini uyararak gövde ve yaprak uzamasını, bazı bitkilerde çiçeklenmeyi teşvik eder.\n-Hücreye su alımını kolaylaştırarak hücrelerin genişlemesini, uyku halindeki tohumun uyanmasını sağlar.\n-Tohumun çimlenmesini uyarır. [Tohumun uyku halinden (dormansi) uyanmasını sağlar.]\n-Tarımda meyvelerin büyük olmasını sağlamak için ve çekirdeksiz üzüm elde etmek için kullanılır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nGiberellin; gövde uzaması ile salkım seyreltmek, çekirdeksiz meyve oluşumunu sağlamak ve tane iriliğini arttırmak amacıyla başta üzüm olmak üzere bir çok meyvede kullanılır.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
