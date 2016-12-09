using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenklemIfKomutu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ortalama, sinav1, sinav2;

            sinav1 = Convert.ToInt32(textBox2.Text);
            sinav2 = Convert.ToInt32(textBox3.Text);

            ortalama = (sinav1 + sinav2) / 2;

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(ortalama);

            if (ortalama >= 50)
            {
                listBox5.Items.Add("Geçti");
            }
            else
            {
                listBox5.Items.Add("Kaldı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
