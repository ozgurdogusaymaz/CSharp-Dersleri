using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.renklerinDili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;

            if (comboBox1.Text =="Mavi")
            {
                label4.Text = textBox1.Text +":\n"+ comboBox1.Text+ " rengi" + " mutluluğun ve pozitifliğin simgesidir.";
                button2.BackColor = Color.Blue;
                label5.Text = "MAVİ";
                label5.ForeColor = Color.Blue;
                label4.ForeColor =Color.Blue;
            }

            if (comboBox1.Text == "Sarı")
            {
                label4.Text = textBox1.Text + ":\n" + comboBox1.Text + " rengi" + "  acının ve hüsnün simgesidir.";
                button2.BackColor = Color.Yellow;
                label5.Text = "SARI";
                label5.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
            }

            if (comboBox1.Text == "Kırmızı")
            {
                label4.Text = textBox1.Text + ":\n" + comboBox1.Text + " rengi" + "  kan ve tutkunun simgesidir.";
                button2.BackColor = Color.Red;
                label5.Text = "KIRMIZI";
                label5.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
            }

            if (comboBox1.Text == "Yeşil")
            {
                label4.Text = textBox1.Text + ":\n" + comboBox1.Text + " rengi" + "  doğallığın ve temizliğin simgesidir.";
                button2.BackColor = Color.Green;
                label5.Text = "YEŞİL";
                label5.ForeColor = Color.Green;
                label4.ForeColor = Color.Green;
            }

            if (comboBox1.Text == "Siyah")
            {
                label4.Text = textBox1.Text + ":\n" + comboBox1.Text + " rengi" + "  kötülüğün ve bunalımın simgesidir.";
                button2.BackColor = Color.Black;
                label5.Text = "SİYAH";
                label5.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }

            if (comboBox1.Text == "Beyaz")
            {
                label4.Text = textBox1.Text + ":\n" + comboBox1.Text + " rengi" + "  duruluğun ve sadeliğin simgesidir.";
                button2.BackColor = Color.White;
                label5.Text = "BEYAZ";
                label5.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
        }
    }
}
