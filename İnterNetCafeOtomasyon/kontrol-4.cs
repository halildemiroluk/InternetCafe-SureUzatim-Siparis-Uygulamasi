using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnterNetCafeOtomasyon
{
    public partial class kontrol_4 : UserControl
    {
        public kontrol_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Süreniz 15dk uzatıldı!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Süreniz 30dk uzatıldı!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Süreniz 45dk uzatıldı!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Süreniz 1Saat uzatıldı!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Süreniz 2Saat uzatıldı!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Süreniz 3Saat uzatıldı!");
        }
    }
}
