using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBilet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string sendData1;

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = Form1.sendData;// textBox3 ile yolcunun kadın yada erkek oldugunu seçtimizde oluşan veriyi 1 forma gönderen kod.
            groupBox1.Visible = false;          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendData1 = comboBox1.Text;
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(textBox3.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(comboBox3.Text);
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            groupBox1.Visible = false;
        }
    }
}
