using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar, alan, cevre;


            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = birkenar * 4;

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = true;
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "KARE";
            textBox1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;

            label1.Text = "DİKDÖRTGEN";
            label2.Text = "Kısa Kenar";
            panel1.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int kisa, uzun, alan, cevre;

            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            alan = kisa * uzun;
            cevre = 2 * (kisa + uzun);

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();



        }
    }
}
