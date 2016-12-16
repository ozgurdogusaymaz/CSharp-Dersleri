using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Kaan\\Desktop\\Oscar & The wolf - Joaquim.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\Kaan\\Desktop\\Vatan.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Kaan\\Desktop\\Oscar and the wolf Bloom.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\Kaan\\Desktop\\mevsim-pizza.png";
        }
    }
}
