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
    public partial class Sitokinin : Form
    {
        public Sitokinin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Kök uçlarında sentezlenir ve ksilemle meristem dokulara, tohumlara, yapraklara ve meyvelere taşınır.\n-Hücre bölünmesi için uyarıcı görev yapar. Özellikle ikincil meristemlerin aktif hale gelmesi ve bitkinin enin büyümesini sağlar.\n-Yanal tomurcuk gelişimini uyarır.\n-Bitki köklerinin büyümesinde olumlu etki yapar.\n-Yaprakların yeşil kalmasını sağlar.\n-Yaprak dökümünü geciktirir.\n-Klorofil sentezini uyarır.\n-Çimlenmeyi teşvik eder; yaşlanmayı geciktirir.\n-Çiçekçilerde bitkinin yaşlanmasını geciktirmek için kullanılır.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\nBitkinin özelleşmemiş genç hücrelerindeki farklılaşma oksin / sitokinin oranı ile kontrol edilir. Buna göre;\n1. Yaklaşık oksin/sitokinin oranının eşit olduğu doku kültüründe farklılaşma olmaksızın kallus adı verilen hücre kümesi oluşur.\n2. Oksin/sitokinin oranı yüksekse (oksin, sitokininden fazla ise) kallusta kök oluşumu başlar.\n3. Oksin / sitokinin oranı düşük ise (sitokinin, oksinden fazla ise) kallusta sürgün oluşumu başlar, yaprak ve gövde gelişir.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
