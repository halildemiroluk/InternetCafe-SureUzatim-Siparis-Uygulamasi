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
    public partial class kontrol_2 : UserControl
    {
        public kontrol_2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kontrol_2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alındı Masanıza Servis Edilicek!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, a2, a3, a4, a5, a6, a7, a8, a9, a10;
            a = Convert.ToInt16(numericUpDown1.Value);
            a2 = Convert.ToInt16(numericUpDown6.Value);
            a3 = Convert.ToInt16(numericUpDown2.Value);
            a4 = Convert.ToInt16(numericUpDown3.Value);
            a5 = Convert.ToInt16(numericUpDown4.Value);
            a6 = Convert.ToInt16(numericUpDown11.Value);
            a7 = Convert.ToInt16(numericUpDown5.Value);
            a8 = Convert.ToInt16(numericUpDown7.Value);
            a9 = Convert.ToInt16(numericUpDown8.Value);
            a10 = Convert.ToInt16(numericUpDown9.Value);
            int c = a * 40 + a2 * 25 + a3 * 5 + a4 * 17 + a5 * 23 + a6 * 20 + a7 * 10 + a8 * 12 + a9 * 10 + a10 * 10;
            textBox1.Text = c.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
