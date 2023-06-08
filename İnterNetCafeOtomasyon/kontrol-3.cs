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
    public partial class kontrol_3 : UserControl
    {
        public kontrol_3()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void kontrol_3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz alındı masana getiriliyor!!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int a, a2, a3, a4, a5, a6, a7, a8, a9,a10;
            a = Convert.ToInt16(numericUpDown1.Value);
            a2 = Convert.ToInt16(numericUpDown3.Value);
            a3 = Convert.ToInt16(numericUpDown2.Value);
            a4 = Convert.ToInt16(numericUpDown4.Value);
            a5 = Convert.ToInt16(numericUpDown5.Value);
            a6 = Convert.ToInt16(numericUpDown6.Value);
            a7 = Convert.ToInt16(numericUpDown7.Value);
            a8 = Convert.ToInt16(numericUpDown9.Value);
            a9 = Convert.ToInt16(numericUpDown8.Value);
            a10 = Convert.ToInt16(numericUpDown10.Value);
            int c = a * 479 + a2 * 379 + a3 * 32 + a4 * 280 + a5 * 799 + a6 * 111 + a7 * 249 + a8 * 350 + a9 * 44 + a10 * 32;
            textBox1.Text = c.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
