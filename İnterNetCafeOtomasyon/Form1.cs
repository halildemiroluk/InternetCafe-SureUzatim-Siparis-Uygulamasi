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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrol_31.Show();
            kontrol_11.Hide();
            kontrol_41.Hide();
            kontrol_21.Hide();
            kontrol_31.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kontrol_21.Hide();
            kontrol_31.Hide();
            kontrol_41.Hide();
            kontrol_11.BringToFront();
        }

        private void kontrol_11_Load(object sender, EventArgs e)
        {

        }
        private void kontrol_21_Load(object sender, EventArgs e)
        {

        }
        private void kontrol_31_Load(object sender, EventArgs e)
        {

        }
        private void kontrol_41_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol_11.Hide();
            kontrol_31.Hide();
            kontrol_41.Hide();
            kontrol_21.Show();
            kontrol_21.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol_11.Show();
            kontrol_31.Hide();
            kontrol_41.Hide();
            kontrol_21.Hide();
            kontrol_11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kontrol_41.Show();
            kontrol_11.Hide();
            kontrol_31.Hide();
            kontrol_21.Hide();
            kontrol_41.BringToFront();
        }

        private void kontrol_41_Load_1(object sender, EventArgs e)
        {

        }
    }
}
