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
    public partial class Etilen : Form
    {
        public Etilen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "-Olgunlaşmış meyve dokularında, yaşlı yapraklarda ve çiçeklerde üretilir.\n-Etilen üretimi oksin miktarına bağlıdır. Oksin miktarı belli bir seviyeyi aşarsa etilen üretimi uyarılır. Etilen, oksin etkisini bastırarak bitki gelişimini engeller.\n-Gaz halinde olan bir hormondur. Bulunduğu ortama kolayca yayılabildiğinden diğer meyveleri de çürütür.\n-Bitkiler kuraklık, su baskını, mekanik basınç ve enfeksiyon gibi streslere yanıt olarak üretilir.\n-Meyve olgunlaşmasında etkilidir.\n-Bitkinin yaprak dökümünü hızlandırır.\n-Programlanmış hücre ölümlerine yol açar. (Bir yıllık bitkinin çiçek açtıktan sonra ölmesi gibi)";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Not:\n-Etilen etkisi ile hücre çeperi bileşenlerinin enzimatik olarak parçalanması sonucunda ve ayrıca nişasta ve asitlerin şekere dönüşümü meyveyi tatlandırır. Böylece meyve olgunlaşır. Ancak olgunlaşma tamamlandıktan sonra etilen üretimi devam ederse meyve çürür.\n-Çürük bir elma gerçekten bir kasa elmayı çürütür.\n-Soğuk depolarda bekletilen elmalar çabuk bozulmasın diye sıklıkla etilen gazının etkisini kırmak için CO2 ile yıkanır.";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
