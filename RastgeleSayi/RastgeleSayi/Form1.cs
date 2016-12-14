using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sayiuretBtn_Click(object sender, EventArgs e)
        {
        Random rastgele = new Random();
            int sayi = rastgele.Next(0,50);
            sayiTxt.Text = sayi.ToString();
        }
    }
}
