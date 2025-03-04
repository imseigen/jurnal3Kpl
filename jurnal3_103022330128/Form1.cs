using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal3_103022330128
{
    public partial class Form1 : Form
    {
        private int angka1 = 0;
        private int angka2 = 0;
        private string operasi = "";

        public Form1()
        {
            InitializeComponent();
            btn0.Click += tombolAngka_Click;
            btn1.Click += tombolAngka_Click;
            btn3.Click += tombolAngka_Click;
            btn4.Click += tombolAngka_Click;
            btn5.Click += tombolAngka_Click;
            btn6.Click += tombolAngka_Click;
            btn7.Click += tombolAngka_Click;
            btn8.Click += tombolAngka_Click;
            btn9.Click += tombolAngka_Click;
            btnSamadengan += tombolAngka_Click;
            btnTambah += tombolAngka_Click;

        }

        private void tombolAngka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            output.Text += btn.Text;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSamadengan_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }
    }
}
