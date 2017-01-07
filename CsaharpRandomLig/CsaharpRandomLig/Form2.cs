using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsaharpRandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int adspuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Visible = true;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label5.Text = a.ToString();
            label4.Text = b.ToString();
            label6.Text = c.ToString();
            label7.Text = d.ToString();

            if (Convert.ToInt32(label5.Text) >Convert.ToInt32(label4.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label5.Text) == Convert.ToInt32(label4.Text))
            {
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                fbpuan = fbpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                adspuan = adspuan + 1;
                labeladspuan.Text = adspuan.ToString();
            }
            else
            {
                adspuan = adspuan + 3;
                labeladspuan.Text = adspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Visible = true;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label11.Text = a.ToString();
            label12.Text = b.ToString();
            label13.Text = c.ToString();
            label14.Text = d.ToString();

            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label12.Text))
            {
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                bjkpuan = bjkpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label7.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label7.Text))
            {
                fbpuan = fbpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                adspuan = adspuan + 1;
                labeladspuan.Text = adspuan.ToString();
            }
            else
            {
                adspuan = adspuan + 3;
                labeladspuan.Text = adspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label21.Text = a.ToString();
            label22.Text = b.ToString();
            label23.Text = c.ToString();
            label24.Text = d.ToString();

            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label22.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label22.Text))
            {
                fbpuan = fbpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                bjkpuan = bjkpuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label24.Text))
            {
                adspuan = adspuan + 3;
                labeladspuan.Text = adspuan.ToString();
            }
            else if (Convert.ToInt32(label23.Text) == Convert.ToInt32(label24.Text))
            {
                adspuan = adspuan + 1;
                labeladspuan.Text = adspuan.ToString();
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
            }
            else
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           //Skor eşit oldugunda oyun tekrar başlatılamadı
           //Skorlar eşit ise avaraj hesabı yaptır
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeladspuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Kaan\\Desktop\\Yeni klasör\\GS.mp3";
                label31.Text = "Şampiyon Galatasaray";
                pictureBox1.ImageLocation = "C:\\Users\\Kaan\\Desktop\\Yeni klasör (2)\\GS.png";
            }
            else if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeladspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Kaan\\Desktop\\Yeni klasör\\FB.mp3";
                label31.Text = "Şampiyon Fenerbahçe";
                pictureBox1.ImageLocation = "C:\\Users\\Kaan\\Desktop\\Yeni klasör (2)\\FB.png";
            }
            else if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeladspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Kaan\\Desktop\\Yeni klasör\\BJK.mp3";
                label31.Text = "Şampiyon Beşiktaş";
                pictureBox1.ImageLocation = "C:\\Users\\Kaan\\Desktop\\Yeni klasör (2)\\BJK.png";
            }
            else if (Convert.ToInt32(labeladspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeladspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labeladspuan.Text) > Convert.ToInt32(labelfbpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Kaan\\Desktop\\Yeni klasör\\ADS.mp3";
                label31.Text = "Şampiyon Adana Demirspor";
                pictureBox1.ImageLocation = "C:\\Users\\Kaan\\Desktop\\Yeni klasör (2)\\ADS.png";
            }
            else
            {
                MessageBox.Show("Skorlar Eşit!\nTekrar Oyna");
            }
            label31.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            label31.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }
    }
}
