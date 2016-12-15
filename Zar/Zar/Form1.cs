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

            if (sayi1 == 1)
            {
                zarPic1.Image = ımageList1.Images[0];
            }
            else if (sayi1 == 2)
            {
                zarPic1.Image = ımageList1.Images[1];
            }
            else if (sayi1 == 3)
            {
                zarPic1.Image = ımageList1.Images[2];
            }
            else if (sayi1 == 4)
            {
                zarPic1.Image = ımageList1.Images[3];
            }
            else if (sayi1 == 5)
            {
                zarPic1.Image = ımageList1.Images[4];
            }
            else if (sayi1 == 6)
            {
                zarPic1.Image = ımageList1.Images[5];
            }
            if (sayi2 == 1)
            {
                zarPic1.Image = ımageList1.Images[0];
            }
            else if (sayi2 == 2)
            {
                zarPic2.Image = ımageList1.Images[1];
            }
            else if (sayi2 == 3)
            { 
                zarPic2.Image = ımageList1.Images[2];
            }
            else if (sayi2 == 4)
            {
                zarPic2.Image = ımageList1.Images[3];
            }
            else if (sayi2 == 5)
            {
                zarPic2.Image = ımageList1.Images[4];
            }
            else if (sayi2 == 6)
            {
                zarPic2.Image = ımageList1.Images[5];

            }
            //hata aldığım yer
            //zarPic1.Image = Image.FromFile(@"gorseller//"+ sayi1.ToString() + ".png");
            //zarPic2.Image = Image.FromFile(@"gorseller//" + sayi2.ToString() + ".png");
            timer1.Enabled = false;
            //label1.Text = sayi1.ToString();
            //label2.Text = sayi2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
    }
}
