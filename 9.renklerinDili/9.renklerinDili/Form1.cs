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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yönetici" && textBox2.Text == "123456")
            {
                Form2 renkformu = new Form2();
                renkformu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!\nTekrar Deneyiniz.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
