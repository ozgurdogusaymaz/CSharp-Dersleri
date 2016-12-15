using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        int sayi1,sayi2= 0;

        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi1 = rastgele.Next(1, 7);
            sayi2 = rastgele.Next(1, 7);
            
            //hata aldığım yer
            zarPic1.Image = Image.FromFile(@"gorseller//"+ sayi1.ToString() + ".png");
            zarPic2.Image = Image.FromFile(@"gorseller//" + sayi2.ToString() + ".png");
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
    }
}
